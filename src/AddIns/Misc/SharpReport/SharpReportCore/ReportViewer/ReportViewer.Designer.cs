﻿/*
 * Created by SharpDevelop.
 * User: Forstmeier Helmut
 * Date: 16.10.2006
 * Time: 22:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SharpReportCore.ReportViewer
{
	partial class PreviewControl : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewControl));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.BackButton = new System.Windows.Forms.ToolStripButton();
			this.ForwardButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.panel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.AutoScrollMargin = new System.Drawing.Size(5, 5);
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(5, 33);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(5);
			this.panel1.Size = new System.Drawing.Size(525, 373);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Location = new System.Drawing.Point(5, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(496, 500);
			this.panel2.TabIndex = 0;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.BackButton,
									this.ForwardButton,
									this.toolStripSeparator1,
									this.toolStripTextBox1,
									this.toolStripSeparator2,
									this.toolStripComboBox1,
									this.printToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(5, 5);
			this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(520, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// BackButton
			// 
			this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
			this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(23, 22);
			this.BackButton.Text = "&Back";
			this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
			// 
			// ForwardButton
			// 
			this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
			this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ForwardButton.Name = "ForwardButton";
			this.ForwardButton.Size = new System.Drawing.Size(23, 22);
			this.ForwardButton.Text = "&Forward";
			this.ForwardButton.Click += new System.EventHandler(this.ForwardButtonClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(150, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(80, 25);
			this.toolStripComboBox1.ToolTipText = "Zoom";
			this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBox1SelectedIndexChanged);
			// 
			// printToolStripButton
			// 
			this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
			this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripButton.Name = "printToolStripButton";
			this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.printToolStripButton.Text = "&Print";
			this.printToolStripButton.Click += new System.EventHandler(this.PrintButton);
			// 
			// PreviewControl
			// 
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.panel1);
			this.Name = "PreviewControl";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Size = new System.Drawing.Size(530, 411);
			this.panel1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton ForwardButton;
		private System.Windows.Forms.ToolStripButton printToolStripButton;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton BackButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		
		
		
	
		
		void PrintToolStripButtonClick(object sender, System.EventArgs e)
		{
			
		}
		
		
	}
}
