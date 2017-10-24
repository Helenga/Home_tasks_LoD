using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligagram
{
    class PrivateChat : Chat
    {
        public override bool CanSendMessage(int memberId)
        {
            return IsParticipant();
        }
    }
}
