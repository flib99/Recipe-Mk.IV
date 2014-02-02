//(C) Copyright Josh Walls 2013-14. All Rights Reserved.
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Recipe_Mk.IV
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

		//Program variables
        private string strRecipeName;		//The name of the recipe
        private int intPeopleNumber;		//The number of people the input recipe is for
        private int intOutPeople;			//The number of people the recipe needs to be reclaulated for

        //Variables for whether or not buttons clicked
        bool boolBtnRecipeGoClick;
        bool lootbtnGoClick;

	    List<string> ingredients = new List<string>();		//The ingredients list
        List<int> amounts = new List<int>();		//The amounts list
        List<string> units = new List<string>();		//The units list
        List<int> divideAmounts = new List<int>();		//The amounts after they have been divided by the original number of people to give the amounts needed for one person
        List<string> multiplyAmounts = new List<string>();		//The amounts after they have been multiplied by the new number of people to give the recalculated amounts

        private void btnRecipeGo_Click(object sender, EventArgs e)		//The 'Go' on the first tab page
        {
            strRecipeName = txtName.Text;		//Sets the contents of the name text box on the first tab page as strRecipeName
            intPeopleNumber = Convert.ToInt32(numericUpDownPeople.Value);		//Does the same for the amount of people but converts to an int32 first

            boolBtnRecipeGoClick = true;		//Sets boolBtnRecipeGoClick as true to say that the go button has been clicked to prevent dividing by 0
            tabControl1.SelectedIndex = 1;		//Switches to the next tab

            this.Text = strRecipeName;		//Sets the name of the form to the name of the recipe

            MessageBox.Show("Done!");   //Message box will only show if all operations complete to give user confirmation that something has happened.
        }
        private void btnGo_Click(object sender, EventArgs e)		//The 'Next' button on the second tab page
        {
			ingredients.Add(txtIngredients.Text);		//Adds the contents of the ingredients text box to the ingredidents list
            amounts.Add(Convert.ToInt32(numericUpDownAmount.Value));		//Same as above but converts to int32
            units.Add(Convert.ToString(comboBoxUnits.Text));		//Same as above but converts to string

            txtIngredients.Text = "";		//Clears the textboxes
            numericUpDownAmount.Value = 1;
            comboBoxUnits.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)		//The 'Save' button in the 'File' menu
        {
            SaveFileDialog save = new SaveFileDialog();		//Creates a new instance of SaveFileDialog called save
            save.FileName = strRecipeName + ".recipe";		//Sets the default file name as name of recipe.recipe
            save.Filter = "Recipe File | *.recipe";		//Sets the default file extension as a Recipe File as a .recipe
            if (save.ShowDialog() == DialogResult.OK)		//If statment to check that OK is clicked. If OK is not clocked then the save bit does not run.
            {
				StreamWriter writer = new StreamWriter(save.OpenFile());		//Creates a new instance of a StreamWriter called writer and saves to the file selcted by the SaveFileDialog
      
#region  first old bit done		//First Old bit. Talked about in detail in the evaluation
				
				//writer.WriteLine("<?xml version=\"1.0\"?>");
				//writer.WriteLine("<ingredients>");
				//foreach (string s in ingredients)
				//{ 
				//	writer.WriteLine(s);
				//}
				//writer.WriteLine("</ingredients>" + "\n");

				//writer.WriteLine("<amount>");
				//foreach (int i in amounts)
				//{
				//	writer.WriteLine(i);
				//}
				//writer.WriteLine("</amount>");

				//writer.WriteLine("<units>" + "\n");
				//foreach (string u in units)
				//{
				//	writer.WriteLine(u);
				//}
				//writer.WriteLine("</units>");
                
#endregion

#region second old bit done		//Second old bit. Talked about in detail in the evaluation

				//foreach (string q in ingredients)
				//{
				//	foreach (int w in amounts)
				//	{
				//		foreach (string r in units)
				//		{
				//			writer.Write(q + ",");
				//			writer.Write(w + ",");
				//			writer.Write(r + "\n");
				//		}
				//	}
				//}
                

				//writer.Write("//Recipe file. Amounts are per person. [ingredient],[amount],[units]." + "\n");
				#endregion

				for (int i = 0; i < ingredients.Count; i++)		//For loop. When the length on ingredients is greater than i, i.e. every index in the array.
				{
					writer.WriteLine("{0},{1},{2}", ingredients[i], divideAmounts[i], units[i]);		//The write the line to the file in the syntax [ingredients],[divideAmounts],[units]
				}

				writer.Dispose();		//Dispose and close the writer
				writer.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)		//The 'open' button in the 'file' menu
        {
            DialogResult result = MessageBox.Show("Opening a new file will clear the currently open recipe." + "\n" + "Do you want to continue?", "Warning!",
                MessageBoxButtons.YesNo);		//Warns user that opeing a new recipe will clear the currently open one.

            if (result == DialogResult.No)		//If the user clicks no then the open bit stops.
            {
                boolBtnRecipeGoClick = false;		//Sets whether the go button has been clicked to false to prevent dividing by 0
                return;
            }

            boolBtnRecipeGoClick = true;		

            ingredients.Clear();		//Clears all the lists
            amounts.Clear();
            multiplyAmounts.Clear();
            divideAmounts.Clear();
            units.Clear();

            OpenFileDialog open = new OpenFileDialog();		//Creates new instance of OpenFileDialog called open
            open.Filter = "Recipe Files|*.recipe|All Files|*.*";		//Sets the filters to .recipe files and all files
            open.FilterIndex = 1;		//Sets the default filter to .recipe

			if (open.ShowDialog() == DialogResult.OK)		//If the result of the SaveFileDialog is OK
			{
				StreamReader reader = new StreamReader(open.FileName);		//Creates a new instance of a StreamReader called reader reader and reads the file selected in the OpenFileDialog

				string[] allLines = reader.ReadToEnd().Split('\n');		//Creates a new array called allLines with the constents of the text files split by new lines

				reader.Close();		//Closes the reader

				foreach (string line in allLines)		//Foreach line in allLines      
				{
					string[] splitLine = line.Split(',');		//Creates new array called splitLine splitting the string by commas
					if (splitLine[0] != "")		//Checks that the string is not empty. Should never be empty.
					{
						ingredients.Add(splitLine[0]);		//Adds the first index of the array to ingredients
						multiplyAmounts.Add(splitLine[1]);		//Adds the second index of the array to multiplyAmounts
						units.Add(splitLine[2]);		//Adds the third index of the array to units
					}                                        
				}

				tabControl1.SelectedIndex = 2;		//Selects the third tab page, the output page

				string fileName = Path.GetFileName(open.FileName);		//Sets the string fileName as the file name of the opened file
				strRecipeName = fileName.Remove(fileName.Length - 7, 7);		//Sets the recipe name as the file name minus the .recipe

				this.Text = strRecipeName;		//Sets the name of the form to the name of the recipe
			}
			else		//Do nothing on else
			{
				return;
			}

#region old bit		//Old reader bit. Talked about in detail in evaluation
			//hello = reader.ReadLine();

			//string[] ingredientsArray = hello.Split(',');

			//int count = 1;

			//foreach (string s in ingredientsArray)
			//{
			//	if (count == 1)                 //Get this bit working
			//	{
			//		count = count + 1;
			//		ingredients.Add(s);
			//	}
			//	else if (count == 2)
			//	{
			//		count = count + 1;
			//		multiplyAmounts.Add(s);
			//	}
			//	else if (count == 3)
			//	{
			//		units.Add(s);
			//		count = 1;
			//	}
			//}
			#endregion
		}

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)		//The 'Close' button in the 'File' menu
        {
            Application.Exit();		//Exits the application
        }

        private void btnOutGo_Click(object sender, EventArgs e)		//The 'Go' button on the output tab page
        {
            intOutPeople = Convert.ToInt32(numericUpDownOutPeople.Value);		//Sets the new number of people as an integer

			richTextBoxIngredientOut.ResetText();		//Clears the text boxes
            richTextBoxAmountOut.ResetText();
			richTextBoxUnitsOut.ResetText();

            foreach(int i in divideAmounts)		//Foreach loop which takes each index in divideAmounts
            {
                int h = i * intOutPeople;		//h is the amount for the new number of people
                multiplyAmounts.Add(Convert.ToString(h));		//Converts it to string then adds it to the mutiplyAmounts array
            }

            richTextBoxIngredientOut.Lines = ingredients.ToArray();		//Adds the lists to the respective richTextBox
            richTextBoxAmountOut.Lines = multiplyAmounts.ToArray();
            richTextBoxUnitsOut.Lines = units.ToArray();

			btnOutGo.Enabled = false;		//Disabled the go button
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)		//Other menu items that don't do anything
        {
			MessageBox.Show("Yeah, no. This bit is just for show.");
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Yeah, no. This bit is just for show.");
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Yeah, no. This bit is just for show.");
        }

        private void btnNext_Click(object sender, EventArgs e)		
        {
            foreach (int i in amounts)		//Takes each index in amounts
            {
                int h = i / intPeopleNumber;		//Finds amounts for one person

                divideAmounts.Add(h);		//Add it to divideAmounts
            }
			tabControl1.SelectedIndex = 2;		//Selects the output tab
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)		//Other menu items that don't do anything
        {
            MessageBox.Show("© Copyright Josh Walls 2013-14. All Rights Reserved.");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tough.");
            MessageBox.Show("Work it out yourself.");
            MessageBox.Show("Google is your friend.");
            MessageBox.Show("How do you think I found out how to do it?");
            MessageBox.Show("Stop being lazy.");
        }

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Yeah, no. This bit is just for show.");
		}

		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Yeah, no. This bit is just for show.");
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Yeah, no. This bit is just for show.");
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Yeah, no. This bit is just for show.");
		}
     

		


    }
}