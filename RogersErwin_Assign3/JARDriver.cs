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
        private ListBox outputListBox;                      // Listbox used to output rows into

        /*PRSL: Players by Roles in Server within Level. The following are 
         components linked to that query*/
        private ComboBox PRSLRoleComboBox;
        private ComboBox PRSLServerComboBox;
        private NumericUpDown PRSLMinUpDown;
        private NumericUpDown PRSLMaxUpDown;

        /*
         * Constructor for testing
         */
        public JARDriver(ref ListBox listBox)
        {
            outputListBox = listBox;
        }

        /*
         * Full-on constructor, it would probably be best to use this one.
         */
        public JARDriver(ref ListBox outputListBox, ref ComboBox PRSLRoleComboBox, ref ComboBox PRSLServerCombox, ref NumericUpDown PRSLMinUpDown, ref NumericUpDown PRSLMaxUpDown)
        {
            this.outputListBox = outputListBox;
            this.PRSLRoleComboBox = PRSLRoleComboBox;
            this.PRSLServerComboBox = PRSLServerCombox;
            this.PRSLMinUpDown = PRSLMinUpDown;
            this.PRSLMaxUpDown = PRSLMaxUpDown;
        }

        /*
         * When ran, this method will fill-in various properties of
         * multiple different components, such as setting maximum
         * values on up/downs and filling ComboBoxes with valid
         * entries.
         */
        public void Initializer(ref ComboBox guildsPerTypeComboBox)
        {
            // Add GuildTypes to respective ComboBox
            GuildType[] guildTypes = new GuildType[5] { GuildType.Casual, GuildType.MythicPlus, GuildType.PVP, GuildType.Questing, GuildType.Raiding };
            UtilLib.AddToComboBox<GuildType>(guildTypes, ref guildsPerTypeComboBox);

            
            Role[] roles = new Role[3] { Role.Tank, Role.Healer, Role.Damage };
            UtilLib.AddToComboBox<Role>(roles, ref PRSLRoleComboBox);                                                   // Add roles to PRSL Roles combobox
            UtilLib.AddToComboBox<string>(GuildCollection.GetServerNames().ToArray<string>(), ref PRSLServerComboBox);  // Add server names to PRSL Server combobox
            PRSLMinUpDown.Maximum = Globals.Max_Level;                                                                  // Set maximum values for up/downs
            PRSLMaxUpDown.Maximum = Globals.Max_Level;
        }

        /*
         * Runs a query to retrieve and display all Guilds that fall under
         * a specific type, given by a combo-box's text at its selected
         * index.
         */
        public void ShowGuildsPerType(object sender)
        {
            outputListBox.Items.Clear();

            ComboBox cb = sender as ComboBox;                                               // Cast sender down to a ComboBox
            if (cb == null) return;                                                         // Return on cast failure.

            GuildType guildType = (GuildType)cb.SelectedIndex;                              // Get SelectedRole from cb
                                        
            outputListBox.Items.Add("Show All " + guildType + " Guilds");                   // Print header
            outputListBox.Items.Add("--------------------------------------------");

            var GuildsPerType =                                                             // Query
                from KeyValuePair<uint, Guild> guild in GuildCollection.Guild_Collection    // From every keyvalue pair in the guild collection...
                where (guild.Value.Type == guildType)                                       // ...where the guild's type is the same as selected type...
                select guild.Value;                                                         // Extract the matching Guilds.


            foreach (Guild guild in GuildsPerType)                                          // Display all matching entries
            {
                outputListBox.Items.Add(guild.ToString());
            }


            outputListBox.Items.Add("");
            if (GuildsPerType.Count() == 0)                                                 // Print "No Results" or "END" if no results or some results were found respectively.
            {
                outputListBox.Items.Add("No Results");
            }
            else
            {
                outputListBox.Items.Add("END");
            }

            outputListBox.Items.Add("--------------------------------------------");        // Footer
        }

        /*
         * Runs a query to retrieve and display all Players who's class could
         * fulfill a selected role, but the player themselves are under a
         * different role.
         * 
         * The selected role enum is parsed by taking the last character in
         * the name of the RadioButton that triggered this Query. For instance,
         * the RadioButton for 'Healer' should be named 'RadioButton1' as a example.
         */
        public void ShowUnfulfilledRoles(object sender)
        {
            outputListBox.Items.Clear();

            RadioButton rb = sender as RadioButton;                                                 // Cast the sender down to a RadioButton
            if (rb == null) return;                                                                 // Return out on cast failure

            string nameSuffix = rb.Name.Substring(rb.Name.Length - 1);                              // Get the last char from the sender's name...
            Role selectedRole = (Role)int.Parse(nameSuffix);                                        // ... and cast that (Hopefully number) to a role Enum

            outputListBox.Items.Add("All Players not fulfilling " + selectedRole + " but could");   // Print header
            outputListBox.Items.Add("--------------------------------------------");

            var RoleUnfulfilled =                                                                   // QUERY
                from KeyValuePair<uint, Player> player in PlayerCollection.Player_Collection        // From every KeyValuePair of players in the PlayerCollection...
                where (Globals.GetRolesByClass(player.Value.PlayerClass).Contains(selectedRole))    // ...where the Player's class could fulfill the selected role...
                where (player.Value.PlayerRole != selectedRole)                                     // ...however, the player themself does not fulfill that role...
                select player.Value;                                                                // ...select matching entries.


            foreach (Player player in RoleUnfulfilled)                                              // Print all entries
            {
                outputListBox.Items.Add(player.ToString());
            }

            outputListBox.Items.Add("");
            if (RoleUnfulfilled.Count() == 0)                                                       // Print "No Results" or "END" if there were no results or some respectively.
            {
                outputListBox.Items.Add("No Results");
            }
            else
            {
                outputListBox.Items.Add("END");
            }

            outputListBox.Items.Add("--------------------------------------------");                // Footer
        }


        /*
         * Runs a query that retrieves and displays all Players who fulfill
         * a selected role, belong to a guild on a selected server, and
         * have a level within a selected range.
         */
        public void PlayersByRoleServerLevel()
        {
            outputListBox.Items.Clear();

            if (PRSLRoleComboBox.SelectedIndex == -1 || PRSLServerComboBox.SelectedIndex == -1)     // If either of the comboboxes have no selectedIndex, do not do the query yet.
            {
                outputListBox.Items.Add("Please finish all selection to complete this query.");
                return;
            }

            // Extract data from components
            Role selectedRole = (Role)PRSLRoleComboBox.SelectedIndex;
            string server = (string)PRSLServerComboBox.SelectedItem;
            uint minLevel = (uint)PRSLMinUpDown.Value;
            uint maxLevel = (uint)PRSLMaxUpDown.Value;

            // Header
            outputListBox.Items.Add(String.Format("All {0}s on {1} (Level {2} - {3})", selectedRole, server, minLevel, maxLevel));
            outputListBox.Items.Add("--------------------------------------------");

            var PRSLList =                                                                      // QUERY
                from KeyValuePair<uint, Player> player in PlayerCollection.Player_Collection    // From all KeyValuePairs of players in PlayerCollection...
                where (player.Value.PlayerRole == selectedRole)                                 // ...where the player's role matches the selected role...
                where (GuildCollection.At(player.Value.GuildID).ServerName == server)           // ...and the player's serverName matches the selected server...
                where (player.Value.Level >= minLevel && player.Value.Level <= maxLevel)        // ...and the player's level is within the min and max (inclusive)...
                select player.Value;                                                            // ... select all matching players.

            // Print all entries in the query
            foreach (Player player in PRSLList)
            {
                outputListBox.Items.Add(player.ToString());
            }

            outputListBox.Items.Add("");
            if (PRSLList.Count() == 0)                                                          // Prints either "No Results" or "END" if there were no or some results respectively.
            {
                outputListBox.Items.Add("No Results");
            }
            else
            {
                outputListBox.Items.Add("END");
            }

            outputListBox.Items.Add("--------------------------------------------");            // Footer.
        }

        /*
         * Constains the PRSL NumericUpDrowns to disallow invalid
         * selections.
         * 
         * If the min-value suddenly exceeds the max-value, max will
         * be increased to the min-value, as well as vice-versa.
         */
        public void ConstrainUpDowns(object sender)
        {
            NumericUpDown upDown = sender as NumericUpDown;                                         // Cast sender to NumericUpDown
            if (upDown == null) return;                                                             // Return on cast failure

            if (upDown.Equals(PRSLMinUpDown) && PRSLMaxUpDown.Value < PRSLMinUpDown.Value)          // If the sender is the MinUpDown and the Min has exceeded the Max...
            {
                PRSLMaxUpDown.Value = PRSLMinUpDown.Value;                                              // Correct the max
            }
            else if (upDown.Equals(PRSLMaxUpDown) && PRSLMinUpDown.Value > PRSLMaxUpDown.Value)     // Exactly the same as above, but vice-versa.
            {
                PRSLMinUpDown.Value = PRSLMaxUpDown.Value;
            }

        }
    }
}
