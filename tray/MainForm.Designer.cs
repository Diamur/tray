/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 07.01.2016
 * Time: 20:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tray
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tb_Content;
		private System.Windows.Forms.Button b_Copy;
		private System.Windows.Forms.Button b_Clear;
		private System.Windows.Forms.NotifyIcon ni_Tray;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_AddSymbol;
		private System.Windows.Forms.TextBox tb_NumLine;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel tssl_SymbolCount;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel tssl_LineCount;
		
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
			this.components = new System.ComponentModel.Container();
			this.tb_Content = new System.Windows.Forms.TextBox();
			this.b_Copy = new System.Windows.Forms.Button();
			this.b_Clear = new System.Windows.Forms.Button();
			this.ni_Tray = new System.Windows.Forms.NotifyIcon(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.tb_AddSymbol = new System.Windows.Forms.TextBox();
			this.tb_NumLine = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssl_SymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssl_LineCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_Content
			// 
			this.tb_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Content.Location = new System.Drawing.Point(53, 12);
			this.tb_Content.MaxLength = 100000;
			this.tb_Content.Multiline = true;
			this.tb_Content.Name = "tb_Content";
			this.tb_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_Content.Size = new System.Drawing.Size(615, 299);
			this.tb_Content.TabIndex = 0;
			this.tb_Content.TextChanged += new System.EventHandler(this.Tb_ContentTextChanged);
			// 
			// b_Copy
			// 
			this.b_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.b_Copy.Location = new System.Drawing.Point(593, 317);
			this.b_Copy.Name = "b_Copy";
			this.b_Copy.Size = new System.Drawing.Size(75, 23);
			this.b_Copy.TabIndex = 1;
			this.b_Copy.Text = "Копировать";
			this.b_Copy.UseVisualStyleBackColor = true;
			this.b_Copy.Click += new System.EventHandler(this.B_CopyClick);
			// 
			// b_Clear
			// 
			this.b_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.b_Clear.Location = new System.Drawing.Point(512, 317);
			this.b_Clear.Name = "b_Clear";
			this.b_Clear.Size = new System.Drawing.Size(75, 23);
			this.b_Clear.TabIndex = 1;
			this.b_Clear.Text = "Очистить";
			this.b_Clear.UseVisualStyleBackColor = true;
			this.b_Clear.Click += new System.EventHandler(this.B_ClearClick);
			// 
			// ni_Tray
			// 
			this.ni_Tray.Text = "Буфер Обмена";
			this.ni_Tray.Visible = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Location = new System.Drawing.Point(12, 320);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Добавить:";
			// 
			// tb_AddSymbol
			// 
			this.tb_AddSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_AddSymbol.Location = new System.Drawing.Point(83, 317);
			this.tb_AddSymbol.Name = "tb_AddSymbol";
			this.tb_AddSymbol.Size = new System.Drawing.Size(26, 20);
			this.tb_AddSymbol.TabIndex = 3;
			this.tb_AddSymbol.Text = ";";
			// 
			// tb_NumLine
			// 
			this.tb_NumLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.tb_NumLine.Enabled = false;
			this.tb_NumLine.Location = new System.Drawing.Point(21, 12);
			this.tb_NumLine.MaxLength = 100000;
			this.tb_NumLine.Multiline = true;
			this.tb_NumLine.Name = "tb_NumLine";
			this.tb_NumLine.Size = new System.Drawing.Size(33, 299);
			this.tb_NumLine.TabIndex = 0;
			this.tb_NumLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1,
			this.tssl_SymbolCount,
			this.toolStripStatusLabel2,
			this.tssl_LineCount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 340);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(680, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
			this.toolStripStatusLabel1.Text = "Кол-во симв.:";
			// 
			// tssl_SymbolCount
			// 
			this.tssl_SymbolCount.Name = "tssl_SymbolCount";
			this.tssl_SymbolCount.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(83, 17);
			this.toolStripStatusLabel2.Text = "Кол-во строк:";
			// 
			// tssl_LineCount
			// 
			this.tssl_LineCount.Name = "tssl_LineCount";
			this.tssl_LineCount.Size = new System.Drawing.Size(0, 17);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 362);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tb_AddSymbol);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.b_Clear);
			this.Controls.Add(this.b_Copy);
			this.Controls.Add(this.tb_NumLine);
			this.Controls.Add(this.tb_Content);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Накопитель Текста 1.0";
			this.TopMost = true;
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
