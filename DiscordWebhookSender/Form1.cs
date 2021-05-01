using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Web;
using static System.Net.WebRequestMethods;
using System.IO;

namespace DiscordWebhookSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (txtURL.Text == "" || txtMsg.Text == "")
            {
                MessageBox.Show("Please fill out all fields!");
            }
            else
            {
                sendWebHook(txtURL.Text, txtMsg.Text, txtName.Text);
            }
        }

        public static void sendWebHook(string URL, string msg, string username)
        {


            http.Post(URL, new NameValueCollection()
                {
                {
                    "username",
                    username
                },
                {
                    "content",
                    msg
                }
            });

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.laugny.com/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("lastURL.txt"))
            {
                StreamReader sr = new StreamReader("lastURL.txt");
                txtURL.Text = sr.ReadLine();
            }

        }

        private void btnSaveURL_Click(object sender, EventArgs e)
        {
            if (txtURLName.Text == "")
            {
                MessageBox.Show("Please give a name");
            }
            else
            {
                if (txtURL.Text == "")
                {
                    MessageBox.Show("Please give a URL to save");
                }
                else
                {
                }

                StreamWriter sw = new StreamWriter(txtURLName.Text + " WebhookURL" + ".txt");

                sw.WriteLine(txtURLName.Text + ":" + txtURL.Text);
                sw.Close();

                MessageBox.Show("Save was successful!");

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading function doesnt work properly,\nwait for a new release","information",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("lastURL.txt");

                sw.WriteLine(txtURL.Text);
                sw.Close();
            }
            catch
            {
            }
        }
    }
}

