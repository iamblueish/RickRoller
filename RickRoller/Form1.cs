using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;


namespace RickRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            initalized = true;
            client = new DiscordRpcClient($"782687570349785109");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();


            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = $"I just got rick rolled",
                State = $"Never gonna give you up",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = $"wide",
                    LargeImageText = "i am dumb",
                    SmallImageKey = $"close",
                    SmallImageText = $"developed by blueish."
                }
            });
        }

        public DiscordRpcClient client;
        bool initalized = false;



        private void Form_Load(object sender, EventArgs e)
        {
           
        }
    }
}


