using System;
using System.Collections.Generic;

using Leaguegram.Infrastucture;
using Leaguegram.Domain;
using Leaguegram.Common;

namespace Leaguegram.Application
{
    class User : IUser
    {
        public User (
            UsersRepository usersRepository,
            Account account,
            Dialogue dialogue,
            Group group,
            Channel channel,
            ChatsRepository chatsRepository) 
        {
            _usersRepository = usersRepository;
            _account = account;
            _dialogue = dialogue;
            _group = group;
            _channel = channel;
            _chatsRepository = chatsRepository;
        }  
        

        public void CreateAccount(string username, string password)
        {
            _account = new Account(username, password);
        }

        public IEnumerable<Account> FindUser(string stringForSearch)
        {
            return _usersRepository.FindAccountsByStringForSearch(stringForSearch);
        }

        public IEnumerable<Channel> FindChannel(string stringForSearch)
        {
            return _chatsRepository.FindChannelsByTitle(stringForSearch);
        }

        public void CreateDialogue(string usernameToSendMessage)
        {
            Guid id = ChooseUser(usernameToSendMessage);
            _dialogue = new Dialogue(_account.Id, id);
            _account.AddToDialogues(id, usernameToSendMessage);
        }

        public void SubscribeToChannel(Guid chatId, string title)
        {
            _account.AddToDialogues(chatId, title);
        }

        public void CreateGroup(string title)
        {
            _group = new Group(_account.Id, title);
        }

        public void CreateChannel(string title)
        {
            _channel = new Channel(_account.Id, title);
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
            _chatsRepository.DeleteMessageFromChat(id, messageId);
        }

        public Message CreateMessage(string text)
        {
            Message message = new Message(text, _account.Id);
            return message;
        }

        protected Guid ChooseDialogue(string nameOfDialogue)
        {
            return _account.GetIdOfDialogue(nameOfDialogue);
        }

        protected Guid ChooseUser(string username)
        {
            return _usersRepository.FindUserIdByName(username);
        }

        protected UsersRepository _usersRepository;
        protected Account _account;
        protected Dialogue _dialogue;
        protected Group _group;
        protected Channel _channel;
        protected ChatsRepository _chatsRepository;
    }
}
