using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Road.Files;
using System.Road.Word;
using System.Threading;

namespace _2013092401文章导出为txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rbtn_1.Checked = true;
            rbtn_2.Checked = false;
            rbtn_4.Checked = false;
            rbtn_8.Checked = false;
        }
        Export ep = new Export();
        FileControl fc = new FileControl();
        HtmlFilter hf = new HtmlFilter();
        HandleMsg hm = new HandleMsg();
        System.Road.Word.TransStr ts = new TransStr();
        public int count =1;
        public int allCount = 0;
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            txtFolderPath.Text = fc.FolderPathOpen(folderBrowserDialog1);
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            //重置count和allCount
            count = 1;
            allCount = 0;

            string webname = "";
            int threadCount = 1;
            if (rbtn_cnbeta.Checked)
            {
                webname = "cnbeta";
            }
            else if (rbtn_encn.Checked)
            {
                webname = "encn";
            }

            foreach (var item in gpThread.Controls)
            {
                if (item is RadioButton)
                {
                    if (((RadioButton)item).Checked)
                    {
                        threadCount = Convert.ToInt32(((RadioButton)item).Text.Trim());
                    }
                }
            }

            int pageStart = 0;
            int pageEnd = 0;
            string path = "";
            //Export ep = new Export();
            Invoke(new Action(() =>
            {
                path = txtFolderPath.Text.Trim();
                pageStart = Convert.ToInt32(txtPfrom.Text);
                pageEnd = Convert.ToInt32(txtPto.Text);
                allCount = pageEnd - pageStart + 1;
                pgbar.Maximum = allCount;
            }));
            //计算每个线程的页面
            int pageCountPart = allCount / threadCount;
            int pageCountPartLast = allCount % threadCount;
            //for (int i = 0; i < threadCount; i++)
            //{
            //    if (i < threadCount - 1)
            //    {
            //        Thread t1 = new Thread(() => { Export(webname, i + 1, pageStart + i * pageCountPart, pageStart + (i + 1) * pageCountPart, path); });
            //        t1.IsBackground = true;
            //        t1.Start();
            //    }
            //    else// if (i==threadCount-1)
            //    {
            //        Thread t2 = new Thread(() => { Export(webname, i + 1, pageStart + i * pageCountPart, pageEnd, path); });
            //        t2.IsBackground = true;
            //        t2.Start();
            //    }
            //}
            Thread t1 = new Thread(() => { Export(webname,1, pageStart, pageEnd, path); });
            t1.IsBackground = true;
            t1.Start();

        }
        private void Export(string webname, int threadid, int pageStart, int pageEnd, string path)
        {
            int allCountPart = pageEnd - pageStart + 1;
            DateTime dtStart=DateTime.Now;
            string msg = "";
            for (int page = pageStart; page <= pageEnd; page++)
            {
                if (webname == "cnbeta")
                {
                    msg = ep.ExportCnbeta(page, path);
                }
                if (webname == "encn")
                {
                    msg = ep.ExportEncn(page, path);
                }
                //msg = page.ToString();
                //string mycost = ts.SecondToTimeE(ts.SecondCostLeave(pageStart, allCountPart, page, ts.SecondCost(dtStart)));
                hm.AppendMsg(rtxt, Color.Black, msg, false);
                Invoke(new Action(() =>
                {
                    //lbCostLeave.Text = mycost;
                    //rtxt.AppendText(mycost);
                    pgbar.Value = count;
                    lbpgbar.Text = (100 * Convert.ToDouble(count) / Convert.ToDouble(allCount)).ToString("0.00") + "%";
                }));
                count++;//所有线程没完成一条，则count+1
                //int count = page - pageStart + 1;//已完成
            }
        }
    }
}
