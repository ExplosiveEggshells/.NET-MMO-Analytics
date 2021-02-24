/*
 * NAME: Guild.cs
 * AUTHORS: Jake Rogers (z1826513), John Erwin (z1856469)
 * 
 * This class holds data for Guild objects, which contain
 * and ID, name, and serverName.
 */
using System;
using System.Linq;

namespace RogersErwin_Assign3
{
    public class Guild : IComparable
    {
        private uint id;
        private string name;
        private string serverName;
        private GuildType type;

        #region CONSTRUCTORS
        // Default Constructor
        public Guild()
        {
            id = 0;
            name = "";
            serverName = "";
            type = GuildType.Casual;
        }

        public Guild(uint id, string name, string serverName)
        {
            this.id = id;
            this.name = name;
            this.serverName = serverName;
            type = GuildType.Casual;
        }

        public Guild(uint id, GuildType type, string name, string serverName)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.serverName = serverName;
        }

        public Guild(string name, GuildType type, string serverName)
        {
            id = GenerateNewID();
            this.name = name;
            this.type = type;
            this.serverName = serverName;
        }
        #endregion

        /*
         * IComparable interface method
         */
        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException();

            Guild rightOp = obj as Guild;

            if (rightOp != null)
            {
                return Name.CompareTo(rightOp.Name);
            } else
            {
                throw new ArgumentException("[Guild]:CompareTo argument is not a Guild!");
            }
        }

        public override string ToString()
        {
            string bracketedName = "<" + Name + ">";
            return string.Format("Name: {0,23} | Server: {1,20}", bracketedName, serverName);
        }

        /*
         * When a Guild is constructed without being given a specified ID,
         * it needs to be given a new, unique ID that doesn't exist yet
         * in the GuildCollection.
         * 
         * The solution for this problem is to find the largest-key value in
         * the GuildCollection currently, and make the next ID that key value
         * plus one.
         */
        private uint GenerateNewID()
        {
            if (GuildCollection.Guild_Collection == null || GuildCollection.Guild_Collection.Count == 0)
                return 0;

            uint nextID = GuildCollection.Guild_Collection.Keys.Max();
            nextID++;
            return nextID;
        }

        public uint ID { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public string ServerName { get { return serverName; } set { serverName = value; } }
        public GuildType Type { get { return type; } set { type = value; } }

    }
}
