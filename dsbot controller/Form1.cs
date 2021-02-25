using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace dsbot_controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ad = new ADform();
            ad.ShowDialog();
            ad.Dispose();
            button2.Enabled = false;
            Banbutton.Enabled = false;
            Kickbutton.Enabled = false;
            button3.Enabled = false;
            Activitybutton.Enabled = false;
        }
        private static string botid { get; set; }
        public int dataerror = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            botid = textBox1.Text.Trim();
            botid = Regex.Replace(botid, @"\s+", "");
            try
            {
                Task.Factory.StartNew(() =>
                {
                    BotLoader.Start(botid);
                });
                do
                {
                    Thread.Sleep(1000);
                } while (BotLoader.isready==false);
                Thread.Sleep(1000);
                try
                {
                    foreach (var server in BotLoader._client.Guilds)
                    {
                        listBox1.Items.Add(server);

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Возникла ошибка но видимо разраб учел это и вывел сюда сообщение :)", "Опа!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    foreach (var server in BotLoader._client.Guilds)
                    {
                        listBox1.Items.Add(server);

                    }
                }


                button1.Enabled = false;
                button2.Enabled = true;
                Banbutton.Enabled = true;
                Kickbutton.Enabled = true;
                button3.Enabled = true;
                Activitybutton.Enabled = true;

                if (BotLoader._client.CurrentUser != null)
                {
                    Botname.Text = BotLoader._client.CurrentUser.Username + "#" + BotLoader._client.CurrentUser.Discriminator;
                    BStatuslabel.Text += BotLoader._client.CurrentUser.Status;
                    SCountlabel.Text += BotLoader._client.Guilds.Count;

                    if (BotLoader._client.Activity != null)
                    {
                        Activitylabel.Text += BotLoader._client.Activity;
                    }
                    var url = BotLoader._client.CurrentUser.GetAvatarUrl() ?? BotLoader._client.CurrentUser.GetDefaultAvatarUrl();
                    var request = WebRequest.Create(url);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                    }
                }
            }
            catch (Exception exp)
            {
                check();
                MessageBox.Show((BotLoader._client == null).ToString() +" "+ (BotLoader._client.CurrentUser == null).ToString(), "Checked");
                MessageBox.Show("Произошла неизвестная ошибка, если данное сообщение выведеться снова то обратитесь к разработчику:" + exp.Message + "\nОбъект:" + exp.Source + "|" + exp.TargetSite, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex == -1)
            {
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                return;
            }
            listBox2.Items.Clear();
            foreach (var channel in BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels)
            {
                listBox2.Items.Add(channel);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                check();
                MessageBox.Show("Выбери чат", "Помилка",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray()[listBox2.SelectedIndex].SendMessageAsync(richTextBox1.Text);
                loadchatAsync();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка отправки сообщения:" + exp.Message + "\nОбъект:" + exp.Source, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check();
            }

        }

        void loadchatAsync()
        {
            if (listBox2.SelectedIndex > -1)
            {
                
                dataGridView1.Rows.Clear();
                listBox3.Items.Clear();
                var chat = BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray()[listBox2.SelectedIndex].GetMessagesAsync(Convert.ToInt32(Msgupd.Value)).ToListAsync().Result;
                foreach (var item in chat)
                {
                    foreach (var item2 in item)
                    {
                        dataGridView1.Rows.Add(item2.Author.Username,item2.Content);
                    }
                }
                foreach (var item in BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray()[listBox2.SelectedIndex].Users.ToList())
                {
                    listBox3.Items.Add(item);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadchatAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadchatAsync();
        }

        private void Banbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BanCB.Checked)
                {
                    BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray()[listBox2.SelectedIndex].GetUser(BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].Users.ToArray()[listBox3.SelectedIndex].Id).BanAsync(0, BanKickTB.Text);
                    BanCB.Checked = false;
                }
                else
                {
                    MessageBox.Show("Поставь галочку для подтверждения бана", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp)
            {
                check();
                MessageBox.Show("Данные для бана введены не верно:"+exp.Message+"\nОбъект:" + exp.Source, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Kickbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BanCB.Checked)
                {
                    BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray()[listBox2.SelectedIndex].GetUser(BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].Users.ToArray()[listBox3.SelectedIndex].Id).KickAsync(BanKickTB.Text);
                    BanCB.Checked = false;
                }
                else
                {
                    MessageBox.Show("Поставь галочку для подтверждения кика", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp)
            {
                check();
                MessageBox.Show("Данные для кика введены не верно:" + exp.Message+"\nОбъект:" + exp.Source, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void check()
        {
            dataerror++;
            if (dataerror >= 6)
            {
                MessageBox.Show("Ты как вообще программу запустил раз не можешь нормально данные вводить, удали её и не запускай до тех пор пока не научишься долбоеб, нахуй иди короче","Ты че дебил?",MessageBoxButtons.OK,MessageBoxIcon.Information);
                System.Environment.Exit(0);
            }
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox3.SelectedIndex == -1)
            {
                return;
            }
            Mentionlabel.Text = BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].Users.ToArray()[listBox3.SelectedIndex].Mention;
        }

        private void Mentionlabel_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Mentionlabel.Text;
        }

        private void Activitybutton_Click(object sender, EventArgs e)
        {
            try
            {

                BotLoader._client.SetGameAsync(ActivityTB.Text);
                if (BotLoader._client.Activity != null)
                {
                    Activitylabel.Text = "Активность: " + BotLoader._client.Activity.ToString();
                }
            }
            catch (Exception exp)
            {
                check();
                MessageBox.Show("Данные для активности введены не верно:" + exp.Message+"\nОбъект:" + exp.Source, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();

            if (radioButton1.Checked) 
            {
                for (int i = 0; i < BotLoader._client.Guilds.ToArray().Length; i++)
                {
                    if (BotLoader._client.Guilds.ToArray()[i].Name.Contains(findTB.Text))
                    {
                        listBox4.Items.Add(BotLoader._client.Guilds.ToArray()[i]);
                    }
                }
            }
            else if (radioButton2.Checked) 
            {
                if (listBox1.SelectedIndex != -1)
                {
                    for (int i = 0; i < BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray().Length; i++)
                    {
                        if (BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray()[i].Name.Contains(findTB.Text))
                        {
                            listBox4.Items.Add(BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray()[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Для поиска канала выберите сервер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (radioButton3.Checked) 
            {
                if (listBox2.SelectedIndex != -1)
                {
                    for (int i = 0; i < BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray()[listBox2.SelectedIndex].Users.ToArray().Length; i++)
                    {
                        if (BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray()[listBox2.SelectedIndex].Users.ToArray()[i].Username.Contains(findTB.Text))
                        {
                            listBox4.Items.Add(BotLoader._client.Guilds.ToArray()[listBox1.SelectedIndex].TextChannels.ToArray()[listBox2.SelectedIndex].Users.ToArray()[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Для поиска пользователя выберите канал", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Область поиска не выбрана","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                foreach (var guild in BotLoader._client.Guilds.ToList())
                {
                    if (listBox4.SelectedItems.Contains(guild))
                    {
                        listBox2.Items.Clear();
                        foreach (var channel in guild.TextChannels)
                        {
                            listBox2.Items.Add(channel);
                        }
                    }
                }
            }
            if (radioButton2.Checked)
            {
                foreach (var channel in BotLoader._client.Guilds.ToArray()[listBox2.SelectedIndex].TextChannels.ToList())
                {
                    if (listBox4.SelectedItems.Contains(channel))
                    {
                        listBox3.Items.Clear();
                        foreach (var user in channel.Users)
                        {
                            listBox3.Items.Add(user);
                        }
                    }
                }
            }
        }
    }
}
