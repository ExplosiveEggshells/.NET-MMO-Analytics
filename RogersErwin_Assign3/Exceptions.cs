/*
 * NAME: Exceptions.cs
 * AUTHORS: Jake Rogers (z1826513), John Erwin (z1856469)
 * 
 * This file contains multiple class definitions for
 * exceptions that get used in various places through
 * out the program.
 */
using System;

namespace RogersErwin_Assign3
{
    public class InventoryFullException : Exception
    {
        public override string ToString()
        {
            return "[InventoryFullException]: Tried to add item to an already full inventory!";
        }
    }

    public class InsufficentLevelException : Exception
    {
        public override string ToString()
        {
            return "[InsufficientLevelException]: Player attempted to equip an item who's level" +
                " requirement exceeds their level!";
        }
    }

    public class CollectionIDNotFoundException : Exception
    {
        public override string ToString()
        {
            return "[ItemIDNotFoundException]: Failed to find itemID within itemCollection!";
        }
    }
    public class PlayerNotFoundException : Exception
    {
        public override string ToString()
        {
            return "[PlayerNotFoundException]: The player you are looking for could not be found!";
        }
    }
    public class GuildNotFoundException : Exception
    {
        public override string ToString()
        {
            return "[GuildNotFoundException]: The guild you are looking for could not be found!";
        }
    }
    
    public class ItemNotFoundException : Exception
    {
        public override string ToString()
        {
            return "[ItemNotFoundException]: The item you are looking for could not be found!";
        }
    }
}
