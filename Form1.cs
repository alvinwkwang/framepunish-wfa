using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Form1()
        {
            InitializeComponent();
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
        /// Application info shown in message box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Created by Alvin Wang 2015");
        }       
    }
}
