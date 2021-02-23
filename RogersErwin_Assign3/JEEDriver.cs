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

        public void PercentageMaxPlayerQuery()
        {

        }
    }
}
