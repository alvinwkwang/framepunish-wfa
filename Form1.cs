using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FramePunishV2
{
    public partial class Form1 : Form
    {
        private static List<string> rosterNames = Character.fillRoster();
        private static List<Character> characters = Character.loadCharacters(rosterNames);
        private static string appVersion = "1.0";

        public Form1()
        {
            InitializeComponent();
            appInfoLabel.Text = "Version: " + appVersion;
            foreach (string name in rosterNames)
            {
                fdComboBox.Items.Add(name);
                mpUserComboBox.Items.Add(name);
                mpOpponentComboBox.Items.Add(name);
            }
            fdComboBox.SelectedIndex = 0;
            mpUserComboBox.SelectedIndex = 0;
            mpOpponentComboBox.SelectedIndex = 0;

            foreach (Move move in characters[mpOpponentComboBox.SelectedIndex].moves)
            {
                mpBlockedComboBox.Items.Add(move.moveName);
            }

            mpBlockedComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// display character frame data on mouseclick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fdButton_MouseClick(object sender, MouseEventArgs e)
        {
            mainTextBox.Clear();
            Character selected = characters[fdComboBox.SelectedIndex];
            List<string> frameData = Character.displayData(selected);

            foreach (string data in frameData)
            {
                mainTextBox.AppendText(data + "\n");
            }
        }

        /// <summary>
        /// update the opponent's move list when different opponent is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mpOpponentComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mpBlockedComboBox.Items.Clear();
            foreach (Move move in characters[mpOpponentComboBox.SelectedIndex].moves)
            {
                mpBlockedComboBox.Items.Add(move.moveName);
            }
            mpBlockedComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// display move punishes on mouseclick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mpButton_MouseClick(object sender, MouseEventArgs e)
        {
            mainTextBox.Clear();
            Character user = characters[mpUserComboBox.SelectedIndex];
            Character opponent = characters[mpOpponentComboBox.SelectedIndex];
            Move blocked = opponent.moves[mpBlockedComboBox.SelectedIndex];
            List<String> punishes = Character.calculatePunishList(blocked, user, opponent.name);

            foreach (string punish in punishes)
            {
                mainTextBox.AppendText(punish + "\n");
            }
        }

        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Link to github repo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gitHubRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/alvinwkwang/framepunish-wfa");
            Process.Start(sInfo);
        }

        /// <summary>
        /// Opens 'about' message box for application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutFramePunishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Frame Punish - Version " + appVersion + "\n\n" +
                "Features:\n" +
                "=========\n" +
                "* View frame data\n" +
                "* Calculate punishes on blocked moves\n\n" +
                "Created by Alvin Wang");
        }   
    }
}
