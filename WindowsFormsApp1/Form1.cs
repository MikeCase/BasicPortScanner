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
using System.Net.Sockets;
using System.Threading;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int startPort;
        static int endPort;

        private List<int> openPorts = new List<int>();

        private int maxQAtOnce = 3000;
        private int awaitingResponses;


        public Form1()
        {
            InitializeComponent();
        }


        // Start the scan. 
        private async void ScanPorts_Click(object sender, EventArgs e)
        {
            portsLst.Items.Clear(); 
            startPort = Convert.ToInt32(this.sportText.Text);
            endPort = Convert.ToInt32(this.eportText.Text);
            var progress = new Progress<int>(value =>
            {
                progressBar1.Value = value;
            });
            // Progress bar setup
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Blocks;
            //progressBar1.Value = 0;

            // Init variable ipAddress
            IPAddress ipAddress;

            // TryParse the text into an IPAddress
            if(!IPAddress.TryParse(IPText.Text, out ipAddress)) {
                return; 
            }

            await Task.Run( () => StartScan(ipAddress, progress));
            //ThreadPool.QueueUserWorkItem(StartScan, ipAddress);
            
        }

        // Clear the textbox and the listbox.
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IPText.Text = null;
            portsLst.Items.Clear();
            
            
        }

        private void update_list_box(int openPort)
        {
            portsLst.BeginUpdate();
            portsLst.Items.Add("Port " + openPort.ToString() + " Open!");
            portsLst.EndUpdate();
           
        }

        // Run the scan...
        private void StartScan(object o, IProgress<int> progress)
        {
            IPAddress ipAddress = o as IPAddress;
            
            // From the startPort to the endPort
            for (int i = startPort; i < endPort+1; i++)
            {

                while (awaitingResponses >= maxQAtOnce)
                {
                    Thread.Sleep(0);
                }
                
                try
                {
                    // Create Socket
                    Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    // Make connection
                    s.BeginConnect(new IPEndPoint(ipAddress, i), EndConnect, s);
                    progress.Report((i * 100) / endPort);
                    IncrementResponses();
                }
                catch (Exception)
                {

                }

            }
        }


        private void EndConnect(IAsyncResult ar)
        {
            
            try
            {
                DecrementResponses();
                Socket s = ar.AsyncState as Socket;
                s.EndConnect(ar);

                if (s.Connected)
                {
                    int openPort = Convert.ToInt32(s.RemoteEndPoint.ToString().Split(':')[1]);
                    portsLst.BeginInvoke((Action)(() => {
                        update_list_box(openPort);
                    }));
                    this.openPorts.Add(openPort);
                    s.Disconnect(true);
                    

                }
            }
            catch (Exception)
            {

            }
        }
        private void IncrementResponses()
        {
            Interlocked.Increment(ref awaitingResponses);
        }
        private void DecrementResponses()
        {
            Interlocked.Decrement(ref awaitingResponses);
        }
    }
}
