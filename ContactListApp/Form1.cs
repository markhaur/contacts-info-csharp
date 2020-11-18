using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactListApp
{
    public partial class mainForm : Form
    {
        private int LIST_BOX_SELECTION;
        private int ACTIVE_ENTRIES;
        private int DELETE_LIST_INDEX;

        public mainForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.btnClear.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = false;
            disableSearchGroupBox();

            this.lstFirtName.AllowDrop = true;
            this.lstLastName.AllowDrop = true;
            this.lstPhoneNumber.AllowDrop = true;
            this.picDelete.AllowDrop = true;

            ACTIVE_ENTRIES = 0;
            LIST_BOX_SELECTION = -1;
            DELETE_LIST_INDEX = -1;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.lstPhoneNumber.Items.Clear();
                this.lstFirtName.Items.Clear();
                this.lstLastName.Items.Clear();
                String fileLocation = openFileDialog.FileName;
                String[] lines = File.ReadAllLines(fileLocation);
                for (int i = 0; i < lines.Length; i += 3)
                {
                    if (lines[i].Equals("00000000000"))
                    {
                        break;
                    }
                    this.lstPhoneNumber.Items.Add(lines[i]);
                    this.lstFirtName.Items.Add(lines[i+1]);
                    this.lstLastName.Items.Add(lines[i+2]);
                    ACTIVE_ENTRIES += 1;
                }
                this.btnClear.Enabled = true;
                this.btnDelete.Enabled = true;
                enableSearchGroupBox();
                this.lblActiveEntries.Text = "Active Entries : " + ACTIVE_ENTRIES;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Contacts";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fileLocation = saveFileDialog.FileName;
                int size = this.lstPhoneNumber.Items.Count;
                using (StreamWriter writer = new StreamWriter(fileLocation))
                {
                    for (int index = 0; index < size; index++)
                    {
                        writer.WriteLine(this.lstPhoneNumber.Items[index].ToString());
                        writer.WriteLine(this.lstFirtName.Items[index].ToString());
                        writer.WriteLine(this.lstLastName.Items[index].ToString());
                    }
                    writer.WriteLine("00000000000");
                }
                MessageBox.Show("Saved to file successfully", "Save to file");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lstPhoneNumber.Items.Clear();
            this.lstFirtName.Items.Clear();
            this.lstLastName.Items.Clear();
            this.btnClear.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = false;
            disableSearchGroupBox();
            ACTIVE_ENTRIES = 0;
            this.lblActiveEntries.Text = "Active Entries : " + ACTIVE_ENTRIES;
            enableInsertFeature();
        }

        private void lstPhoneNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            LIST_BOX_SELECTION = 0;
        }

        private void lstFirtName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LIST_BOX_SELECTION = 1;
        }

        private void lstLastName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LIST_BOX_SELECTION = 2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = -1;
            switch (LIST_BOX_SELECTION)
            {
                case 0:
                    selectedIndex = this.lstPhoneNumber.SelectedIndex;
                    break;
                case 1:
                    selectedIndex = this.lstFirtName.SelectedIndex;
                    break;
                case 2:
                    selectedIndex = this.lstLastName.SelectedIndex;
                    break;
                default:
                    MessageBox.Show("Please select an item from any of list", "Operation Failed");
                    return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Deletion Confirmation",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                enableInsertFeature();
                this.lstPhoneNumber.Items.RemoveAt(selectedIndex);
                this.lstFirtName.Items.RemoveAt(selectedIndex);
                this.lstLastName.Items.RemoveAt(selectedIndex);
                LIST_BOX_SELECTION = -1;
                ACTIVE_ENTRIES -= 1;
                this.lblActiveEntries.Text = "Active Entries : " + ACTIVE_ENTRIES;
                this.btnSave.Enabled = true;
                if (this.lstPhoneNumber.Items.Count == 0)
                {
                    this.btnClear.Enabled = false;
                    this.btnDelete.Enabled = false;
                    this.btnSave.Enabled = false;
                    disableSearchGroupBox();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string phoneNumber = this.txtPhoneNumber.Text;
            string firstName = this.txtFirstName.Text;
            string lastName = this.txtLastName.Text;

            if (phoneNumber.Length == 0 || firstName.Length == 0 || lastName.Length == 0)
            {
                MessageBox.Show("Required fields are empty", "Error");
                return;
            }

            if (searchPhoneNumber(phoneNumber) != -1)
            {
                MessageBox.Show("Phone Number already exists", "Operation Failed");
                return;
            }

            int index;
            for (index = 0; index < this.lstPhoneNumber.Items.Count; index++)
            {
                if (phoneNumber.CompareTo(this.lstPhoneNumber.Items[index].ToString()) > 0)
                    continue;
                break;
            }
            this.lstPhoneNumber.Items.Insert(index, phoneNumber);
            this.lstFirtName.Items.Insert(index, firstName);
            this.lstLastName.Items.Insert(index, lastName);
            ACTIVE_ENTRIES += 1;
            this.lblActiveEntries.Text = "Active Entries : " + ACTIVE_ENTRIES;
            this.btnClear.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnSave.Enabled = true;
            enableSearchGroupBox();
        }

        private void enableSearchGroupBox()
        {
            this.btnSearch.Enabled = true;
            this.txtSearch.Enabled = true;
            this.radPhoneNumber.Enabled = true;
            this.radFirstName.Enabled = true;
            this.radLastName.Enabled = true;
        }

        private void disableSearchGroupBox()
        {
            this.btnSearch.Enabled = false;
            this.txtSearch.Enabled = false;
            this.radPhoneNumber.Enabled = false;
            this.radFirstName.Enabled = false;
            this.radLastName.Enabled = false;
        }

        private void disableInsertFeature()
        {
            this.txtFirstName.Enabled = false;
            this.txtLastName.Enabled = false;
            this.txtPhoneNumber.Enabled = false;
            this.btnAdd.Enabled = false;
        }

        private void enableInsertFeature()
        {
            this.txtFirstName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.txtPhoneNumber.Enabled = true;
            this.btnAdd.Enabled = true;
        }

        private int searchPhoneNumber(String phoneNumber)
        {
            if (this.lstPhoneNumber.Items.Count == 0)
                return -1;

            int minNum = 0;
            int maxNum = this.lstPhoneNumber.Items.Count - 1;
            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (phoneNumber.Equals(this.lstPhoneNumber.Items[mid].ToString()))
                    return mid;
                else if (phoneNumber.CompareTo(this.lstPhoneNumber.Items[mid].ToString()) < 0)
                    maxNum = mid - 1;
                else
                    minNum = mid + 1;
            }
            return -1;
        }

        private int searchName(ListBox listBox, String key)
        {
            if (listBox.Items.Count == 0)
                return -1;

            for(int index = 0; index < listBox.Items.Count; index++)
            {
                if (key.CompareTo(listBox.Items[index].ToString()) == 0)
                {
                    return index;
                }
            }
            return -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String textKey = this.txtSearch.Text;
            if (textKey.Length == 0)
            {
                MessageBox.Show("Please type search key", "Warning");
                return;
            }
            int searchIndex = 0;
            if (radPhoneNumber.Checked)
            {
                this.Text = "searching in phone";
                searchIndex = searchPhoneNumber(textKey);
            }
            else if (radFirstName.Checked)
            {
                this.Text = "searching in first";
                searchIndex = searchName(this.lstFirtName, textKey);
            }
            else if (radLastName.Checked)
            {
                this.Text = "searching in last";
                searchIndex = searchName(this.lstLastName, textKey);
            }
            else
            {
                MessageBox.Show("Specify the list to search through", "Error");
                return;
            }
            if (searchIndex == -1)
                MessageBox.Show("The searched item is not found", "Result");
            else
                MessageBox.Show("The position of search key is " + (searchIndex + 1), "Result");

        }

        private void picDelete_DragDrop(object sender, DragEventArgs e)
        {
            this.lstPhoneNumber.Items.RemoveAt(DELETE_LIST_INDEX);
            this.lstFirtName.Items.RemoveAt(DELETE_LIST_INDEX);
            this.lstLastName.Items.RemoveAt(DELETE_LIST_INDEX);
            ACTIVE_ENTRIES -= 1;
            this.lblActiveEntries.Text = "Active Entries: " + ACTIVE_ENTRIES;

            if (this.lstPhoneNumber.Items.Count == 0)
            {
                this.btnSave.Enabled = false;
                this.btnClear.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnSearch.Enabled = false;
                this.txtSearch.Enabled = false;
                this.radFirstName.Enabled = false;
                this.radLastName.Enabled = false;
                this.radPhoneNumber.Enabled = false;
            }
        }

        private void lstPhoneNumber_MouseDown(object sender, MouseEventArgs e)
        {
            DELETE_LIST_INDEX = this.lstPhoneNumber.SelectedIndex;
            this.picDelete.DoDragDrop(this.lstPhoneNumber.SelectedItem.ToString(), DragDropEffects.All);
        }

        private void lstFirtName_MouseDown(object sender, MouseEventArgs e)
        {
            DELETE_LIST_INDEX = this.lstFirtName.SelectedIndex;
            this.picDelete.DoDragDrop(this.lstFirtName.SelectedItem.ToString(), DragDropEffects.All);
        }

        private void lstLastName_MouseDown(object sender, MouseEventArgs e)
        {
            DELETE_LIST_INDEX = this.lstLastName.SelectedIndex;
            this.picDelete.DoDragDrop(this.lstLastName.SelectedItem.ToString(), DragDropEffects.All);
        }

        private void picDelete_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
