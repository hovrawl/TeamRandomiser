using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRandomiser.Enums;

namespace TeamRandomiser.Classes
{
    public class Player
    {
        public Guid Id { get; set; }

        /// <summary>
        ///     In Game Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Colloquial Name
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        ///  Player Rank
        /// </summary>
        public PlayerRank Rank { get; set; }

        /// <summary>
        ///     List of players this player should be paired with
        /// </summary>
        public List<PlayerRef> Partners { get; set; } = new List<PlayerRef>();

        /// <summary>
        ///     Return this Player as a PlayerRef
        /// </summary>
        /// <returns></returns>
        public PlayerRef ToPlayerRef()
        {
            return new PlayerRef()
            {
                Id = Id,
                Name = Name
            };
        }
    }

    public class PlayerRef
    {
        /// <summary>
        ///     Player Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Player Name
        /// </summary>
        public string Name { get; set; }
    }
}
