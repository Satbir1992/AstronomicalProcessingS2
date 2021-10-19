using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
// Atit Singh/Satbir Singh,Team:CSharpPerth, Sprint 2
// Date: 21/09/2021
// Version:2
// AstronomicalProcessing
// This is a form-based application which displays the hours in a listbox, user can able to add, delete and search the data.
// program let the user to input the number and the numbers can be sorted,search, added , edit and deleted.
// program also let the user to perform 4 mathematical functions as mode, average, mid_extreme and range.
namespace AstronomicalProcessing
{
    //CR5: Name of the application should be Astronomical processing
    public partial class AstronomicalProcessing : Form
    {
        #region BUILTIN
        public AstronomicalProcessing()
        {
            InitializeComponent();
        }
        private void AstronomicalProcessing_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ButtonAdd, "Click here to Add number");
            toolTip1.SetToolTip(ButtonModify, "Click here to Modify number");
            toolTip1.SetToolTip(ButtonDelete, "Click here to Delete number");
            toolTip1.SetToolTip(ButtonSort, "Click here to Sort numbers");
            toolTip1.SetToolTip(ButtonMid, "Click here to Calculate Mid-Extreme");
            toolTip1.SetToolTip(ButtonMode, "Click here to Calculate Mode");
            toolTip1.SetToolTip(ButtonAverage, "Click here to Calculate Average");
            toolTip1.SetToolTip(ButtonRange, "Click here to Calculate Range");
            toolTip1.SetToolTip(ButtonLinearSearch, "Click here for Linear Search");
            toolTip1.SetToolTip(ButtonSearch, "Click here for Binary Search");
            toolTip1.SetToolTip(ButtonSearch, "Click here for Binary Search");
            toolTip1.SetToolTip(TextBoxHours, "Type in this box");

        }
        #endregion

        #region DECLARING ARRAY, DISPLAY METHOD, FILL RANDOM NUMBERS

        //PR2:The array has 24 elements to reflect the number of hours per day.
        static int maxNumber = 24;
        //CR1/PR1: All data is stored as integers in an array.
        int[] hours = new int[maxNumber];
        int nextIndex = 0;
        private void DisplayNumber()
        {
            ListBoxHours.Items.Clear();
            for (int i = 0; i < nextIndex; i++)
            {
                ListBoxHours.Items.Add(hours[i]);
            }
        }
        private void ListBoxHours_Click(object sender, EventArgs e)
        {
            if (ListBoxHours.SelectedItem != null)
            {
                int current = int.Parse(ListBoxHours.SelectedItem.ToString());
                int idx = ListBoxHours.Items.IndexOf(current);
                TextBoxHours.Text = hours[idx].ToString();
            }
            else
            {
                toolStripStatusLabel1.Text = "Select a number from the List";
            }

        }

        private void ButtonAutofill_Click(object sender, EventArgs e)
        {
            //FR:1 To display the random number from 10 to 99.
            nextIndex = 24;
            Random rand = new Random();
            for (int i = 0; i < nextIndex; i++)
            {
                int random = rand.Next(10, 100);
                hours[i] = random;

            }
            DisplayNumber();
        }
        #endregion

        #region ADD, MODIFY AND DELETE

        //CR4/PR: Input textbox so that user can add, edit and delete the data 
        private void ButtonAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TextBoxHours.Text))
            {
                try
                {
                    int number = int.Parse(TextBoxHours.Text);
                    hours[nextIndex] = number;
                    nextIndex++;
                    DisplayNumber();
                    TextBoxClearFocus();

                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Input exceed the limit of 24 numbers",
                        "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxClearFocus();
                }

                catch (FormatException)
                {
                    MessageBox.Show("Invalid input,Enter numbers only",
                       "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxClearFocus();
                }

            }
            // PR6: The program must generate an error message if the text box is empty.
            else
            {
                MessageBox.Show("Blank space detected!Please input number in the Box.",
                    "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {

            if (ListBoxHours.SelectedIndex != -1)
            {
                int current = int.Parse(ListBoxHours.SelectedItem.ToString());
                int idx = ListBoxHours.Items.IndexOf(current);

                DialogResult modifyTask = MessageBox.Show("Do you want to Continue?", "It will permanently modify the data.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (modifyTask == DialogResult.Yes)

                {

                    int.TryParse(TextBoxHours.Text, out hours[idx]);
                    DisplayNumber();
                    TextBoxClearFocus();
                }
                else
                {

                    toolStripStatusLabel1.Text = "User had cancelled to modify";

                }
            }
            else
            {
                toolStripStatusLabel1.Text = "User need to select data from the list";
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxHours.SelectedIndex != -1)
            {
                int current = int.Parse(ListBoxHours.SelectedItem.ToString());
                int idx = ListBoxHours.Items.IndexOf(current);
                DialogResult delTask = MessageBox.Show("Do you want to Continue?", "It will permanently Delete the data.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delTask == DialogResult.Yes)
                {
                    hours[idx] = hours[nextIndex - 1];
                    toolStripStatusLabel1.Text = "Number has been Deleted";
                    nextIndex--;
                    DisplayNumber();
                    TextBoxClearFocus();
                }
                else
                {
                    toolStripStatusLabel1.Text = "User had cancelled to Delete";
                }

            }
            else
            {
                toolStripStatusLabel1.Text = "User need to select data from the list";
            }
        }
        #endregion

        #region SORT and SEARCH
        //PR3: sort method using the Bubble Sort algorithm.Sorting in Ascending order
        private void Sort()
        {
            for (int i = 0; i < nextIndex; i++)
            {
                for (int j = i + 1; j < nextIndex; j++)
                {

                    if (hours[i].CompareTo(hours[j]) > 0)
                    {
                        int temp = hours[i];
                        hours[i] = hours[j];
                        hours[j] = temp;
                    }
                }
            }
            DisplayNumber();
        }
        //CR3: Button to sort the data
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            Sort();
        }

        //CR3: Button to search the data
        //PR4: search method using the Binary Search algorithm.
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Sort();
            if (!string.IsNullOrEmpty(TextBoxHours.Text))
            {
                int target = int.Parse(TextBoxHours.Text);
                int min = 0;
                int max = nextIndex - 1;
                int mid = 0;
                bool found = false;

                while (min <= max)
                {

                    mid = (min + max) / 2;
                    if (target == hours[mid])
                    {
                        found = true;
                        break;
                    }
                    else if (target.CompareTo(hours[mid]) < 0)
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                //PR:8 Code must generate a message if the search is successful.
                if (found)
                {
                    MessageBox.Show(target + " is located in line " + (mid + 1),
                        "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //PR:7 Code must generate a message if the search is not successful.
                else
                {
                    MessageBox.Show("Number not found",
                        "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                toolStripStatusLabel1.Text = "Search Failed: Please enter numbers into text box";

            }
        }
        #endregion

        #region UTILITIES
        private void AstronomicalProcessing_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            
        }

        //CR2/PR5: The client can use a text box input to search the array.
        private void TextBoxHours_KeyPress(object sender, KeyPressEventArgs e)
        {

            TextBoxHours.MaxLength = 2;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                toolStripStatusLabel1.Text = "Only digit accepted, not letter or alphabet";

            }


        }
        private void TextBoxClearFocus()
        {
            TextBoxHours.Clear();
            TextBoxHours.Focus();
        }
        #endregion

        #region Sequential Search
        //CR: Button to search the data
        //PR: search method using the Linear Search algorithm and using single for loop and one if condition.
        private void ButtonLinearSearch_Click(object sender, EventArgs e)
        {
            int i;
            if (!string.IsNullOrEmpty(TextBoxHours.Text))
            {
                int target = int.Parse(TextBoxHours.Text);
                bool found = false;
                for (i = 0; i < nextIndex; i++)
                {
                    if (target == hours[i])
                    {
                        found = true;
                        break;
                    }
                }
                //PR: Code must generate a message if the search is successful.
                if (found)
                    MessageBox.Show(target + " is located in line " + (i + 1),
                        "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Number not found",
                        "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                toolStripStatusLabel1.Text = "Search Failed: Please enter numbers into text box";

            }

        }
        #endregion

        #region Average Button Function
        //CR: Need to have average button on software design
        //PR: Code to calculate the average of the function. 
        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < nextIndex; i++)
            {

                sum += hours[i];//Store the total of the numbers in array
            }
            double average = sum / nextIndex;//calculate average by dividing the number of element available in the array
            TextBoxAverage.Text = average.ToString("0.00");
        }

        #endregion

        #region Mid_Extreme button fuction
        //Cr:Pr: Should have button to find the Mid_extreme or Mid_Range of the array hours[]
        private void ButtonMid_Click(object sender, EventArgs e)
        {

            double mid = (FindMax(hours) + FindMin(hours)) / 2.0;// Called the Max and Min function to find mid_Extreme
            TextBoxMid.Text = mid.ToString("0.00");

        }
        #endregion

        #region Mode Function
        //CR: Application should have a button to calculate the Mode of the given elements in a text box 
        private void ButtonMode_Click(object sender, EventArgs e)
        {
            //Called modeNumber function to display the mode of the array using button.
            TextBoxMode.Text = modeNumber(hours, out int count).ToString() + "\n" + "Count:" + count;
        }

        public String modeNumber(int[] numbers, out int maxCounter)
        {
            maxCounter = 0;
            List<int> modeNumbers = new List<int>();
            for (int i = 0; i < nextIndex; i++)
            {
                int counter = 0;
                for (int j = 0; j < nextIndex; j++)
                {
                    if (hours[i] == hours[j])
                        counter++;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    modeNumbers.Clear();


                }
                if (counter == maxCounter)
                {
                    if (modeNumbers.Contains(numbers[i]))
                    {
                        continue;
                    }
                    modeNumbers.Add(numbers[i]);
                }

            }
            return string.Join(",", modeNumbers);
        }
        #endregion

        #region Range
        //To calulate the Range
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            int range = FindMax(hours) - FindMin(hours);
            TextBoxRange.Text = range.ToString();
        }
        #endregion

        #region Minimum and Maximum
        //Method to return Maximum and Minimum Number.
        public int FindMax(int[] myarray)
        {
            int max = 0;
            for (int x = 0; x < nextIndex; x++)
            {
                if (myarray[x] > max)
                    max = myarray[x];
            }
            return max;
        }
        public int FindMin(int[] myarray)
        {
            int min = 100;
            for (int x = 0; x < nextIndex; x++)
            {
                if (myarray[x] < min)
                    min = myarray[x];
            }
            return min;
        }
        #endregion

        #region Validating Textbox
        // Validating Input of the textbox and prevent the user to enter number less than 10
        private void TextBoxHours_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidNumbers(TextBoxHours.Text, out errorMsg))
            {
                // Cancel the event  the text to be corrected by the user
                e.Cancel = true;
                TextBoxHours.Clear();
                toolStripStatusLabel1.Text = errorMsg;

            }

        }

        public bool ValidNumbers(string textboxInput, out string errorMessage)
        {
            try
            {
                if (int.Parse(textboxInput) >= 10)
                {
                    errorMessage = "";
                    return true;
                }
                errorMessage = "Number must be more than 10";
                return false;
            }
            catch (Exception)
            {
                errorMessage = "Input number in textbox";
                return true;
            }


        }
        #endregion
    }


}
