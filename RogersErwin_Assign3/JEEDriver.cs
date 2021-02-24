using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersErwin_Assign3
{
    class JEEDriver
    {
        private ListBox outputListBox;
        private ComboBox ClassComboBox;
        private ComboBox ServerComboBox;
        private Button AllClassTypeQueryButton;
        private ComboBox PercentageOfRaceComboBox;
        private Button MaxLvlPlayersQueryButton;

        public JEEDriver(ref ListBox outputListBox, 
                         ref ComboBox ClassComboBox, 
                         ref ComboBox ServerComboBox, 
                         ref Button AllClassTypeQueryButton,
                         ref ComboBox PercentageOfRaceComboBox,
                         ref Button MaxLvlPlayersQueryButton)
        {
            this.outputListBox = outputListBox;
            this.ClassComboBox = ClassComboBox;
            this.ServerComboBox = ServerComboBox;
            this.AllClassTypeQueryButton = AllClassTypeQueryButton;
            this.PercentageOfRaceComboBox = PercentageOfRaceComboBox;
            this.MaxLvlPlayersQueryButton = MaxLvlPlayersQueryButton;
        }

        public void Initializer(ref ComboBox ClassComboBox, ref ComboBox ServerComboBox, ref ComboBox PercentageOfRaceComboBox)
        {
            UtilLib.AddToComboBox<string>(Enum.GetNames(typeof(Class)), ref ClassComboBox);
            UtilLib.AddToComboBox<string>(GuildCollection.GetServerNames().ToArray<string>(), ref ServerComboBox);
            UtilLib.AddToComboBox<string>(GuildCollection.GetServerNames().ToArray<string>(), ref PercentageOfRaceComboBox);
        }

        /**
         * Objective: 1
         * 
         * When AllClassTypeQueryButton_Click is triggered this function is called
         * Which queries the PlayerCollection and returns a collection of players whos class
         * matched the selected ClassComboBox and who exists on the selected server from ServerComboBox.
         */
        public void PlayersOfClassByServer(object sender)
        {
            if (ClassComboBox.SelectedIndex != -1 && ServerComboBox.SelectedIndex != -1)
            {
                // Header
                outputListBox.Items.Clear();
                outputListBox.Items.Add(string.Format("All {0} from {1}", ClassComboBox.SelectedItem, ServerComboBox.SelectedItem));
                outputListBox.Items.Add("--------------------------------------------");
                
                var playersByClassAndServer =
                    from player in PlayerCollection.Player_Collection
                    where (player.Value.PlayerClass == (Class)ClassComboBox.SelectedIndex)
                    where (GuildCollection.At(player.Value.GuildID).ServerName == ServerComboBox.SelectedItem.ToString())
                    orderby player.Value.Level
                    select player.Value;

                if (playersByClassAndServer.Count() == 0)
                {
                    outputListBox.Items.Add(string.Format("There are no {0} class players on {1}.", ClassComboBox.SelectedItem, ServerComboBox.SelectedItem));
                }
                else
                {
                    foreach (var player in playersByClassAndServer)
                    {
                        outputListBox.Items.Add(player);
                    }
                }

                // Footer
                outputListBox.Items.Add("");
                outputListBox.Items.Add("END RESULTS");
                outputListBox.Items.Add("--------------------------------------------");
            }
            else
            {
                outputListBox.Items.Clear();
                if (ClassComboBox.SelectedIndex == -1) outputListBox.Items.Add("Please select a Class Type to complete this query.");
                if (ServerComboBox.SelectedIndex == -1) outputListBox.Items.Add("Please select a Server to complete this query.");
            }
        }

        /**
         * Objective: 2
         * 
         * when the PercentageOfRaceComboBox_SelectedIndexChanged event is triggered this function is called
         * which queries the PlayerCollection and groups players by their race for the server name that is selected
         * and displays, in the outputListBox, the percentage of players race on the selected server.
         */
        public void PercentageRaceFromServer(object sender)
        {
            ComboBox cb = sender as ComboBox;
            if (cb == null) return;
            if (cb.SelectedIndex == -1) return;

            string serverName = cb.SelectedItem.ToString();

            // Header
            outputListBox.Items.Clear();
            outputListBox.Items.Add(string.Format("Percentage of Each Race from {0}", serverName));
            outputListBox.Items.Add("--------------------------------------------");

            if (serverName != "")
            {
                uint[] playersPerRace = new uint[Enum.GetNames(typeof(Race)).Length];
                uint players = 0;

                // Main query
                var PctRaceFromServer =
                    from KeyValuePair<uint, Player> player in PlayerCollection.Player_Collection
                    where (GuildCollection.At(player.Value.GuildID).ServerName == serverName)
                    group player.Value by player.Value.PlayerRace;

                foreach (var group in PctRaceFromServer)
                {
                    players += (uint)group.Count<Player>();
                    Race tempRace = group.First<Player>().PlayerRace;
                    playersPerRace[(uint)tempRace] = (uint)group.Count<Player>();
                }

                foreach (var i in Enumerable.Range(0, playersPerRace.Length))
                {
                    double percent = (((double)playersPerRace[i] / (double)players) * 100);
                    outputListBox.Items.Add(string.Format("{0,10}: {1: 0.00}%", (Race)i, percent));
                }
            }
            else
            {
                outputListBox.Items.Add("Results could not be displayed at this time ...");
            }
            // Footer
            outputListBox.Items.Add("END RESULTS");
            outputListBox.Items.Add("--------------------------------------------");
        }

        /**
         * Objective: 6
         * 
         * When the MaxLvlPlayersQueryButton_Click is triggered this function is called
         * which queries the PlayerCollection and groups players levels by their guild
         * and displays, in the outputListBox, the percentage of players who's level is maxed out per guild.
         */
        public void PercentageMaxPlayerQuery()
        {
            var MaxLvlPlayerFromAllGuilds = // groups of guilds and player levels in each guild ... that's it
                from KeyValuePair<uint, Player> player in PlayerCollection.Player_Collection
                group player.Value.Level by GuildCollection.At(player.Value.GuildID);

            // Header
            outputListBox.Items.Clear();
            outputListBox.Items.Add("Percentage of Max Level Players in All Guilds");
            outputListBox.Items.Add("--------------------------------------------");

            foreach (var guilds in MaxLvlPlayerFromAllGuilds) // loop through all the guilds
            {
                uint maxLvl = 0; // this will equal the number of max level players in a given guild after the inner foreach
                uint playersPerGuild = 0; // after the inner foreach, this will equal the number of players in a given guild

                foreach (var playerLvl in guilds) // loop through all the player levels in a guild
                {
                    if (playerLvl == Globals.Max_Level) // check 
                    {
                        maxLvl++;
                    }
                    playersPerGuild++;
                }
                double percentMaxPlayers = Math.Round((double)maxLvl / (double)playersPerGuild * 100.00,2); // percentage of max lvl players in a guild
                string formattedGuildName = "<" + guilds.Key.Name.ToString() + ">"; // this is how Rogness wanted each guiild name formatted

                /**
                 * NOTE: some of the Guilds ended up with zero Player members, which can make your division produce a NaN (not a number)
                 * result when dividing by zero. Omit those records altogether.
                 */
                if (!Double.IsNaN(percentMaxPlayers))
                {
                    outputListBox.Items.Add(string.Format("{0,-30} {1,7}%", formattedGuildName, percentMaxPlayers.ToString()));
                    outputListBox.Items.Add("");
                }
            }

            // Footer
            outputListBox.Items.Add("END RESULTS");
            outputListBox.Items.Add("--------------------------------------------");
        }
    }
}
