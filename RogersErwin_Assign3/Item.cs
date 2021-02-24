/*
 * NAME: Item.cs
 * AUTHORS: Jake Rogers (z1826513), John Erwin (z1856469)
 * 
 * This class represents equippable items for players.
 * 
 * These match the format of the entries within equipment.txt
 */

using System;

namespace RogersErwin_Assign3
{
    public class Item : IComparable
    {
        private readonly uint id;
        private string name;
        private ItemType type;
        private uint ilvl;
        private uint primary;
        private uint stamina;
        private uint requirement;
        private string flavor;
        public Item() //Default constructor
        {
            id = 0;
            name = "";
            type = 0;
            ilvl = 0;
            primary = 0;
            stamina = 0;
            requirement = 0;
            flavor = "";
        }
        public Item(uint id, string name, ItemType type, uint ilvl, uint primary, uint stamina, uint requirement, string flavor)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.ilvl = ilvl;
            this.primary = primary;
            this.stamina = stamina;
            this.requirement = requirement;
            this.flavor = flavor;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException();
            Item rightOp = obj as Item;
            if(rightOp != null)
            {
                return Name.CompareTo(rightOp.Name);
            }
            else
            {
                throw new ArgumentException("Item CompareTo argument is not an Item");
            }
        }
        public override string ToString()
        {
            if (Id == 0) return ""; // Return an empty string if this id is 0 (Id = 0 indicates the non-existance of an item).

            return string.Format("({0}) {1} |{2}| --{3}--\n\t\"{4}\" ",Type,Name,Ilvl,Requirement,Flavor);
        }
        public uint Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public ItemType Type
        {
            get { return type; }
            set { type = value; }
        }
        public uint Ilvl
        {
            get { return ilvl; }
            set
            {
                if( value > 0 || value < Globals.Max_ItemLevel )
                {
                    ilvl = value;
                }
                // else, print to console what went wrong and why
            }
        }
        public uint Primary
        {
            get { return primary; }
            set
            {
                if( value > 0 || value < Globals.Max_Primary )
                {
                    primary = value;
                }

            }
            // else, print to console what went wrong and why
        }
        public uint Stamina
        {
            get { return stamina; }
            set
            {
                if( value > 0 || value < Globals.Max_Stamina )
                {
                    stamina = value;
                }
            }
        }
        public uint Requirement
        {
            get { return requirement; }
            set
            {
                if (value > 0 || value < Globals.Max_Level)
                {
                    requirement = value;
                }
            }
        }
        public string Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
    }
}