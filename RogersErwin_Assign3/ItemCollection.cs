/*
 * NAME: ItemCollection.cs
 * AUTHORS: Jake Rogers (z1826513), John Erwin (z1856469)
 * 
 * One of the three 'collection' classes; this one reads
 * in entries from the equipment.txt data file and parses
 * them into Item objects.
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
    class ItemCollection
    {
        private static Dictionary<uint, Item> itemCollection;

        /*
         * This default constructor instantiates the itemCollection,
         * then adds pairs to it using the equipment.txt data file
         */
        public ItemCollection()
        {
            itemCollection = new Dictionary<uint, Item>();
            ConstructItemCollection();
        }

        /*
         * Static Accessor for itemCollection
         */
        public static Item At(uint id)
        {
            if (itemCollection.ContainsKey(id))
            {
                return itemCollection[id];
            }
            else
            {
                throw new CollectionIDNotFoundException();
            }
        }

        /*
         * Reads through the equipment.txt data file line-by-line,
         * parsing through a line and constructing an Item object from it
         * and then inserting that pair into the itemCollection with the
         * item's ID being the key.
         */
        private void ConstructItemCollection()
        {
            try
            {
                string line;
                using (StreamReader inFile = new StreamReader("../../equipment.txt"))       // Access the file
                {
                    line = inFile.ReadLine();                                               // 'Prime the read'
                    while (line != null)                                                    // While there is still more lines to read...
                    {
                        string[] tokens = line.Split('\t');                                 // ...Tokenize the current line, delimiting by '\t'...
                        Item newItem = ConstructItemFromTokens(tokens);                     // ...Create an Item from those tokens...
                        itemCollection.Add(newItem.Id, newItem);                            // ...Add that item to the itemCollection...

                        line = inFile.ReadLine();                                           // ...Read the next line into 'line'.
                    }
                }
            } catch (Exception e)                                                           // Catch exception if file reading fails
            {
                Console.Write("[ItemCollection]: Failed to read in item collection... ");
                Console.WriteLine(e);
            }
         }

        /*
         * Given an array of 8 string tokens, construct and return
         * a new Item by parsing them into valid data.
         * 
         * The tokens MUST repesent data in this order:
         * [0] - Item ID            (uint)
         * [1] - Item Name          (string)
         * [2] - Item Type          (ItemType)
         * [3] - Item Level         (uint)
         * [4] - Item Primary       (uint)
         * [5] - Item Stamina       (uint)
         * [6] - Item Requirement   (uint)
         * [7] - Item Flavor Text   (string)
         */
        private Item ConstructItemFromTokens(string[] tokens)
        {
            uint id = uint.Parse(tokens[0]);
            string name = tokens[1];
            ItemType type = (ItemType) int.Parse(tokens[2]);
            uint itemLevel = uint.Parse(tokens[3]);
            uint primary = uint.Parse(tokens[4]);
            uint stamina = uint.Parse(tokens[5]);
            uint requirement = uint.Parse(tokens[6]);
            string flavor = tokens[7];

            Item newItem = new Item(id, name, type, itemLevel, primary, stamina, requirement, flavor);
            return newItem;
        }

        public static uint GetItemIdByName(string name)
        {
            foreach (KeyValuePair<uint, Item> item in Item_Collection)
            {
                if (item.Value.Name.ToLower().Equals(name.ToLower()))
                {
                    return item.Key;
                }
            }
            throw new ItemNotFoundException();
        }
        public static Dictionary<uint, Item> Item_Collection => itemCollection;
    }
}
