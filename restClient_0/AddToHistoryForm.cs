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

namespace restClient_0
{
    public partial class AddToHistoryForm : Form
    {
        public string path = "C:\\Users\\MR-al\\Desktop\\thread\\restClient_0\\list.txt";
        public AddToHistoryForm(string text)
        {
            InitializeComponent();
            Text = text;
            txturl.Text = Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addtohistory();
        }
        public void addtohistory()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = File.AppendText(path);
                //Write a line of text
                sw.WriteLine(txturl.Text+"|"+txtTitle.Text);
                //Write a second line of text
                //Close the file
                sw.Close();
                MessageBox.Show("Page Add Success");
                button1.Enabled = false;
            }
            catch (Exception x)
            {
                MessageBox.Show("error!!" + x.Message);
            }
        }
    }
}
