using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Need to add this namespace to use the Streamwriter objects. 

namespace Week_3_B
{
    public partial class frmWritingFiles : Form
    {
        public frmWritingFiles()
        {
            InitializeComponent();
        }

        private void btnGenerate_Save_Click(object sender, EventArgs e)
        {
            //Declare Streamwriter object. 
            StreamWriter outputFile;

            //Create Random object. 
            Random rand = new Random();

            //Declare and Initialize variables to hold User inputs. 
            int START_Range;
            int END_Range;
            int Numbers;

            //Check if User's inputs are of int type.
            if (int.TryParse(txtStartRange.Text, out START_Range) && int.TryParse(txtEndRange.Text, out END_Range) 
                                                                  && int.TryParse(txtNumbers.Text, out Numbers))
            {
                //Check to ensure end_range value is greater than start_range value and
                //that user puts a value greater than zero for numbers. 
                if (END_Range > START_Range && Numbers > 0)
                {
                    //Makes the saving path to the C drive the default. 
                    //Need two \\ to tell computer this is not a special character like \t (tab) or \n (new line).
                    sfdSaveFile.InitialDirectory = "C:\\";  

                    //Googled for this specific code in " " to filter out only txt files. 
                    sfdSaveFile.Filter = "Text|*.txt|ALL|*.*";

                    //Present user with save file dialog control. 
                    if (sfdSaveFile.ShowDialog() == DialogResult.OK)
                    {
                        //Create a file and save it at the correct location. 
                        outputFile = File.CreateText(sfdSaveFile.FileName);

                        //Process the file below: 
                        //Declare and Initialize count variable for the for loop/Numbers variable. 
                        int count;

                        //Declare and Initialize random number variable to hold generated random numbers. 
                        int random_number;

                        //Begin for loop for generating random numbers.
                        for (count = 1; count <= Numbers; count++)
                        {
                            //Specify Random Range so that it is INCLUSIVE 
                            random_number = rand.Next(START_Range, END_Range + 1);

                            //Write the random_number and count to file and have random_number written first. 
                            //Must use ToString to convert count to a string when adding the "\t" or tab. 
                            outputFile.WriteLine(count.ToString() + "\t" + random_number); 
                            
                        }

                        //Close connection between application and file once the for loop is finished. 
                        outputFile.Close();

                        //Tell User their file was saved successfully. 
                        MessageBox.Show("File saved successfully!");

                    }

                    else
                    {
                        //Tell User the operation was cancelled. 
                        MessageBox.Show("This operation was cancelled.");

                    }
                }

                else
                {
                    //Error Message if user typed an invalid range.  
                    MessageBox.Show("Invalid Input. Please enter a valid range.");

                }
            }

            else
            {
                //Error Message if user typed a non-integer value. 
                MessageBox.Show("Invalid Input. Please enter only integers.");

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resets all textboxes to clear. Used new Clear() method to clear textboxes.  
            txtStartRange.Clear();
            txtEndRange.Clear();
            txtNumbers.Clear();

            //Sets the focus back on the Start Range textbox. 
            txtStartRange.Focus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the form entirely. 
            this.Close();
        }

    }
}
