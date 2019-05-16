using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTableExample1
{
    public partial class Form1 : Form
    {
        // Here we have some class level components for the form
        public List<Label> rowLabels0 = new List<Label>();
        public List<Label> rowLabels1 = new List<Label>();
        public List<Label> rowLabels2 = new List<Label>();
        public List<FlowLayoutPanel> countPanel = new List<FlowLayoutPanel>();
        List<int> maleCount = new List<int>();
        List<int> femaleCount = new List<int>();
        public Form1()
        {
            /*
             * First we want to set some rules for the form
             */
            AutoSize = true;
            MaximumSize = new Size(800, 500);
            AutoScroll = true;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // make the form !visible for now
            this.Visible = false;
            // set some rules on the table
            Table1.AutoSize = true;
            Table1.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            Table1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            // some values to put in the labels
            string[] somecolors = new string[] { "RED", "BLUE", "ORANGE", "PURPLE"};
            string[] someshapes = new string[] { "Square", "Circle", "Triangle", "Rectangle" };
            string[] somejunk = new string[] { "Crayon", "Pumpkin", "Robot", "Shrimp", "Onion" };
            string[] dumbstuff = new string[] { "Your", "New", "Anime", "Count" };

            int rowcount = 1;
            int labelCount = 0;
            for (int i = 0; i < dumbstuff.Length; i++)
            {// set the header labels in row 0 column i
                Table1.Controls.Add((new Label
                {
                    Text = dumbstuff[i],
                    BorderStyle = BorderStyle.Fixed3D
                }), i, 0);
            }
            for (int j = 0; j < somecolors.Length; j++)
            {// loop holds the count for column 0 row rowcount
                for (int q = 0; q < someshapes.Length; q++)
                {// loop holds the count for column 1 row rowcount
                    for (int z = 0; z < somejunk.Length; z++)
                    {// loop holds the count for column 2 row rowcount

                        // dynamically adding labels to the list
                        rowLabels0.Add(new Label {
                            Text = somecolors[j],
                            BorderStyle = BorderStyle.FixedSingle
                        } );
                        rowLabels1.Add(new Label
                        {
                            Text = someshapes[q],
                            BorderStyle = BorderStyle.FixedSingle
                        });
                        rowLabels2.Add(new Label
                        {
                            Text = somejunk[z],
                            BorderStyle = BorderStyle.FixedSingle
                        });
                        // here the table requires a call to the controls with an Add.
                        // This takes 3 arguments: the item, the column, the row.
                        Table1.Controls.Add(rowLabels0[labelCount], 0, rowcount);
                        Table1.Controls.Add(rowLabels1[labelCount], 1, rowcount);
                        Table1.Controls.Add(rowLabels2[labelCount], 2, rowcount);
                        // row count allows for the number of rows to continually grow.
                        rowcount++;
                        // holds the index for each combination of labels being made.
                        labelCount++;
                    }
                }
            }
            
        }
    }
}
