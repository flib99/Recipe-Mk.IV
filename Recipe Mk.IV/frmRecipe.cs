//(C) Copyright Josh Walls 2013-14. All Rights Reserved.

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

namespace Recipe_Mk.IV
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        //Program variables
        private string strRecipeName;
        private int intPeopleNumber;
        private int intOutPeople;

        //Variables for whether or not buttons clicked
       // bool boolBtnRecipeGoClick;
      //  bool lootbtnGoClick;

        //string hello;

	    List<string> ingredients = new List<string>();
        List<int> amounts = new List<int>();
        List<string> units = new List<string>();
        List<int> devideAmounts = new List<int>();
        List<string> multiplyAmounts = new List<string>();

        

        private void btnRecipeGo_Click(object sender, EventArgs e)
        {
            strRecipeName = txtName.Text;
            intPeopleNumber = Convert.ToInt32(numericUpDownPeople.Value);

            //boolBtnRecipeGoClick = true;
            tabControl1.SelectedIndex = 1;

            this.Text = strRecipeName;

            MessageBox.Show("Done!");   //Message box will only show if all operations complete
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            

            ingredients.Add(txtIngredients.Text);
            amounts.Add(Convert.ToInt32(numericUpDownAmount.Value));
            units.Add(Convert.ToString(comboBoxUnits.Text));

            txtIngredients.Text = "";
            numericUpDownAmount.Value = 1;
            comboBoxUnits.Text = "";

            foreach (int i in amounts)
            {
                int h = i / intPeopleNumber;

                devideAmounts.Add(h);
            }
        }

                  

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = strRecipeName + ".recipe";
            save.Filter = "Recipe File | *.recipe";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());

                
                /*
                writer.WriteLine("<?xml version=\"1.0\"?>");
                writer.WriteLine("<ingredients>");
                foreach (string s in ingredients)
                { 
                    writer.WriteLine(s);
                }
                writer.WriteLine("</ingredients>" + "\n");

                writer.WriteLine("<amount>");
                foreach (int i in amounts)
                {
                    writer.WriteLine(i);
                }
                writer.WriteLine("</amount>");

                writer.WriteLine("<units>" + "\n");
                foreach (string u in units)
                {
                    writer.WriteLine(u);
                }
                writer.WriteLine("</units>");
                */
                
                /*
                foreach (string q in ingredients)
                {
                    foreach (int w in newAmounts)
                    {
                        foreach (string r in units)
                        {
                            writer.Write(q + ",");
                            writer.Write(w + ",");
                            writer.Write(r + "\n");
                        }
                    }
                }
                */

                //writer.Write("//Recipe file. Amounts are per person. [ingredient],[amount],[units]." + "\n");

                for (int i = 0; i < ingredients.Count; i++)
                {
                    writer.WriteLine("{0},{1},{2}", ingredients[i], devideAmounts[i], units[i]);
                }

                writer.Dispose();
                writer.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Opening a new file will clear the currently open recipe." + "\n" + "Do you want to continue?", "Warning!",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            ingredients.Clear();
            amounts.Clear();
            multiplyAmounts.Clear();
            devideAmounts.Clear();
            units.Clear();

            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            open.Filter = "Recipe Files | *.recipe | All Files | *.*";
            open.FilterIndex = 1;

            StreamReader reader = new StreamReader(open.FileName);

            string[] allLines = reader.ReadToEnd().Split('\n');

            reader.Close();

            foreach (string line in allLines)            //not working
            {
                string[] tokens = line.Split(',');
                if (tokens[0] != "")
                {
                    ingredients.Add(tokens[0]);
                    multiplyAmounts.Add(tokens[1]);
                    units.Add(tokens[2]);
                }                                        //'till here
            }



            //hello = reader.ReadLine();
            //
            //string[] ingredientsArray = hello.Split(',');
            //
            //int count = 1;
            //
            //foreach (string s in ingredientsArray)
            //{
            //    if (count == 1)                 //Get this bit working
            //    {
            //        count = count + 1;
            //        ingredients.Add(s);
            //    }
            //    else if (count == 2)
            //    {
            //        count = count + 1;
            //        multiplyAmounts.Add(s);
            //    }
            //    else if (count == 3)
            //    {
            //        units.Add(s);
            //        count = 1;
            //    }
            //}

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tough. Work it out yourself.");
            MessageBox.Show("Google is your friend.");
            MessageBox.Show("How do you think I found out how to do it?");
            MessageBox.Show("Stop being lazy.");
        }

        private void btnOutGo_Click(object sender, EventArgs e)
        {
            intOutPeople = Convert.ToInt32(numericUpDownOutPeople.Value);

            richTextBoxIngredientOut.Text = "";
            richTextBoxAmountOut.Text = "";
            richTextBoxUnitsOut.Text = "";

            foreach(int i in devideAmounts)
            {
                int h = i * intOutPeople;
                multiplyAmounts.Add(Convert.ToString(h)); 
            }

            richTextBoxIngredientOut.Lines = ingredients.ToArray();
            richTextBoxAmountOut.Lines = multiplyAmounts.ToArray();
            richTextBoxUnitsOut.Lines = units.ToArray();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeah, no. This bit doesn't work yet.");
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeah, no. This bit doesn't work yet.");
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeah, no. This bit doesn't work yet.");
        }

        //private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch(tabControl1.SelectedIndex)
        //    {
        //        case 0:
        //            break;
        //        case 1:
        //            break;
        //        case 2:
        //            foreach (int i in amounts)
        //            {
        //                int h = i / intPeopleNumber;
        //
        //                devideAmounts.Add(h);
        //            }
        //            break;
        //
        //    }
        //}

            
    }
}