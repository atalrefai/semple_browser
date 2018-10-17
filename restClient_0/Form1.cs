using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Http;


namespace restClient_0
{
    public partial class Form1 : Form
    {
        int i = 0;
        Image CloseImage;
        //public Thread thread;
        private static Mutex mut = new Mutex();
        TextBox tb;
        int count = 0;
        public string path = "C:\\Users\\MR-al\\Desktop\\thread\\restClient_0\\list.txt";
        public string path2 = "C:\\Users\\MR-al\\Desktop\\thread\\restClient_0\\listfav.txt";

        public Form1()
        {
            InitializeComponent();
            GetMyIpAddress();
            responcemsg.Text = "stand by ..";
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
               
               Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var thread = new Thread(WorkThreadFunction)
            {
                Name = "th" + count
            };
            thread.Start();
            count++;
            //addtohistory();
            
           }
      
        public void WorkThreadFunction()
        {
            Thread.Sleep(0x3e8);
            mut.WaitOne();
            RESTClient rClient = new RESTClient();
            rClient.endPoint = txtRequestURI.Text;
            string strJSON = string.Empty;
            responcemsg.Text = "waiting ..";
            strJSON = rClient.makeRequest();
            this.Invoke((MethodInvoker)delegate () { addtab(strJSON); });
            responcemsg.Text = "";
            responcemsg.Text = "Done ..";
             mut.ReleaseMutex();   
        }
       
        public void addtab(string url)
        {
            try
            {
                tb = new TextBox();
                tb.Multiline = true;
                tb.Text = url;
                tb.Dock = DockStyle.Fill;
                tb.ScrollBars = ScrollBars.Vertical;
                tabControl1.TabPages.Add("New Tab");
                tabControl1.SelectTab(i);
                var thread = new Thread(ThreadTab)
                {
                    Name = "tab_thread"
                };
                thread.Start();

                i += 1;
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        public void ThreadTab()
        {
            Thread.Sleep(0x3e8);
            mut.WaitOne();
            
            this.Invoke((MethodInvoker)delegate () { tabControl1.SelectedTab.Controls.Add(tb); });
            mut.ReleaseMutex();
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
                dataGridView2.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        public void ReadTextFile()
        {
            try
            {
                StreamReader file = new StreamReader(path);
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
        private void favoretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddToFav();
        }
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //public void addtohistory()
        //{
        //    try
        //    {
        //        //Pass the filepath and filename to the StreamWriter Constructor
        //        StreamWriter sw = File.AppendText(path);
        //        //Write a line of text
        //        sw.WriteLine(txtRequestURI.Text);
        //        //Write a second line of text
        //        //Close the file
        //        sw.Close();
        //    }
        //    catch (Exception x)
        //    {
        //        responcemsg.Text = "error!!" + x.Message;
        //    }
        //}
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            txtRequestURI.Text = selectedRow.Cells[0].Value.ToString();
        }
        public void GetMyIpAddress()
        {
            string myHost = Dns.GetHostName();
            ip.Text = myHost;
            string myIP = Dns.GetHostByName(myHost).AddressList[0].ToString();
            ip.Text = myIP;
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Controls[0].Refresh();
        }
     
        #region add close btn for tabs
        public static Rectangle GetRTLCoordinates(Rectangle container, Rectangle drawRectangle)
        {
            return new Rectangle(
                container.Width - drawRectangle.Width - drawRectangle.X,
                drawRectangle.Y,
                drawRectangle.Width,
                drawRectangle.Height);
        }
        public void TabControl1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            try
            {
                var tabRect = this.tabControl1.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);

                var sf = new StringFormat(StringFormat.GenericDefault);
                if (this.tabControl1.RightToLeft == System.Windows.Forms.RightToLeft.Yes &&
                    this.tabControl1.RightToLeftLayout == true)
                {
                    tabRect = GetRTLCoordinates(this.tabControl1.ClientRectangle, tabRect);
                    imageRect = GetRTLCoordinates(this.tabControl1.ClientRectangle, imageRect);
                    sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                }

                e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, this.Font, Brushes.Black, tabRect, sf);
                e.Graphics.DrawImage(CloseImage, imageRect.Location);

            }
            catch (Exception) { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += TabControl1_DrawItem;
            CloseImage = restClient_0.Properties.Resources.noc;
            tabControl1.Padding = new Point(10, 3);
        }
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            for (i = 1; i < this.tabControl1.TabPages.Count; i++)
            {
                var tabRect = this.tabControl1.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    this.tabControl1.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
        #endregion

        private void addToHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addToHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            AddToHistoryForm frm2 = new AddToHistoryForm(txtRequestURI.Text);
            frm2.ShowDialog();
        }

        private void showHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                ReadTextFile();
                showHistoryToolStripMenuItem.Text = "Hide History";
            }
            else
            {
                panel1.Visible = false;
                showHistoryToolStripMenuItem.Text = "Show History";
            }
        }

        private void addToFavoretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTOFavoret frm2fav = new AddTOFavoret(txtRequestURI.Text);
            frm2fav.ShowDialog();
        }

        private void showFavoretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;

                dataGridView2.Visible = true;
                ReadFav();
                showFavoretToolStripMenuItem.Text = "Hide Favorets";
            }
            else
            {
                panel2.Visible = false;
                // panel1.Visible = false;

                dataGridView2.Visible = true;
                showFavoretToolStripMenuItem.Text = "Show Favorets";
            }
        }

        private void modefyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modedyfav modefav = new modedyfav();
            modefav.ShowDialog();
        }

        private void modefyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Historymodefy modehis = new Historymodefy();
            modehis.ShowDialog();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRequestURI.Text = "http://www.atalrefai.com";
        }
    }
}
