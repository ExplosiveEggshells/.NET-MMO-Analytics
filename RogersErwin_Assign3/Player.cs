/*
 * NAME: Player.cs 
 * AUTHORS: Jake Rogers (z1826513), John Erwin (z1856469)
 * 
 * Records various data regarding players, including their name, race, level,
 * equipped Items, and Items in inventory. 
 * Furthermore, this class contains methods for allowing a player to equip and 
 * unequip Items (Essentially, moving them from 'gear' to 'inventory' and vice-versa).
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace RogersErwin_Assign3
{
    public class Player : IComparable
    {
        private uint id;
        private string name;
        private Race race;
        private uint level;
        private uint exp;
        private uint guildID;
        private uint[] gear;
        private List<uint> inventory;
        private Class playerClass;
        private Role role;

        private bool lastRingEquip = false;     // If false, the next ring equipped will replace the lower-indexed ring. If true, replace the higher-indexed ring.
        private bool lastTrinketEquip = false;  // Same as above, but for trinkets.

        #region CONSTURCTORS
        public Player() // Default constructor 
        {
            id = 0;
            name = "";
            race = 0;
            playerClass = (Class)(-1);
            level = 0;
            exp = 0;
            guildID = 0;
            gear = new uint[Globals.Gear_Slots];
            inventory = new List<uint>();

            AwardExperience(0);
        }

        public Player(uint id, string name, Race race, uint level, uint exp, uint guildID, uint[] gear, List<uint> inventory) // All-Encompassing Constructor
        {
            this.id = id;
            this.name = name;
            this.race = race;
            playerClass = (Class) (-1);
            this.Level = level;
            this.exp = exp;
            this.guildID = guildID;
            this.gear = gear;
            this.inventory = inventory;

            AwardExperience(0);             // Award the player 0 experience to attempt to trigger a level-up in case the Player is instantiated with enough exp to level up.
        }

        // Ignores gear and inventory, includes Class
        public Player(uint id, string name, Race race, Class playerClass, uint level, uint exp, uint guildID)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.playerClass = playerClass;
            this.level = level;
            this.exp = exp;
            this.guildID = guildID;
            this.gear = new uint[Globals.Gear_Slots];
            this.inventory = new List<uint>();
        }


        public Player(uint id, string name, Race race, Class playerClass, Role role, uint level, uint exp, uint guildID)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.playerClass = playerClass;
            this.role = role;
            this.level = level;
            this.exp = exp;
            this.guildID = guildID;
            this.gear = new uint[Globals.Gear_Slots];
            this.inventory = new List<uint>();
        }

        public Player(string name, Race race, Class playerClass, Role role)
        {
            this.id = GenerateNextID();
            this.name = name;
            this.race = race;
            this.playerClass = playerClass;
            this.role = role;
            this.level = 1;
            this.exp = 0;
            this.guildID = 0;
            this.gear = new uint[Globals.Gear_Slots];
            this.inventory = new List<uint>();
        }

        #endregion

        /*
         * Increment's the player's exp by expReceived.
         * 
         * Should this action give the player enough exp to level up,
         * their level is rise by one.
         * 
         * This method can level the player up multiple times in one call,
         * should the expReceived be large enough to do so.
         */
        private void AwardExperience(uint expReceived)
        {
            exp += expReceived; // Increment exp

            while (exp >= (level * 1000)) // While exp is >= amount required to level up...
            {
                exp -= (level * 1000); // ... Consume exp to level up...
                Level = Level + 1; // ... Then increment level.
                if(Level != Globals.Max_Level)
                {
                    Console.WriteLine("Ding!");
                }
            }
        }

        /*
         * Uses the provided newGearID to find the Item
         * with that ID. Then, equip that item into it's
         * corresponding slot (unequipping any item already
         * in that slot if necessary).
         * 
         * Prerequisite: A ItemCollection object MUST be built
         * in the main function in order for this to work. Otherwise,
         * it will have no database of items to check if an item
         * exists.
         */
        public void EquipGear(uint newGearID)
        {
            Item newItem = new Item();

            try
            {
                newItem = ItemCollection.At(newGearID);
            }
            catch (CollectionIDNotFoundException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Hint: It's likely that itemCollection has not be instantiated in main yet!");
            }



            if (Level < newItem.Requirement)
            {
                throw new InsufficentLevelException();
            }

            uint nextSlot;

            switch (newItem.Type)                                // Do special logic for equipping Rings and Trinkets:
            {
                case (ItemType.Ring):                            // For Rings and Trinkets, use helper methods to determine if the upper / lower slot should be equipped used.
                    nextSlot = GetNextRingSlot();
                    UnequipGear(nextSlot);
                    gear[nextSlot] = newGearID;
                    break;

                case (ItemType.Trinket):
                    nextSlot = GetNextTrinketSlot();
                    UnequipGear(nextSlot);
                    gear[nextSlot] = newGearID;
                    break;

                default:                                        // In every other case...
                    UnequipGear((uint)newItem.Type);           // Unequip the item in that slot
                    gear[(uint)newItem.Type] = newGearID;      // 'Equip' the item into that slot by inserting it's itemID.
                    break;
            }
        }


        /*
         * Moves an item in the specified gear slot to the Player
         * inventory, then clears that gearSlot to be 0, the ID 
         * to signify no item being in that slot.
         */
        public void UnequipGear(uint gearSlot)
        {
            if (this[gearSlot] != 0)                    // If that gear slot isn't empty...
            {
                AddItemToInventory(gear[gearSlot]);     // ... Place the item into the player's inventory...
                this[gearSlot] = 0;                     // ... Mark this slot as 'empty'.
            }
        }

        /*
         * Adds an item with itemID to the Player's inventory.
         * 
         * If doing so would cause the inventory size to exceed
         * Max_Inventory_Size, an exception will be thrown.
         */
        public void AddItemToInventory(uint itemID)
        {
            if (inventory.Count == Globals.Max_Inventory_Size)  // Check to see if adding another item would exceed the inventory size.
            {
                throw new InventoryFullException();             // If so, throw an InventoryFullException
            }

            inventory.Add(itemID);                        // If not full, add this item to the list of inventory items.
        }

        /*
         * Determines which ring slot should be the next one to be
         * occupied in all cases, returning that determination.
         */
        private uint GetNextRingSlot()
        {
            if (gear[10] == 0)                          // If lower-slot is empty...
            {
                return 10;                              // ...Return lower slot.
            }
            else if (gear[11] == 0)                     // Otherwise, if upper-slot is empty...
            {
                return 11;                              // ...Return upper slot.
            }
            else                                        // If both slots are occupied, alternate between upper and lower each time this occurs.
            {
                if (!lastRingEquip)
                {
                    lastRingEquip = !lastRingEquip;     // In either case, flip lastRingEquip to the opposite state of however it is now.
                    return 10;
                }
                else
                {
                    lastRingEquip = !lastRingEquip;
                    return 11;
                }

            }

        }

        /*
         * Shockingly, this does exactly what GetNextRingSlot
         * does, but for trinkets instead, funny that!
         */
        private uint GetNextTrinketSlot()
        {
            if (gear[12] == 0)                          // If lower-slot is empty...
            {
                return 12;                              // ...Return lower slot.
            }
            else if (gear[13] == 0)                     // Otherwise, if upper-slot is empty...
            {
                return 13;                              // ...Return upper slot.
            }
            else                                        // If both slots are occupied, alternate between upper and lower each time this occurs.
            {
                if (!lastTrinketEquip)
                {
                    lastTrinketEquip = !lastTrinketEquip;     // In either case, flip lastTrinketEquip to the opposite state of however it is now.
                    return 12;
                }
                else
                {
                    lastTrinketEquip = !lastTrinketEquip;
                    return 13;
                }

            }

        }

        /*
         * Prints out this player's Player:ToString, then prints out the
         * Item:ToString for every item in the player's equipped gear
         * array.
         */
        public void PrintGearList()
        {
            Console.WriteLine(this);                                // Print out this.ToString
            Console.WriteLine("~~~~ EQUIPPED ITEM LIST ~~~~\n");      // Header

            foreach (uint itemID in gear)                           // For every itemID in gear...
            {
                if (itemID == 0) { continue; }                      // ...Skip this loop if nothing is equipped there (itemID is 0).

                Item currentItem = new Item();                      // ...Create a default constructed Item...

                try                                                 // ...Attempt to assign currentItem to the item found in ItemCollection with key 'ItemID'. If this fails, the default constructor is still used...
                {
                    currentItem = ItemCollection.At(itemID);
                }
                catch (CollectionIDNotFoundException e)
                {
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Hint: It's likely that itemCollection has not be instantiated in main yet!");
                }

                Console.WriteLine(currentItem + "\n");              // ...Print out the Item:ToString for this item.
                                                                    // Note: If the default constructor is stilled used by this point, nothing will print out, which is nominal.

            }
        }

        /*
         * Fulfill IComparable Interface, allowing Player objects to be compared amongst
         * each other and sorted in a collection.
         */
        public int CompareTo(object obj)
        {
            if (obj == null) throw new          // Ensure obj isn't null.
                    ArgumentNullException();

            Player rightOp = obj as Player;     // Attempt to cast obj to a Player object

            if (rightOp != null)                // If obj was successfully casted to a player...
            {
                return Name.CompareTo(rightOp.Name); // ... Return the comparison of the two Player.Name strings.
            }
            else
            {
                throw new ArgumentException("[Player]:CompareTo argument is not a Player!"); // ... Otherwise, throw an exception.
            }
        }

        /*
         * When a Player is constructed without being given a specified ID,
         * it needs to be given a new, unique ID that doesn't exist yet
         * in the PlayerCollection.
         * 
         * The solution for this problem is to find the largest-key value in
         * the PlayerCollection currently, and make the next ID that key value
         * plus one.
         */
        private uint GenerateNextID()
        {
            if (PlayerCollection.Player_Collection == null)
                return 0;

            uint nextID = PlayerCollection.Player_Collection.Keys.Max();
            nextID++;
            return nextID;
        }

        public override string ToString()
        {
            string guildName = "";
            if (guildID == 0)
            {
                guildName = "None";
            }
            else
            {
                try                                                     // Try get the name of the player's guild by looking up guildID in GuildCollection, otherwise, guildID is used in toString.
                {
                    guildName = GuildCollection.At(guildID).Name;
                }
                catch (CollectionIDNotFoundException e)
                {
                    Console.WriteLine(e);
                    guildName = guildID.ToString();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Hint: GuildCollection likely isn't instantiated in main yet!");
                    guildName = guildID.ToString();
                }
            }
            
            guildName = "<" + guildName + ">";

            string str = String.Format("Name: {0,20} | Race: {1, 8} | Class: {2,8} | Role: {3, 8} | Level: {4,3} | Guild: {5, 30}", Name, race, playerClass, role, Level, guildName);
            return str;
        }

        // Properties
        public uint ID { get { return id; } }
        public string Name { get { return name; } }
        public Race PlayerRace { get { return race; } }
        public Class PlayerClass { get { return playerClass; } set { playerClass = value; } }
        public Role PlayerRole { get { return role; } set { role = value; } }
        public uint Level {
            get {
                return level;
            }
            set {
                uint clamped = value;
                clamped = Math.Max(0, clamped); // Returns 0 if 'clamped' is < 0, otherwise return 'clamped'.
                clamped = Math.Min(Globals.Max_Level, clamped); // Returns MAX_LEVEL if 'clamped' is > MAX_LEVEL, otherwise return 'clamped'.
                // Essentially, this clamps 'clamped' between [0, MAX_LEVEL].

                level = clamped; // Assign.
            }
        }

        public uint Exp {
            get {
                return exp;
            }
            set {
                uint expReceived = Math.Max(0, value); // Ensure exp received is 0 or greater.
                AwardExperience(expReceived);
            }
        }

        public uint GuildID { get { return guildID; } set { guildID = value; } }



        public uint this[uint index] { // Indexer for Player returns / sets gear at index.
            get { return gear[index]; }
            set { gear[index] = value; }
        }
    }
}