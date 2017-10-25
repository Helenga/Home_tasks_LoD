using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegram.Domain;
using Leaguegram.Common;

namespace Leaguegram.Application
{
    interface IUser
    {
        void CreateAccount(string username, string password);

        IEnumerable<Account> FindUser(string stringForSearch);

        IEnumerable<Channel> FindChannel(string stringForSearch);

        void CreateGroup(string title);

        void CreateChannel(string title);

        List<string> GetDialogues();

        IEnumerable<Message> GetMessagesOfDialogue(string nameOfDialogue);

        void SendMessageTo(string nameOfDialogue, Message message);

        void EditMessageIn(string nameOfDialogue, Guid messageId, string newText);

        void DeleteMessageIn(string nameOfDialogue, Guid messageId);

        Message CreateMessage(string text);
    }
}
