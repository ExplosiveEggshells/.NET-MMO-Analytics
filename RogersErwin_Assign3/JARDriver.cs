﻿/*
 * NAME: JARDriver.cs
 * AUTHORS: Jake Rogers (z1826513)
 * 
 * This file is used to separate out the functionality
 * that I am responsible for into it's own file. This is done to
 * avoid causing merge-conflicts that would otherwise occur when
 * trying to shove all of these methods into Form1.cs.
 * 
 * When instantiated, it is hooked to an outputListBox which will
 * be used to display output from the various requirements denoted within
 * the assignment handout. Ideally, the publically available methods in this
 * class will be called by events handled in Form1.cs.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersErwin_Assign3
{
    class JARDriver
    {
        private ListBox outputListBox;

        public JARDriver(ref ListBox listBox)
        {
            outputListBox = listBox;
        }

        public void Initializer(ref ComboBox guildsPerTypeComboBox)
        {

            GuildType[] guildTypes = new GuildType[5] { GuildType.Casual, GuildType.MythicPlus, GuildType.PVP, GuildType.Questing, GuildType.Raiding };
            UtilLib.AddToComboBox<GuildType>(guildTypes, ref guildsPerTypeComboBox);
        }

        public void ShowGuildsPerType(object sender)
        {
            outputListBox.Items.Clear();

            ComboBox cb = sender as ComboBox;
            if (cb == null) return;

            GuildType guildType = (GuildType) cb.SelectedIndex;

            var GuildsPerType =
                from KeyValuePair<uint, Guild> guild in GuildCollection.Guild_Collection
                where (guild.Value.Type == guildType)
                select guild.Value;



            foreach (Guild guild in GuildsPerType)
            {
                outputListBox.Items.Add(guild.ToString());
            }
        }
    }
}