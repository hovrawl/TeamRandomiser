using System;
using System.Collections.Generic;
using System.Linq;

using LiteDB;
using TeamRandomiser.Classes;

namespace TeamRandomiser.Helpers
{
    class LiteDbHelper
    {
        private const string DbName = "Datastore.db";

        private const string CollectionPlayers = "players";
        private const string CollectionTeams = "teams";

        /// <summary>
        ///     Fetch All Players
        /// </summary>
        /// <returns></returns>
        public static List<Player> GetPlayers()
        {
            using (var db = new LiteDatabase(DbName))
            {
                // Get Token Collection

                var collection = db.GetCollection<Player>(CollectionPlayers);
                var players = collection.FindAll();

                return players.ToList();
            }
        }

        /// <summary>
        ///     Upsert Player
        /// </summary>
        /// <param name="player"></param>
        public static void UpsertPlayer(Player player)
        {
            using (var db = new LiteDatabase(DbName))
            {
                // Update Player

                var collection = db.GetCollection<Player>(CollectionPlayers);
         
                var origPlayer = collection.FindById(player.Id) ?? new Player();

                origPlayer.Id = player.Id;
                origPlayer.Name = player.Name;
                origPlayer.DisplayName = player.DisplayName;
                origPlayer.Rank = player.Rank;
                origPlayer.Partners = player.Partners;

                collection.Upsert(origPlayer);

                player.Id = origPlayer.Id;
            }
        }

        /// <summary>
        ///     Get Player By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Player GetPlayerById(Guid id)
        {
            using (var db = new LiteDatabase(DbName))
            {
                if (!db.CollectionExists(CollectionPlayers)) return null;

                var collection = db.GetCollection<Player>(CollectionPlayers);
                if (collection.Exists(i => i.Id == id))
                {
                    return collection.FindById(id);
                }

                return null;
            }
        }

        /// <summary>
        ///     Delete Player
        /// </summary>
        /// <param name="player"></param>
        public static void DeletePlayer(Player player)
        {
            if (player == null) return;

            using (var db = new LiteDatabase(DbName))
            {
                if (!db.CollectionExists(CollectionPlayers)) return;

                var collection = db.GetCollection<Player>(CollectionPlayers);
                if (collection.Exists(i => i.Id == player.Id))
                {
                    collection.Delete(player.Id);
                }
            }
        }

        /// <summary>
        ///     Delete List of Players
        /// </summary>
        /// <param name="players"></param>
        public static void DeletePlayers(List<Player> players)
        {
            foreach (var player in players)
            {
                DeletePlayer(player);
            }
        }

        /// <summary>
        ///     Delete all Players
        /// </summary>
        public static void DeleteAllPlayers()
        {
            using (var db = new LiteDatabase(DbName))
            {
                if (!db.CollectionExists(CollectionPlayers)) return;

                var collection = db.GetCollection<Player>(CollectionPlayers);
                collection.DeleteAll();
            }
        }
    }
}
