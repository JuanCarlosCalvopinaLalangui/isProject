using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Mosquito_Example1
{
    public partial class Form1 : Form
    {
        MqttClient broker;
        string[] topics = { "news", "complaints" };
        byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };
        string guid;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource =topics;
            guid = Guid.NewGuid().ToString();
            broker = new MqttClient("192.168.1.90");
           // broker = new MqttClient("10.20.133.179");
            broker.Connect(guid);
            if (!broker.IsConnected)
            {
                MessageBox.Show("No conecto al broker");
                return;
            }

            broker.MqttMsgPublishReceived += Broker_MqttMsgPublishReceived;
            broker.Subscribe(topics, qosLevels);
        }

        public void Broker_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string msg = Encoding.UTF8.GetString(e.Message);
            // MessageBox.Show($"Received: {msg} no topic: {e.Topic} ");
            this.Invoke((MethodInvoker)delegate {
                richTextBox1.AppendText($"Received: {msg} \" no topic: {e.Topic} \n ");
            }
                );
            
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            if (broker.IsConnected)
            {
                //byte[] msg = Encoding.UTF8.GetBytes($"Ola! bebesita {guid}");
                //broker.Publish(topics[0],msg);
                
                string[] separatingStrings = { ",", "=" };

                string text = textBox1.Text.ToString();
                System.Console.WriteLine($"Original text: '{text}'");

                string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                System.Console.WriteLine($"{words.Length} substrings in text:");

                string JSONResult;
                //Console.WriteLine("{");
                foreach (var word in words)
                {
                    JSONResult = JsonConvert.SerializeObject(new { chat = word },Formatting.Indented);
                    Console.WriteLine(JSONResult);
                    //System.Console.WriteLine(word);
                    broker.Publish(comboBox1.SelectedItem.ToString(),UTF8Encoding.UTF8.GetBytes(JSONResult));
                    

                }
               // Console.WriteLine("},");

                textBox1.Text = " ";
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (broker.IsConnected)
            {
                broker.Unsubscribe(topics);
                broker.Disconnect();
            }
        }

        private void buttonUnSubcribes_Click(object sender, EventArgs e)
        {
            if (broker.IsConnected)
            {
                broker.Unsubscribe(topics); //Put this in a button to see notif!
                broker.Disconnect(); //Free process and process's resources
            }

        }
    }
}
