using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegramm.Application.Interfaces;
using Leaguegramm.Infrastructure;
using Leaguegramm.Infrastructure.Repositories;
using Leaguegramm.Domain;

namespace Leaguegramm.Application
{
    public class User : IUser
    {
        public string Username { get; private set; }

        private IdProvider _idProvider;
        private RepositoryProvider _repositoryProvider;

        private string _password;
        private List<Chat> _dialogues;
        private Guid _id;

        public User Register(string username, string password)
        {
            User user = new User();
            user.Username = username;
            user._password = password;
            user._id = _idProvider.GetId();
            user._dialogues = _repositoryProvider.CreateRepository<Chat>();
            return user;
        }

        public void FindUser(string userName)
        {
            
        }

        public void FindChannel(string channelName)
        {
            throw new NotImplementedException();
        }

        public void CreateGroup()
        {
            throw new NotImplementedException();
        }

        public void CreateChannel()
        {
            throw new NotImplementedException();
        }

        public void SubscribeTo(string channelName)
        {
            throw new NotImplementedException();
        }

        public List<Chat> GetDialogues()
        {
            return _dialogues;
        }

        public void ChooseDialogue()
        {
            
        }

        public void GetMessages()
        {
            throw new NotImplementedException();
        }

        public void CreateMessage()
        {
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }

        public void DeleteMessage()
        {
            throw new NotImplementedException();
        }

        public void EditMessage()
        {
            throw new NotImplementedException();
        }
    }
}
