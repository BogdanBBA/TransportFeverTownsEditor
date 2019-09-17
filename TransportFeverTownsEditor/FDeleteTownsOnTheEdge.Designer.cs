namespace TransportFeverTownsEditor
{
	partial class FDeleteTownsOnTheEdge
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.NUD_W = new System.Windows.Forms.NumericUpDown();
			this.NUD_H = new System.Windows.Forms.NumericUpDown();
			this.NUD_E = new System.Windows.Forms.NumericUpDown();
			this.CancelB = new System.Windows.Forms.Button();
			this.DeleteB = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.NUD_W)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NUD_H)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NUD_E)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Specify the map size (see heightmap.png):";
			// 
			// NUD_W
			// 
			this.NUD_W.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NUD_W.Location = new System.Drawing.Point(12, 27);
			this.NUD_W.Maximum = new decimal(new int[] {
            16385,
            0,
            0,
            0});
			this.NUD_W.Name = "NUD_W";
			this.NUD_W.Size = new System.Drawing.Size(120, 27);
			this.NUD_W.TabIndex = 3;
			this.NUD_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NUD_W.ThousandsSeparator = true;
			this.NUD_W.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.NUD_W.Value = new decimal(new int[] {
            3073,
            0,
            0,
            0});
			// 
			// NUD_H
			// 
			this.NUD_H.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NUD_H.Location = new System.Drawing.Point(156, 27);
			this.NUD_H.Maximum = new decimal(new int[] {
            16385,
            0,
            0,
            0});
			this.NUD_H.Name = "NUD_H";
			this.NUD_H.Size = new System.Drawing.Size(120, 27);
			this.NUD_H.TabIndex = 4;
			this.NUD_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NUD_H.ThousandsSeparator = true;
			this.NUD_H.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.NUD_H.Value = new decimal(new int[] {
            3073,
            0,
            0,
            0});
			// 
			// NUD_E
			// 
			this.NUD_E.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NUD_E.Location = new System.Drawing.Point(12, 85);
			this.NUD_E.Maximum = new decimal(new int[] {
            16385,
            0,
            0,
            0});
			this.NUD_E.Name = "NUD_E";
			this.NUD_E.Size = new System.Drawing.Size(120, 27);
			this.NUD_E.TabIndex = 5;
			this.NUD_E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NUD_E.ThousandsSeparator = true;
			this.NUD_E.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.NUD_E.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// CancelB
			// 
			this.CancelB.Location = new System.Drawing.Point(147, 133);
			this.CancelB.Name = "CancelB";
			this.CancelB.Size = new System.Drawing.Size(80, 30);
			this.CancelB.TabIndex = 7;
			this.CancelB.Text = "Cancel";
			this.CancelB.UseVisualStyleBackColor = true;
			this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
			// 
			// DeleteB
			// 
			this.DeleteB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteB.Location = new System.Drawing.Point(61, 133);
			this.DeleteB.Name = "DeleteB";
			this.DeleteB.Size = new System.Drawing.Size(80, 30);
			this.DeleteB.TabIndex = 6;
			this.DeleteB.Text = "Delete";
			this.DeleteB.UseVisualStyleBackColor = true;
			this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(138, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "x";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(244, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Delete towns located closer to the edge than:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(138, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "pixels";
			// 
			// FDeleteTownsOnTheEdge
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(289, 184);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CancelB);
			this.Controls.Add(this.DeleteB);
			this.Controls.Add(this.NUD_E);
			this.Controls.Add(this.NUD_H);
			this.Controls.Add(this.NUD_W);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FDeleteTownsOnTheEdge";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete towns on the edge";
			this.Load += new System.EventHandler(this.FDeleteTownsOnTheEdge_Load);
			((System.ComponentModel.ISupportInitialize)(this.NUD_W)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NUD_H)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NUD_E)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown NUD_W;
		private System.Windows.Forms.NumericUpDown NUD_H;
		private System.Windows.Forms.NumericUpDown NUD_E;
		private System.Windows.Forms.Button CancelB;
		private System.Windows.Forms.Button DeleteB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}