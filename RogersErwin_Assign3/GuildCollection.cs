/*
 * NAME: GuildCollection.cs
 * AUTHORS: Jake Rogers (z1826513), John Erwin (z1856469)
 * 
 * One of the three 'collection' classes; this one reads
 * in entries from the guilds.txt data file and inserts them
 * into a dictionary with the ID being the key and the guild
 * name being the value.
 * 
 * The dictionary itself is static, meaning that a single
 * instantiation of this object should be made at the beginning
 * of main and nowhere else. From there, the dictionary can
 * be accessed by using the static 'At' method from anywhere
 * else in the project.
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace RogersErwin_Assign3
{
    class GuildCollection
    {
        private static Dictionary<uint, Guild> guildCollection;

        /*
         * This default constructor instantiates the guildCollection,
         * then adds pairs to it using the guilds.txt data file
         */
        public GuildCollection()
        {
            guildCollection = new Dictionary<uint, Guild>();
            ConstructGuildCollection();
        }

        /*
         * Static accessor for guildCollection
         */
        public static Guild At(uint key)
        {
            if (guildCollection.ContainsKey(key))
            {
                return guildCollection[key];
            } else
            {
                throw new CollectionIDNotFoundException();
            }
        }

        /*
         * Reads through the guilds.txt data file line-by-line,
         * parsing through a line and extracting the guildID as well
         * as the guild Name and inserting them as a pair into
         * guildCollection.
         */
        private void ConstructGuildCollection()
        {
            try
            {
                string line;
                using (StreamReader inFile = new StreamReader("../../guilds.txt"))  // Access the file
                {
                    line = inFile.ReadLine();                                       // 'Prime the read'
                    while (line != null)                                            // While there are still more lines to read...
                    {
                        string[] tokens = line.Split('\t');                         // ... Tokenize the current line, delimited by '\t'...
                        string[] subToken = tokens[2].Split('-');                   // ... Tokenize the third string, separating the guild name from the server name.

                        Guild newGuild = new Guild(uint.Parse(tokens[0]), (GuildType)int.Parse(tokens[1]), subToken[0], subToken[1]);

                        guildCollection.Add(newGuild.ID, newGuild);                 // ...Add the line's ID # and guild name as a pair in guildCollection...

                        line = inFile.ReadLine();                                   // ...Read the next line into 'line'.
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write("[GuildCollection]: Failed to read in guild collection... ");
                Console.WriteLine(e);
            }
        }

        public static SortedSet<string> GetServerNames()
        {
            SortedSet<string> serverNames = new SortedSet<string>();

            foreach (KeyValuePair<uint, Guild> guild in guildCollection)
            {
                serverNames.Add(guild.Value.ServerName);
            }

            return serverNames;
        }

        public static Guild GetGuildIdByName(string name)
        {
            foreach (KeyValuePair<uint, Guild> guild in Guild_Collection)
            {
                if (guild.Value.Name.ToLower().Equals(name.ToLower()))
                {
                    return guild.Value;
                }
            }
            throw new GuildNotFoundException();
        }

        public Guild this[uint index] {
            get {
                if (guildCollection.ContainsKey(index))
                {
                    return guildCollection[index];
                }
                else
                {
                    throw new CollectionIDNotFoundException();
                }
            }
        }
        public static Dictionary<uint, Guild> Guild_Collection => guildCollection;
    }
}
