/*
 * Created by SharpDevelop.
 * User: Crogogo
 * Date: 10/6/2019
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TCPSocketServer
{
	partial class Server
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnStartServer;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox resultLabel;
		private System.Windows.Forms.Button cancelAsyncButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnStartServer = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.resultLabel = new System.Windows.Forms.TextBox();
			this.cancelAsyncButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStartServer
			// 
			this.btnStartServer.Location = new System.Drawing.Point(12, 238);
			this.btnStartServer.Name = "btnStartServer";
			this.btnStartServer.Size = new System.Drawing.Size(75, 23);
			this.btnStartServer.TabIndex = 0;
			this.btnStartServer.Text = "Start Server";
			this.btnStartServer.UseVisualStyleBackColor = true;
			this.btnStartServer.Click += new System.EventHandler(this.BtnStartServerClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(93, 238);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(268, 220);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// resultLabel
			// 
			this.resultLabel.Location = new System.Drawing.Point(12, 266);
			this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(181, 20);
			this.resultLabel.TabIndex = 3;
			// 
			// cancelAsyncButton
			// 
			this.cancelAsyncButton.Location = new System.Drawing.Point(12, 287);
			this.cancelAsyncButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cancelAsyncButton.Name = "cancelAsyncButton";
			this.cancelAsyncButton.Size = new System.Drawing.Size(63, 24);
			this.cancelAsyncButton.TabIndex = 4;
			this.cancelAsyncButton.Text = "Cancel";
			this.cancelAsyncButton.UseVisualStyleBackColor = true;
			this.cancelAsyncButton.Click += new System.EventHandler(this.CancelAsyncButtonClick);
			// 
			// Server
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 371);
			this.Controls.Add(this.cancelAsyncButton);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnStartServer);
			this.Name = "Server";
			this.Text = "Server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
