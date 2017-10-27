using System;
using System.Collections.Generic;
using System.Linq;

using Leaguegram.Infrastucture;
using Leaguegram.Exceptions;

namespace Leaguegram.Domain
{
    internal class Account
    {
        public Account(string username, string password)
        {
            Username = username;
            _password = password;
            Id = Guid.NewGuid();
            _dialogues = new Dictionary<Guid, string>();
            _usersRepository = new UsersRepository();
            _usersRepository.AddToRepository(this);
        }

        public string Username { get; private set; }
        
        public List<string> ShowDialogues()
        {
            return _dialogues.Values.ToList();
        }

        public void AddToDialogues(Guid id, string name)
        {
            _dialogues.Add(id, name);
        }

        public Guid GetIdOfDialogue(string nameOfDialogue)
        {
            foreach (var record in _dialogues)
            {
                if (record.Value.Equals(nameOfDialogue))
                    return record.Key;
            }
            throw new DialogueDoesNotExistException();
        }

        private string _password;
        private Dictionary<Guid, string> _dialogues { get; }
        public readonly Guid Id;

        private UsersRepository _usersRepository;
    }
}
