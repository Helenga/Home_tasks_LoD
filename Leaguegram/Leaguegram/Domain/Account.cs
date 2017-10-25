using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegram.Infrastucture;
using Leaguegram.Domain;
using Leaguegram.Common;

namespace Leaguegram.Domain
{
    public class Account
    {
        public Account(string username, string password)
        {
            Username = username;
            _password = password;
            _id = IdProvider.GetId();
            _dialogues = new Dictionary<Guid, string>();
        }

        public string Username { get; private set; }
        
        public List<string> ShowDialogues()
        {
            return _dialogues.Values.ToList();
        }

        public void AddToDialogues(Guid id, string name)
        {
            
        }

        /*
        public IEnumerable<Message> ShowMessages(string nameOfDialogue)
        {
            Guid id = GetIdOfDialogue(nameOfDialogue);
            return _chatsRepository.SelectMessagesFromDialogue(id);
        }*/



        public Guid GetIdOfDialogue(string nameOfDialogue)
        {
            foreach (var record in _dialogues)
            {
                if (record.Value.Equals(nameOfDialogue))
                    return record.Key;
            }
            throw new ArgumentException("Dialogue doesn't exist");
        }

        private string _password;
        private Dictionary<Guid, string> _dialogues { get; }
        public readonly Guid Id;

        private ChatsRepository _chatsRepository;
    }
}
