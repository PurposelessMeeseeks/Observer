using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Receiver : UserControl
    {
        public class SubscribedEventArgs : EventArgs
        {
            public bool Subscribed { get; set; }
        }

        public Receiver()
        {
            InitializeComponent();
        }

        public void OnMessageReady(object source, Form1.MessageReadyArgs arg)
        {
            listBox1.Items.Insert(0, arg.Message);
        }

        public event EventHandler<SubscribedEventArgs> Subscribed;

        protected virtual void OnSubscribed(bool subscribed)
        {
            Subscribed?.Invoke(this, new SubscribedEventArgs() { Subscribed = subscribed});
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           OnSubscribed(checkBox1.Checked);
        }
    }
}
