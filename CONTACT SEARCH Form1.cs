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
using System.IO;
namespace CONTACT_SEARCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            if(searchText==null||searchText=="")
            {
                MessageBox.Show("search string is empty");
            }
            else
            {
                //string contactsText = File.ReadAllText("");
                StreamReader sReader = new StreamReader("C:\\Users\\Mahesh\\Desktop\\" +
                    "C#LAB PROGRAMS\\contactsearch.txt");
                string tempText = sReader.ReadLine();
                while (tempText != "")
                {


                    if (searchText.Equals(tempText))
                    {
                        listBox1.Items.Add(searchText);
                        listBox1.Items.Add(sReader.ReadLine());
                        break;
                    }
                    tempText = sReader.ReadLine();
                }
            }
        }
    }
}
