using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Domain
{
    internal class User
    {
        public User(Guid id, string name)
        {
            _id = id;
            _name = name;
        }

        private readonly Guid _id;
        private string _name;
    }
}
