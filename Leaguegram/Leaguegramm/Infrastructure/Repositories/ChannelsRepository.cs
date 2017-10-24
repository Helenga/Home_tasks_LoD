using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegramm.Domain;

namespace Leaguegramm.Infrastructure.Repositories
{
    class ChannelsRepository
    {
        static ChannelsRepository()
        {
            channelsRepository = new List<Channel>();
        }

        static List<Channel> channelsRepository;
    }
}
