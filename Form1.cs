using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        public class MessageReadyArgs : EventArgs
        {
            public string Message { get; set; }
        }
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
                OnMessageReady(textBox1.Text);
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(this, EventArgs.Empty);
        }

        public event EventHandler<MessageReadyArgs> MessageReady;
        protected virtual void OnMessageReady(string message)
        {
            MessageReady?.Invoke(this, new MessageReadyArgs() { Message = message });
        }

        public void OnSubscribed(object source, Receiver.SubscribedEventArgs args)
        {
            if (args.Subscribed)
                MessageReady += args.Receiver.OnMessageReady;
            else MessageReady -= args.Receiver.OnMessageReady;
        }
    }

}

