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

        //PRSL: Players by Roles in Server within Level.
        private ComboBox PRSLRoleComboBox;
        private ComboBox PRSLServerComboBox;
        private NumericUpDown PRSLMinUpDown;
        private NumericUpDown PRSLMaxUpDown;

        public JARDriver(ref ListBox listBox)
        {
            outputListBox = listBox;
        }

        public JARDriver(ref ListBox outputListBox, ref ComboBox PRSLRoleComboBox, ref ComboBox PRSLServerCombox, ref NumericUpDown PRSLMinUpDown, ref NumericUpDown PRSLMaxUpDown)
        {
            this.outputListBox = outputListBox;
            this.PRSLRoleComboBox = PRSLRoleComboBox;
            this.PRSLServerComboBox = PRSLServerCombox;
            this.PRSLMinUpDown = PRSLMinUpDown;
            this.PRSLMaxUpDown = PRSLMaxUpDown;
        }

        public void Initializer(ref ComboBox guildsPerTypeComboBox)
        {

            GuildType[] guildTypes = new GuildType[5] { GuildType.Casual, GuildType.MythicPlus, GuildType.PVP, GuildType.Questing, GuildType.Raiding };
            UtilLib.AddToComboBox<GuildType>(guildTypes, ref guildsPerTypeComboBox);
            
            Role[] roles = new Role[3] { Role.Tank, Role.Healer, Role.Damage };
            UtilLib.AddToComboBox<Role>(roles, ref PRSLRoleComboBox);
            UtilLib.AddToComboBox<string>(GuildCollection.GetServerNames().ToArray<string>(), ref PRSLServerComboBox);
            PRSLMinUpDown.Maximum = Globals.Max_Level;
            PRSLMaxUpDown.Maximum = Globals.Max_Level;
        }

        public void ShowGuildsPerType(object sender)
        {
            outputListBox.Items.Clear();

            ComboBox cb = sender as ComboBox;
            if (cb == null) return;

            GuildType guildType = (GuildType)cb.SelectedIndex;

            var GuildsPerType =
                from KeyValuePair<uint, Guild> guild in GuildCollection.Guild_Collection
                where (guild.Value.Type == guildType)
                select guild.Value;



            foreach (Guild guild in GuildsPerType)
            {
                outputListBox.Items.Add(guild.ToString());
            }
        }

        public void ShowUnfulfilledRoles(object sender)
        {
            outputListBox.Items.Clear();

            RadioButton rb = sender as RadioButton;
            if (rb == null) return;

            string nameSuffix = rb.Name.Substring(rb.Name.Length-1);
            Role selectedRole = (Role) int.Parse(nameSuffix);

            var RoleUnfulfilled =
                from KeyValuePair<uint, Player> player in PlayerCollection.Player_Collection
                where (Globals.GetRolesByClass(player.Value.PlayerClass).Contains(selectedRole))
                where (player.Value.PlayerRole != selectedRole)
                select player.Value;

            //outputListBox.Items.Add(RoleUnfulfilled.Count());

            foreach (Player player in RoleUnfulfilled)
            {
                outputListBox.Items.Add(player.ToString());
            }
        }

        public void PlayersByRoleServerLevel()
        {
            if (PRSLRoleComboBox.SelectedIndex == -1 || PRSLServerComboBox.SelectedIndex == -1) return;

            outputListBox.Items.Clear();

            Role selectedRole = (Role) PRSLRoleComboBox.SelectedIndex;
            string server = (string) PRSLServerComboBox.SelectedItem;
            uint minLevel = (uint) PRSLMinUpDown.Value;
            uint maxLevel = (uint) PRSLMaxUpDown.Value;

            var PRSLList =
                from KeyValuePair<uint, Player> player in PlayerCollection.Player_Collection
                where (player.Value.PlayerRole == selectedRole)
                where (GuildCollection.At(player.Value.GuildID).ServerName == server)
                where (player.Value.Level >= minLevel && player.Value.Level <= maxLevel)
                select player.Value;

            foreach (Player player in PRSLList)
            {
                outputListBox.Items.Add(player.ToString());
            }
        }

        public void ConstrainUpDowns(object sender)
        {
            NumericUpDown upDown = sender as NumericUpDown;
            if (upDown == null) return;

            if (upDown.Equals(PRSLMinUpDown) && PRSLMaxUpDown.Value < PRSLMinUpDown.Value)
            {
                PRSLMaxUpDown.Value = PRSLMinUpDown.Value;
            }
            else if (upDown.Equals(PRSLMaxUpDown) && PRSLMinUpDown.Value > PRSLMaxUpDown.Value)
            {
                PRSLMinUpDown.Value = PRSLMaxUpDown.Value;
            }

        }
    }
}
