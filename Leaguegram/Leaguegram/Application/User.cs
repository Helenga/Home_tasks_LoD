using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegram.Infrastucture;
using Leaguegram.Domain;
using Leaguegram.Common;

namespace Leaguegram.Application
{
    internal class User : IUser
    {
        public void CreateAccount(string username, string password)
        {
            _account = new Account(username, password);
        }

        public IEnumerable<Account> FindUser(string stringForSearch)
        {
            return _usersRepository.FindAccountsByUserName(stringForSearch);
        }

        public IEnumerable<Channel> FindChannel(string stringForSearch)
        {
            return _chatsRepository.FindChannelsByTitle(stringForSearch);
        }

        public void CreateGroup(string title)
        {
            _group = new Group(title);
        }

        public void CreateChannel(string title)
        {
            _channel = new Channel(title);
        }

        public List<string> GetDialogues()
        {
            return _account.ShowDialogues();
        }
        
        public IEnumerable<Message> GetMessagesOfDialogue(string nameOfDialogue)
        {
            Guid id = ChooseDialogue(nameOfDialogue);
            return _chatsRepository.SelectMessagesFromChat(id);
        }

        public void SendMessageTo(string nameOfDialogue, Message message)
        {
            Guid id = ChooseDialogue(nameOfDialogue);
            _chatsRepository.AddMessageToChat(id, message);
        }

        public void EditMessageIn(string nameOfDialogue, Guid messageId, string newText)
        {
            Guid id = ChooseDialogue(nameOfDialogue);
            _chatsRepository.EditMessageInChat(id, messageId, newText);
        }

        public void DeleteMessageIn(string nameOfDialogue, Guid messageId)
        {
            Guid id = ChooseDialogue(nameOfDialogue);
            _chatsRepository.DeleteMessage(id, messageId);
        }

        public Message CreateMessage(string text)
        {
            Message message = new Message(text, _account.Id);
            return message;
        }

        private Guid ChooseDialogue(string nameOfDialogue)
        {
            return _account.GetIdOfDialogue(nameOfDialogue); ;
        }

        private UsersRepository _usersRepository;
        private Account _account;
        private Dialogue _dialogue;
        private Group _group;
        private Channel _channel;
        private ChatsRepository _chatsRepository;
    }
}
