/*
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

        public void PrintAllPlayers()
        {
            foreach (KeyValuePair<uint,Guild> guild in GuildCollection.Guild_Collection)
            {
                outputListBox.Items.Add(guild.Value);
            }
        }
    }
}
