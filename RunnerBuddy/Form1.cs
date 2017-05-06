using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;
using IniParser.Model.Configuration;

namespace RunnerBuddy
{
    public partial class RBMainform : Form
    {
        private SortedDictionary<string, string> IPAddresses = new SortedDictionary<string, string>();
        private int selectedIndex = -1;
        private IniData rbINIData;
        private FileIniDataParser rbINIParser = new FileIniDataParser();
        private string rbINIFileName = "RunnerBuddy.ini";
        private IniData artemisINIData;
        private FileIniDataParser artemisINIParser = new FileIniDataParser();
        private IniParserConfiguration parserConfig = new IniParserConfiguration()
        {
            AssigmentSpacer = string.Empty
        };

        public RBMainform()
        {
            InitializeComponent();
            rbINIData = rbINIParser.ReadFile(rbINIFileName);
            rbINIData.Configuration.AssigmentSpacer = string.Empty;
            foreach (KeyData key in rbINIData.Sections["Servers"])
            {
                IPAddresses.Add(key.KeyName, key.Value);
            }
            ShowAddresses();
            lblINIFileLocation.Text = rbINIData["GeneralConfiguration"]["defaultArtemisLocation"];
            try
            {
                artemisINIData = artemisINIParser.ReadFile(lblINIFileLocation.Text);
                artemisINIData.Configuration.AssigmentSpacer = string.Empty;
                UpdateScreenData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateScreenData()
        {
            lblCurrentAddress.Text = "Current: " + artemisINIData.Global["forceAddress"];
            cbJoystick.Checked = artemisINIData.Global["useJoystick"] == "1";
            cbTouchScreen.Checked = artemisINIData.Global["touchScreen"] == "1";
            cbShowVisTab.Checked = artemisINIData.Global["showVisTab"] == "1";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                rbINIData["GeneralConfiguration"]["defaultArtemisLocation"] = openFileDialog1.FileName;
                lblINIFileLocation.Text = rbINIData["GeneralConfiguration"]["defaultArtemisLocation"];
                SaveRBData();
                artemisINIData = artemisINIParser.ReadFile(lblINIFileLocation.Text);
                UpdateScreenData();
            }
        }

        private void btnAddIPAddress_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIPAddress.Text))
            {
                MessageBox.Show("Please enter an IP address");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbIPAlias.Text))
            {
                MessageBox.Show("Please enter an alias");
                return;
            }

            IPAddresses.Add(tbIPAlias.Text, tbIPAddress.Text);
            rbINIData["Servers"].AddKey(tbIPAlias.Text, tbIPAddress.Text);
            ShowAddresses();
            SaveRBData();
            tbIPAddress.Clear();
            tbIPAlias.Clear();
        }

        private void ShowAddresses()
        {
            listBox1.Items.Clear();
            foreach (var item in IPAddresses)
            {
                listBox1.Items.Add(string.Format("{0}: {1}", item.Key, item.Value));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NoSelection())
            {
                MessageBox.Show("Please select an IP Address");
                return;
            }

            SaveArtemisData();
            lblCurrentAddress.Text = "Current: " + artemisINIData.Global["forceAddress"];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listBox1.SelectedIndex;
        }

        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            if (NoSelection())
            {
                MessageBox.Show("Please select an IP Address");
                return;
            }

            rbINIData["Servers"].RemoveKey(IPAddresses.ElementAt(selectedIndex).Key);
            IPAddresses.Remove(IPAddresses.ElementAt(selectedIndex).Key);
            ShowAddresses();
            SaveRBData();
            selectedIndex = -1;
        }

        private void SaveRBData()
        {
            rbINIParser.WriteFile(rbINIFileName, rbINIData);
        }

        private bool NoSelection()
        {
            return selectedIndex < 0;
        }

        private void SaveArtemisData()
        {
            artemisINIData.Global["forceAddress"] = IPAddresses.ElementAt(selectedIndex).Value;
            artemisINIData.Global["useJoystick"] = cbJoystick.Checked ? "1" : "0";
            artemisINIData.Global["touchScreen"] = cbTouchScreen.Checked ? "1" : "0";
            artemisINIData.Global["showVisTab"] = cbShowVisTab.Checked ? "1" : "0";
            artemisINIParser.WriteFile(lblINIFileLocation.Text, artemisINIData);
        }
    }
}
