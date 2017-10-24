using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligagram
{
    public class Group : Chat
    {
        public override bool CanSendMessage(int memberId)
        {
            foreach (var member in Members)
        }
    }
}
