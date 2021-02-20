/*
 * NAME: Globals.cs
 * AUTHORS: Jake Rogers (z1826513), John Erwin (z1856469)
 * 
 * Contains multiple program-wide constants to be used
 * in various places throughout the program.
 * 
 * Furthermore, there are two enum's declared for both
 * Player and Item to use.
 */

using System;
using System.Collections.Generic;

namespace RogersErwin_Assign3
{
    static class Globals
    {

        private static uint MAX_ILVL = 360;
        private static uint MAX_PRIMARY = 200;
        private static uint MAX_STAMINA = 275;
        private static uint MAX_LEVEL = 60;
        private static uint GEAR_SLOTS = 14;
        private static uint MAX_INVENTORY_SIZE = 20;

        public static uint Max_ItemLevel { get { return MAX_ILVL; } }
        public static uint Max_Primary { get { return MAX_PRIMARY; } }
        public static uint Max_Stamina { get { return MAX_STAMINA; } }
        public static uint Max_Level { get { return MAX_LEVEL; } }
        public static uint Gear_Slots { get { return GEAR_SLOTS; } }
        public static uint Max_Inventory_Size { get { return MAX_INVENTORY_SIZE; } }

        /*
         * This jagged array can be used to get an array of classes that correspond 
         * to any given Role.
         * 
         * Example: roleClassArray[(uint)Role.Healer] would return an Array of Classes
         * containing Druid, Priest, and Paladin in uint form.
         */
        public static uint[][] roleClassArray = new uint[][]
        {
            new uint[] { (uint)Class.Warrior, (uint)Class.Druid, (uint)Class.Paladin },                         // Tank
            new uint[] { (uint)Class.Druid, (uint)Class.Priest, (uint)Class.Paladin },                          // Healer
            new uint[] {
                (uint)Class.Warrior, (uint)Class.Mage, (uint)Class.Druid, (uint)Class.Priest,
                (uint)Class.Warlock, (uint)Class.Rogue, (uint)Class.Paladin, (uint)Class.Hunter, (uint)Class.Shaman
                }                                                                                              // Damage
        };

        /*
         * Works similarly to the jagged array above, but it is inverted; you can
         * find the Roles associated to any given class.
         */
        public static uint[][] classRoleArray = new uint[][]
        {
            new uint[] { (uint)Role.Tank, (uint)Role.Damage },                         // Warrior
            new uint[] { (uint)Role.Damage },                                          // Mage
            new uint[] { (uint)Role.Tank, (uint)Role.Healer, (uint)Role.Damage },      // Druid
            new uint[] { (uint)Role.Healer, (uint)Role.Damage },                       // Priest
            new uint[] { (uint)Role.Damage },                                          // Warlock
            new uint[] { (uint)Role.Damage },                                          // Rogue
            new uint[] { (uint)Role.Tank, (uint)Role.Healer, (uint)Role.Damage},       // Paladin
            new uint[] { (uint)Role.Damage },                                          // Hunter
            new uint[] { (uint)Role.Healer, (uint)Role.Damage}                         // Shaman
        };
        
        /*
         * Given a Role, this will return a List of Classes that
         * fulfill that Role.
         */
        public static List<Class> GetClassesByRole(Role role)
        {
            List<Class> classes = new List<Class>();

            try
            {
                for (uint i = 0; i < roleClassArray[(uint)role].Length; i++)    // For every class at that Role's row...
                {
                    classes.Add((Class)roleClassArray[(uint)role][i]);          // ...Add it to the List.
                }
            } catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
                return new List<Class>();
            }

            return classes;
        }

        /*
         * Given a Class, this will return a List of Roles that
         * the given class fulfills.
         */
        public static List<Role> GetRolesByClass(Class myClass)
        {
            List<Role> roles = new List<Role>();

            try
            {
                for (uint i = 0; i < classRoleArray[(uint)myClass].Length; i++) // For every class at that Class' row...
                {
                    roles.Add((Role)classRoleArray[(uint)myClass][i]);          // ...Add it to the list.
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
                return new List<Role>();
            }

            return roles;
        }

    }

    public enum Race
    {
        Orc,
        Troll,
        Tauren,
        Forsaken
    };

    public enum ItemType
    {
        Helmet,
        Neck,
        Shoulders,
        Back,
        Chest,
        Wrist,
        Gloves,
        Belt,
        Pants,
        Boots,
        Ring,
        Trinket
    };

    public enum Role
    {
        Tank,
        Healer,
        Damage
    }

    public enum Class
    {
        Warrior,
        Mage,
        Druid,
        Priest,
        Warlock,
        Rogue,
        Paladin,
        Hunter,
        Shaman
    }

    public enum GuildType
    {
        Casual,
        Questing,
        MythicPlus,
        Raiding,
        PVP
    }
}
