using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegramm.Domain.Interfaces
{
    interface IChat
    {
        void addMessageToRepository();
        void removeMessageFromRepository();

        void AddParticipant(Guid guid);
    }
}
