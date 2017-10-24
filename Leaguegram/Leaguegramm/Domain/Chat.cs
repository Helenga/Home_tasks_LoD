using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegramm.Operation;
using Leaguegramm.Infrastructure;

namespace Leaguegramm.Domain
{
    public class Chat
    {
        private Dictionary<Guid, Status> _participants;
        private List<Message> _repository;

        public void Create()
        {
            Chat chat = new Chat();
            chat._participants = new Dictionary<Guid, Status>();
            chat._repository = new List<Message>();
        }

        void addParticipant(Guid guid)
        {
            _participants.Add(guid, Status.user);
        }
    }
}
