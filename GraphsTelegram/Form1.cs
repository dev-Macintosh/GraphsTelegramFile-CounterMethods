using System;
using System.Threading;
using System.Runtime.InteropServices;
using Timer = System.Threading.Timer;
using TL;
using WTelegram;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphsTelegram
{
    public partial class Form1 : Form
    {
        public static volatile int mb = 0;
        private static volatile WTelegram.Client clientTl = null;
        public Form1()
        {
            AllocConsole();
            InitializeComponent();
            connectTelegram();
            chartDraw();
        }
        private void chartDraw()
        {
            Timer timer = new Timer(new TimerCallback(setPoint), null, 0, 2000);
        }
        private void button_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Привет");
        }
        private protected void setPoint(object obj)
        {
            this.chart.Series[0].Points.Add(mb);
            mb += 50;
        }
        static string Config(string what)
        {
            switch (what)
            {
                case "api_id": return "26679494";
                case "api_hash": return "84be23100108e4be0d9b0888a311a70a";
                case "phone_number": return "+79182137786";
                case "verification_code": Console.Write("Code: "); return Console.ReadLine();
                case "first_name": return "Daniil";
                case "last_name": return "Korepanov";
                case "password": return "ivan2005red";
                default: return null;
            }
        }
        static async Task connectTelegram()
        {
            const int TargetChatId = 1640319957;
            clientTl = new WTelegram.Client(Config);
            var myself = await clientTl.LoginUserIfNeeded();
            var chats = await clientTl.Messages_GetAllChats();
            InputPeer peer = chats.chats.First(chat => chat.Value.ID == TargetChatId).Value.ToInputPeer();
            for (int offset = 0; ;)
            {
                var messagesBase = await clientTl.Messages_GetHistory(peer, 0, default, offset, 1000, 0, 0, 0);
                if (messagesBase is not Messages_ChannelMessages channelMessages) break;
                foreach (var msgBase in channelMessages.messages.OrderByDescending(m => m.Date))
                    if (msgBase is TL.Message msg)
                    {
//                        Console.WriteLine(msgBase.Date.ToLocalTime());
                    }
                offset += channelMessages.messages.Length;
                if (offset >= channelMessages.count) break;
            }


        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

    }

}