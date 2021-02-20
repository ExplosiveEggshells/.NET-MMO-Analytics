/*
 * NAME: PlayerCollection.cs
 * AUTHORS: Jake Rogers (z1826513), John Erwin (z1856469)
 * 
 * One of the three 'collection' classes; this one reads
 * in entries from the players.txt data file and parses
 * them into player objects.
 * 
 * Those newly made objects are then added to a Dictionary
 * with their ID being the key and the object itself being
 * the value.
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
    class PlayerCollection
    {
        private static Dictionary<uint, Player> playerCollection;

        /*
         * This default constructor instantiates the playerCollection, then
         * adds pairs to it using the players.txt data file
         */
        public PlayerCollection()
        {
            playerCollection = new Dictionary<uint, Player>();
            ConstructPlayerCollection();
        }

        /*
         * Static Accessor for playerCollection
         */
        public static Player At(uint id)
        {
            if (playerCollection.ContainsKey(id))
            {
                return playerCollection[id];
            } else
            {
                throw new CollectionIDNotFoundException();
            }
        }

        /*
         * Reads through the players.txt data file line-by-line,
         * parsing through a line and constructing Player object from it
         * and then inserting that pair into the playerCollection with the Player
         * ID being the key.
         */
        private void ConstructPlayerCollection()
        {
            try
            {
                string line;
                using (StreamReader inFile = new StreamReader("../../players.txt"))     // Access the file
                {
                    line = inFile.ReadLine();                                           // 'Prime the read'
                    while (line != null)                                                // While there are still more lines to read...
                    {
                        string[] tokens = line.Split('\t');                             // ...Tokenize the current line, delimiting by '\t'
                        Player newPlayer = ConstructPlayerFromTokens(tokens);           // ...Construct a Player from the tokens...
                        playerCollection.Add(newPlayer.ID, newPlayer);                  // ...Add that Player to the playerCollection...

                        line = inFile.ReadLine();                                       // ...Read the next line into 'line'.
                    }
                }
            }
            catch (Exception e)                                                         // Catch exception if the file reading fails.
            {
                Console.Write("[PlayerCollection]: Failed to read in player collection... ");
                Console.WriteLine(e);
            }
        }

        /*
         * Given an array of 8 string tokens, construct and return
         * a new Player by parsing them into valid data.
         * 
         * The tokens MUST represent data in this order:
         * [0] - Player ID          (uint)
         * [1] - Player Name        (string)
         * [2] - Player Race        (int)
         * [3] - Player Class       (int)
         * [4] - Player Role        (int)
         * [5] - Player Level       (uint)
         * [6] - Player EXP         (uint)
         * [7] - Guild ID           (uint)
         */
        private Player ConstructPlayerFromTokens(string[] tokens)
        {
            uint id = uint.Parse(tokens[0]);
            string name = tokens[1];
            Race race = (Race)int.Parse(tokens[2]);
            Class playerClass = (Class)int.Parse(tokens[3]);
            Role role = (Role)int.Parse(tokens[4]);
            uint level = uint.Parse(tokens[5]);
            uint exp = uint.Parse(tokens[6]);
            uint guildID = uint.Parse(tokens[7]);

            Player newPlayer = new Player(id, name, race, playerClass, role, level, exp, guildID);
            return newPlayer;
        }
        public static Dictionary<uint, Player> Player_Collection => playerCollection;

    }
}
