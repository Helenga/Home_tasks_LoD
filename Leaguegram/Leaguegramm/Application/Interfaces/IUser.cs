using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegramm.Application.Interfaces
{
    public interface IUser
    {
        User Register(string username, string password);
        void FindUser(string userName);
        void FindChannel(string channelName);
        void CreateGroup();
        void CreateChannel();
        void SubscribeTo(string channelName);
        void GetDialogues();
        void ChooseDialogue();
        void GetMessages();
        void CreateMessage();
        void SendMessage();
        void DeleteMessage();
        void EditMessage();
    }
}
