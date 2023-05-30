using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace FirstProject
{
    public partial class Dashboard : Form
    {
        private List<Tuple<double, double, double, double, double>> marksList = new List<Tuple<double, double, double, double, double>>();
        private int selectedRowIndex = -1; //for the selected row index to delete
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //DO NOT PUT ANYTHING HERE!!!
        }
        private void insertDataButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(midMarkTextBox.Text, out double midScore) && double.TryParse(lastMarkTextBox.Text, out double lastScore) && double.TryParse(creditsTextBox.Text, out double credits))
            {
                if (midScore >= 0 && midScore <= 10 && lastScore >= 0 && lastScore <= 10 && credits > 0 && credits < 7)
                {
                    double finalMark10 = (midScore * 0.4) + (lastScore * 0.6);
                    double roundFinalMark10 = Math.Round(finalMark10, 2);
                    //calculate the finalMark4 using switch case
                    double finalMark4 = 0;
                    switch (roundFinalMark10)
                    {
                        case double n when (n >= 9.15 && n <= 10):
                            finalMark4 = 4;
                            break;
                        case double n when (n >= 8.45 && n < 9.15):
                            finalMark4 = 3.7;
                            break;
                        case double n when (n >= 7.65 && n < 8.45):
                            finalMark4 = 3.5;
                            break;
                        case double n when (n >= 6.95 && n < 7.65):
                            finalMark4 = 3;
                            break;
                        case double n when (n >= 6.15 && n < 6.95):
                            finalMark4 = 2.5;
                            break;
                        case double n when (n >= 5.45 && n < 6.15):
                            finalMark4 = 2;
                            break;
                        case double n when (n >= 4.65 && n < 5.45):
                            finalMark4 = 1.5;
                            break;
                        case double n when (n >= 3.95 && n < 4.65):
                            finalMark4 = 1;
                            break;
                        case double n when (n >= 2.05 && n < 3.95):
                            finalMark4 = 0.5;
                            break;
                        case double n when (n < 2.05):
                            finalMark4 = 0;
                            break;
                        default:
                            break;
                    }

                    marksList.Add(new Tuple<double, double, double, double, double>(midScore, lastScore, credits, roundFinalMark10, finalMark4));
                    UpdateMarksListBox();
                    UpdateResultListBox();
                    summaryListBox.Items.Clear(); //clear the summary listbox
                    midMarkTextBox.Text = "";
                    lastMarkTextBox.Text = "";
                    creditsTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Có thể bạn đã nhập sai ở đâu đó rùi 😑" + "\n" + "Thử nhập lại nha!!!");
                }
            }
            else
            {
                MessageBox.Show("Bạn có biết nhập không đấy? 🤔");
            }
        }
        private void UpdateMarksListBox()
        {
            listMarkListBox.Items.Clear();
            int i = 1;
            foreach (var mark in marksList)
            {
                //print out the list of marks include the count of the list and the mid and last mark
                string item = $"#{i} ĐQT: {mark.Item1} Điểm CK: {mark.Item2} Số Tín: {mark.Item3} ";
                listMarkListBox.Items.Add(item);
                i++;
            }
        }
        private void UpdateResultListBox()
        {
            listResultListBox.Items.Clear();
            foreach (var mark in marksList)
            {
                int desiredWidth = 5;

                string formattedFinalMark10 = $"Hệ 10: {(mark.Item4 % 1 == 0 ? mark.Item4.ToString("F0") : mark.Item4.ToString("F2")).PadRight(desiredWidth)}";
                string formattedFinalMark4 = $"Hệ 4: {(mark.Item5 % 1 == 0 ? mark.Item5.ToString("F0") : mark.Item5.ToString("F1")).PadRight(desiredWidth)}";

                string result = $"{formattedFinalMark10}{formattedFinalMark4}";
                listResultListBox.Items.Add(result);
                /* old code
                 * string item = $"Hệ 10: {mark.Item4} Hệ 4: {mark.Item5}";
                 * listResultListBox.Items.Add(item);         
                 */
            }
        }
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            selectedRowIndex = listBox.SelectedIndex;

            if (listBox == listMarkListBox)
            {
                listResultListBox.SelectedIndex = selectedRowIndex;
            }
            else if (listBox == listResultListBox)
            {
                listMarkListBox.SelectedIndex = selectedRowIndex;
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Bruh WTF", "Bye bye 😘", MessageBoxButtons.OK);
            if (selectedRowIndex >= 0 && selectedRowIndex < marksList.Count)
            {
                marksList.RemoveAt(selectedRowIndex);
                listMarkListBox.Items.Clear(); //clear the listbox
                listResultListBox.Items.Clear(); //clear the listbox

                foreach (var mark in marksList)
                {
                    string item = $"Mid Mark: {mark.Item1}, Last Mark: {mark.Item2}, Sum: {mark.Item3}";
                    UpdateMarksListBox();
                    UpdateResultListBox();
                }
                selectedRowIndex = -1;
            }
        }
        /*
        private void button_Click(object sender, EventArgs e)
        {
            if (listMarkListBox.SelectedItem != null)
            {
                string selectedItem = listMarkListBox.SelectedItem.ToString();
                inputList.Remove(selectedItem);
                listMarkListBox.DataSource = null;
                listMarkListBox.DataSource = inputList;
            }
        }
        */
        private void MarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.') //validate textbox only take numeric value
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back) //set for the backspace key
            {
                TextBox textBox = (TextBox)sender; // Cast the sender object to TextBox
                if (textBox.Text.Length > 0)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length; // Set the caret position to the end
                }
                e.Handled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            listMarkListBox.Items.Clear();
            listMarkListBox.Items.Clear();
            listResultListBox.Items.Clear();
            summaryListBox.Items.Clear();
            marksList.Clear();  // Clear the list
        }


        private void ulsaitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.facebook.com/ULSA.IT/";

            // Open the URL in the default browser
            System.Diagnostics.Process.Start(url);
        }


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Warning 🙄", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
            {
                e.Cancel = true; // Cancel the form closing event
            }
            else
            {
                MessageBox.Show("Cảm ơn bạn đã sử dụng dịch vụ của ULSA IT", "Bye bye 😘", MessageBoxButtons.OK);
                // Clean up any resources or perform other actions before exiting
            }
            */
        }

        private void midMarkTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true; // Prevent the default Tab key behavior
                lastMarkTextBox.Focus(); // Move focus to textbox2
            }
            */
        }

        private void lastMarkTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true; // Prevent the default Tab key behavior
                creditsTextBox.Focus(); // Move focus to textbox3
            } */
        }

        private void creditsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            /* if (e.KeyCode == Keys.Tab)
             {
                 e.SuppressKeyPress = true; // Prevent the default Tab key behavior
                 insertDataButton.Focus(); // move focus to insert button
             } */
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            double totalCreditsMark10 = 0;
            double totalCreditsMark4 = 0;
            double sumOfFinalMark10 = 0;
            double sumOfFinalMark4 = 0;
            double totalCredits = 0;
            foreach (var mark in marksList)
            {
                totalCredits += mark.Item3;
                totalCreditsMark10 = mark.Item3 * mark.Item4;
                totalCreditsMark4 = mark.Item3 * mark.Item5;
                sumOfFinalMark10 += totalCreditsMark10;
                sumOfFinalMark4 += totalCreditsMark4;
            }

            double averageMark10 = Math.Round(sumOfFinalMark10 / totalCredits, 2);
            double averageMark4 = Math.Round(sumOfFinalMark4 / totalCredits, 2);
            string item = $"Tổng số tín chỉ: {totalCredits} ĐTB hệ 10: {averageMark10} ĐTB hệ 4: {averageMark4}";
            summaryListBox.Items.Add(item);
        }
    }
}


