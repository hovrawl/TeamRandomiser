using System;
using System.Collections.Generic;

namespace TeamRandomiser.Classes
{
    public class Team : List<Player>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public long Wins { get; set; }

        public long Losses{ get; set; }
    }
}