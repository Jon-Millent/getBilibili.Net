using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getBiliBili {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private int press;
        private Boolean canSend = true;
        private void button1_Click(object sender, EventArgs e) {

            if (!canSend)
            {
                MConsole.Log("少年手速太快了，雅蠛蝶");
            }
            canSend = false;
            //验证av号码
            Regex isNumber = new Regex(@"^[0-9]{2,10}");
            if (!isNumber.IsMatch(avcode.Text)){
                MConsole.Log("请输入正确的av号,例如： 170000");
                return;
            }
            //隐藏下载按钮
            saveImages.Visible = false;
            //隐藏原来的图片
            titleimg.Visible = false;
            backgroundWorker1.RunWorkerAsync();
            mypress.Visible = true;

           

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {

            SaveFileDialog _SaveFileDialog = new SaveFileDialog();
            _SaveFileDialog.Filter = "*.jpg|*.jpg";
            if (_SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                titleimg.Image.Save(_SaveFileDialog.FileName, ImageFormat.Jpeg);
                MConsole.Log("保存成功，少年拿好你的纸巾");
            }

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {


            this.backgroundWorker1.ReportProgress(0);
            //及逆行http请求
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = "https://www.bilibili.com/video/av" + avcode.Text,//URL     必需项    
                Method = "get",//URL     可选项 默认为Get   
                //ContentType = "text/html",//返回类型    可选项有默认值   
                ContentType = "application/x-www-form-urlencoded",//返回类型    可选项有默认值 
                Allowautoredirect = true//默认为False就是不根据重定向自动跳转
            };
            HttpResult result = http.GetHtml(item);
            string Html = result.Html;

            this.backgroundWorker1.ReportProgress(80);
            //得到html进行匹配图片如果存在则显示
            string a = MillentUtil.GetHtmlImageUrlList(Html);
            if (a == "")
            {
                return;
            }
            string url = string.Format("http:" + a);

            
            System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
            System.Net.WebResponse webres = webreq.GetResponse();
            using (System.IO.Stream stream = webres.GetResponseStream())
            {
                //解决线程冲突
                this.backgroundWorker1.ReportProgress(99);
                this.Invoke(new MethodInvoker(delegate ()
                {
                    titleimg.Image = Image.FromStream(stream);
                    saveImages.Visible = true;
                    titleimg.Visible = true;
                }));
                
            }
        }

        private void backgroundWorker1_Progress(object sender, ProgressChangedEventArgs e) {
            mypress.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            mypress.Value = 100;
            mypress.Visible = false;
            canSend = true;
        }
    }
}
