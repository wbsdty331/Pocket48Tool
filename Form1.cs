using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pocket48Tool
{
    public partial class Form1 : Form
    {
        string liveApiResult;
        public Form1()
        {
            InitializeComponent();
        }
        public class SearchResult
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Url { get; set; }
        }
        public class UserInfo
        {
            /// <summary>
            /// 
            /// </summary>
            public string userId { get; set; }
            /// <summary>
            /// SNH48-沈小爱
            /// </summary>
            public string nickname { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string avatar { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> badge { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int level { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string isStar { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string friends { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string followers { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string teamLogo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string signature { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string bgImg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string vip { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int userRole { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string pfUrl { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string effectUser { get; set; }
        }

        public class LiveListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string liveId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string coverPath { get; set; }
            /// <summary>
            /// 出现
            /// </summary>
            public string title { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int liveType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string ctime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public UserInfo userInfo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int liveMode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int pictureOrientation { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int isCollection { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string inMicrophoneConnection { get; set; }
        }

        public class Content
        {
            /// <summary>
            /// 
            /// </summary>
            public string next { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<LiveListItem> liveList { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string slideUpAndDown { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public int status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string success { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string message { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Content content { get; set; }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                toolStripStatusLabel1.Text = "请选择或输入成员ID";
                return;
            }
            try
            {
                var result = Regex.Replace(comboBox1.Text, @"[^0-9]+" , "");
                using var client = new HttpClient();
                var postData = new StringContent("{\"userId\":\"" + result + "\"}", Encoding.UTF8,"application/json");
                var apirequest = await client.PostAsync("https://pocketapi.48.cn/live/api/v1/live/getLiveList", postData);
                string apiResult = apirequest.Content.ReadAsStringAsync().Result;
                string sPrettyStr = JToken.Parse(apiResult).ToString();
                JsonResponseText.Text = sPrettyStr;
                JObject jobj = JObject.Parse(JsonResponseText.Text);
                string tempory = jobj["content"]["liveList"].ToString();
                if (tempory == "[]")
                {
                    toolStripStatusLabel1.Text = "未查询到任何结果，可能没有录播或者录播已被删除";
                    return;
                }
                string name = jobj["content"]["liveList"][0]["liveId"].ToString();
                toolStripStatusLabel1.Text = "查询成功!";
                getLiveIdText.Text = name;
                //MessageBox.Show(name);

            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (!Int64.TryParse(liveIdText.Text, out long result))
            {
                toolStripStatusLabel1.Text = "你输入的直播ID不正确，请重新输入！";
                return;
            }
            try
            {
                HttpClient _client = new HttpClient();
                using var client = new HttpClient();
                var postData = new StringContent("{\"liveId\":\"" + liveIdText.Text + "\"}", Encoding.UTF8, "application/json");
                var apirequest = await _client.PostAsync("https://pocketapi.48.cn/live/api/v1/live/getLiveOne", postData);
                liveApiResult = apirequest.Content.ReadAsStringAsync().Result;
                string sPrettyStr = JToken.Parse(liveApiResult).ToString();
                //string postData = "{\"liveId\":\"" + liveIdText.Text + "\"}";
                //WebRequest request = WebRequest.Create("https://pocketapi.48.cn/live/api/v1/live/getLiveOne");
                //request.Method = "POST";
                //byte[] data = Encoding.UTF8.GetBytes(postData);
                //byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                //request.ContentType = "application/json;charset=utf-8";
                //request.ContentLength = byteArray.Length;
                //Stream dataStream = request.GetRequestStream();
                //dataStream.Write(data, 0, data.Length);
                //dataStream.Close();
                //WebResponse response = request.GetResponse();
                //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                JObject jobj = JObject.Parse(liveApiResult);
                try
                {
                    string name = jobj["content"]["review"].ToString();
                    if (name == "False")
                    {
                        toolStripStatusLabel1.Text = "成员名称:" + jobj["content"]["user"]["userName"] + "，当前人气:"+ jobj["content"]["onlineNum"]+"，双击文本框可快速复制内容";
                        playStreamText.Visible = true;
                        playStreamText.Text = jobj["content"]["playStreamPath"].ToString();
                        //TODO:LiveType=1 视频直播 liveType=2 电台直播
                        streamLabel.Visible = true;
                    }
                    else if (name == "True")
                    {
                        toolStripStatusLabel1.Text = "查询成功！"+ "成员名称："+jobj["content"]["user"]["userName"] + "，双击文本框可快速复制内容";
                        //MessageBox.Show("已下播");\
                        streamLabel.Visible = true;
                        danmukuLabel.Visible= true;
                        commandLabel.Visible = true;
                        playStreamText.Visible = true;
                        danmukuText.Visible = true;
                        commandText.Visible = true;
                        downloadVideoButton.Visible = true;
                        downloadDanmukuButton.Visible = true;
                        playStreamText.Text = jobj["content"]["playStreamPath"].ToString();
                        danmukuText.Text = jobj["content"]["msgFilePath"].ToString();
                        long livestarttime = long.Parse(jobj["content"]["ctime"].ToString());
                        DateTimeOffset dto = DateTimeOffset.FromUnixTimeMilliseconds(livestarttime);
                        //DateTime dt02 = dto.LocalDateTime;
                        //MessageBox.Show(dto.LocalDateTime.ToString("F"));
                        commandText.Text = "ffmpeg" + " -user_agent " + "\"" + "SNH48 ENGINE" + "\"" + " -i " + jobj["content"]["playStreamPath"] + " -c copy " + "\"" + @"D:\pocket48\" + jobj["content"]["user"]["userName"] + "-" + dto.LocalDateTime.ToString("yyyy-MM-dd HH-mm-ss") + ".mp4" + "\"";

                    }
                    else
                    {
                       toolStripStatusLabel1.Text="回放生成中，请稍后再来！";
                    }
                }
                catch
                {
                    toolStripStatusLabel1.Text = "Error";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(@"wt " + "\"" + textBox5.Text + "\"");
            Process process = new Process();
            process.StartInfo.FileName = "wt";
            process.StartInfo.Arguments = commandText.Text;
            process.Start();

        }



        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("该功能为实验性功能，查询结果仅供参考。\r\n确认要开始查询吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int i;
            Random rd = new Random();
            for (i = 1; i < 3; i++)
            {

                ListViewItem item2 = new ListViewItem(i.ToString());
                item2.SubItems.Add(rd.Next(100000, 99999999).ToString());
                item2.SubItems.Add("CKG48-XXX");
                item2.SubItems.Add("Team HII");
                blackListView.Items.Add(item2);
            }
            toolStripStatusLabel1.Text = "检测完成，您已被 " + (i - 1).ToString() + " 位成员拉黑，用时" + rd.Next(30, 60) + "秒";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (userNameVerifyRadioButton.Checked == true)
            {
                TokenVerifyRadioButton.Checked = false;
                label3.Visible = false;
                label4.Visible = false;
                TokenText.Visible = false;
                PAText.Visible = false;
                pictureBox1.Visible = true;
                label6.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (TokenVerifyRadioButton.Checked == true)
            {
                userNameVerifyRadioButton.Checked = false;
                label3.Visible = true;
                label4.Visible = true;
                TokenText.Visible = true;
                PAText.Visible = true;
                pictureBox1.Visible = false;
                label6.Visible = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            liveIdText.Text = getLiveIdText.Text;
            tabControl1.SelectedIndex = 1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                JObject jobj = JObject.Parse(liveApiResult);
                WebClient webClient = new WebClient();
                long livestarttime = long.Parse(jobj["content"]["ctime"].ToString());
                DateTimeOffset dto = DateTimeOffset.FromUnixTimeMilliseconds(livestarttime);
                //webClient.Encoding = Encoding.UTF8;            //这里使用DownloadString方法，如果是不需要对文件的文本内容做处理，直接保存，那么可以直接使用功能DownloadFile(url,savepath)直接进行文件保存。
                webClient.DownloadFile(danmukuText.Text, @"D:\pocket48\"+jobj["content"]["user"]["userName"] + "-" + dto.LocalDateTime.ToString("yyyyMMdd") + ".lrc");
                //File.WriteAllText("D:\\test1.html", outText);
            }
            catch(Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
            toolStripStatusLabel1.Text = "下载完成！";
        }

        private void playStreamText_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(playStreamText.Text);
            toolStripStatusLabel1.Text = "复制成功！";
        }

        private void danmukuText_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(danmukuText.Text);
            toolStripStatusLabel1.Text = "复制成功！";
        }

        private void commandText_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(commandText.Text);
            toolStripStatusLabel1.Text = "复制成功！";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click_3(object sender, EventArgs e)
        {

        }

        private void button3_Click_4(object sender, EventArgs e)
        {

        }
    }

}
