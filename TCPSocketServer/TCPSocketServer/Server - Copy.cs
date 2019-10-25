/*
 * Created by SharpDevelop.
 * User: Crogogo
 * Date: 10/6/2019
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net.Sockets;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

using System.Collections;
using System.ComponentModel;


namespace TCPSocketServer
{
	/// <summary>
	/// Description of Server.
	/// </summary>
	public partial class Server : Form
	{
		
		private StreamWriter serverStreamWriter;
		private StreamReader serverStreamReader;
		public static string buffery = "";
		public Server()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			backgroundWorker1.WorkerReportsProgress = true;
			backgroundWorker1.WorkerSupportsCancellation = true;
			InitializeBackgroundWorker();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void InitializeBackgroundWorker()
		{
			backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker1_DoWork);
			backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
			backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
		}
		
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{ 
			BackgroundWorker worker = sender as BackgroundWorker;
			
			/*
			if (!StartServer())
            {
            	Console.WriteLine("Unable to start server");
            	textBox1.Text = "Unable to start server";
            }
            */
			//serverStreamWriter.WriteLine("Hi!"); 
			//    serverStreamWriter.Flush();
			//serverStreamWriter.WriteLine("Hi!");
			//serverStreamWriter.Flush();
			//int iii = 0;
			while (true) {
				if (worker.CancellationPending == true) {
					e.Cancel = true;
					break;
				} 
				else
				{
					serverStreamWriter.WriteLine("Hi! ");// + iii.ToString());
					serverStreamWriter.Flush();
					//iii++;
					//worker.ReportProgress(iii);
				}
			}
			/* 	
            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                	//start server
                	//Console.WriteLine("CLIENT: "+serverStreamReader.ReadLine());
                	serverStreamWriter.WriteLine("Hi!");
                	serverStreamWriter.Flush();
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(10);
                    worker.ReportProgress(i * 10);
                }
            }	
				*/		
		}
		
		// This event handler updates the progress.
		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
		}
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled == true) {
				resultLabel.Text = "Canceled!";
			} else if (e.Error != null) {
				resultLabel.Text = "Error: " + e.Error.Message;
			} else {
				resultLabel.Text = "Done!";
				richTextBox1.Text = " DONE ";
			}
		}
		
		private bool StartServer()
		{
			//create server's tcp listener for incoming connection
			TcpListener tcpServerListener = new TcpListener(4444);
			tcpServerListener.Start();        //start server
			Console.WriteLine("Server Started");
			this.btnStartServer.Enabled = false;
			//block tcplistener to accept incoming connection
			Socket serverSocket = tcpServerListener.AcceptSocket();
 
			try {
				if (serverSocket.Connected) {
					Console.WriteLine("Client connected");
					//open network stream on accepted socket
					NetworkStream serverSockStream = 
						new NetworkStream(serverSocket);
					serverStreamWriter = new StreamWriter(serverSockStream);
					serverStreamReader = new StreamReader(serverSockStream);
				}
			} catch (Exception e) {
				Console.WriteLine(e.StackTrace); 
				return false;
			}
 
			return true;
		}
		
		void BtnStartServerClick(object sender, EventArgs e)
		{
			
			

			//start server
			
			if (!StartServer()) {
				Console.WriteLine("Unable to start server");
				textBox1.Text = "Unable to start server";
			}
            
			//buffery = buffery + "\n" + " " + serverStreamReader.ReadLine();
			/*
           //sending n receiving msgs
            while (true)
            {
                //Console.WriteLine("CLIENT: "+serverStreamReader.ReadLine());
                var messageGot = serverStreamReader.ReadLine();
                richTextBox1.Text = richTextBox1.Text + "\n" + " " + messageGot;
                serverStreamWriter.WriteLine("Hi! " + messageGot); 
                serverStreamWriter.Flush();
            }
            */
            
 			
           
			if (backgroundWorker1.IsBusy != true) {
				// Start the asynchronous operation.
				backgroundWorker1.RunWorkerAsync();
			}
                
 
            
		}
		void CancelAsyncButtonClick(object sender, EventArgs e)
		{
			if (backgroundWorker1.WorkerSupportsCancellation == true) {                // Cancel the asynchronous operation.
				backgroundWorker1.CancelAsync();
			}
			richTextBox1.Text = richTextBox1.Text + "\n" + " " + buffery;
			buffery = "";
		}
	}
}
