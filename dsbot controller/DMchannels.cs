using Discord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsbot_controller
{
    public partial class DMchannels : Form
    {
        public DMchannels()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            foreach (var item in BotLoader._client.DMChannels)
            {
                foreach (var item2 in item.Users)
                {
                    if (item2.IsBot != true)
                    {
                        listBox1.Items.Add(item2);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var msg = BotLoader._client.DMChannels.ToArray()[listBox1.SelectedIndex].GetMessagesAsync(100).ToListAsync().Result;
            dataGridView1.Rows.Clear();
            foreach (var item in msg)
            {
                foreach (var content in item)
                {
                    dataGridView1.Rows.Add(content.Author.Username, content.Content);
                }
            }
        }

    }
}
