using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Row_cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string key = string.Empty;
            foreach (var item in textBox6.Text)
            {
                if (!key.Contains(item))
                    key += item;

            }
            string plaintxt = textBox5.Text;
  //COMPLETE THE ENTERY TEXT
            while (plaintxt.Length % key.Length != 0)
                plaintxt += "_";
            //COMPUTE THE ROWS & COLUMN
            int row = plaintxt.Length / key.Length;
            int column = key.Length;
            char[,] pm = new char[row, column];
            for (int i = 0; i < column; i++)
            {
                textBox7.Text += " " + key[i];
            }
            textBox7.Text += Environment.NewLine;
            int m = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    pm[i, j] = plaintxt[m++];
                    textBox7.Text += " " + pm[i, j];
                }
                textBox7.Text +=Environment.NewLine;
                
            }

            //
            //for (int c = column - 1; c >= 0; c--)
            //{
            //    for (int b = 0; b < row; b++)
            //    {

            //        textBox9.Text +=  " "+mn[b, c];
            //    }
            //}

            // as format for understand the solution 
            //WE SORT THE 1D ARRAY AND POINT TO INDEXING & FILL THE 2D ARRAY TO ONOTHER ARRAY

            char[] kg = new char[column];
            Array.Copy(key.ToCharArray(), kg, column);
            Array.Sort(kg);
            char[,] mn = new char[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)//1 3 5
                {
                    for (int n = 0; n < column; n++)//5 3 1
                    {
                        if(kg[j]==key[n])
                        {
                            mn[i, j] = pm[i, n];
                            textBox8.Text += mn[i, j];
                        }
                        
                    }
                }
                textBox8.Text += Environment.NewLine;
            }

            //PRINT THE 2D IN SINGLE STRING
            for (int c = 0; c <= column - 1; c++)
            {
                for (int b = 0; b < row; b++)
                {

                    textBox9.Text += " "+mn[b, c];
                }
            }


           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }


       






    }

