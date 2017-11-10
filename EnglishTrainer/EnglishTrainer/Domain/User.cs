using System;

namespace EnglishTrainer.Domain
{
    internal class User
    {
        public User(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid GetId(string name)
        {
            if (Name == name)
                return Id;
            throw new ArgumentException("Name is not correct");
        }

        public Guid Id { get; }
        public string Name { get; }
    }
}
