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
    public partial class modedyfav : Form
    {
        public string path2 = "C:\\Users\\MR-al\\Desktop\\thread\\restClient_0\\listfav.txt";
        public modedyfav()
        {
            InitializeComponent();
            ReadFav();
        }
        public void ReadFav()
        {
            try
            {
                StreamReader file = new StreamReader(path2);
                string[] columnnames = file.ReadLine().Split('|');
                DataTable dt = new DataTable();
                foreach (string c in columnnames)
                {
                    dt.Columns.Add(c);
                }
                string newline;
                while ((newline = file.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    string[] values = newline.Split('|');
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }
                    dt.Rows.Add(dr);
                }
                file.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txturl.Text = row.Cells[0].Value.ToString();
                txtTitle.Text = row.Cells[1].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = path2;
            string urllink = Convert.ToString(txturl.Text); // delete the selected line  
            string urltitle = Convert.ToString(txtTitle.Text);
            var oldLines = System.IO.File.ReadAllLines(path);
            var newLines = oldLines.Where(line => !line.Contains(urllink));
            var newlinetitle = oldLines.Where(line => !line.Contains(urltitle));
            System.IO.File.WriteAllLines(path, newLines );
            System.IO.File.WriteAllLines(path, newlinetitle);
            FileStream obj = new FileStream(path, FileMode.Append);
            obj.Close();
            // once deleted the selected line and once again read the text file and diplay the new text file in listBox  
            FileInfo fi = new FileInfo(path2);
            using (StreamReader sr = fi.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    urllink = s;
                    urltitle = s;
                }
                sr.Close();
            }
            FileStream obj1 = new FileStream(path, FileMode.Append);
            obj1.Close();
            MessageBox.Show("Done..");
            dataGridView1.Refresh();
            ReadFav();
        }

        private void modedyfav_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = File.ReadAllText(path2);
            str = str.Replace(txtTitle.Text, txtnewname.Text);
            File.WriteAllText(path2, str);
            MessageBox.Show("Done..");
            dataGridView1.Refresh();
            ReadFav();
        }
    }
}
