namespace TransportFeverTownsEditor
{
	partial class FChangeSizeFactor
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
			this.FixedValueRB = new System.Windows.Forms.RadioButton();
			this.MultiplyRB = new System.Windows.Forms.RadioButton();
			this.NUD = new System.Windows.Forms.NumericUpDown();
			this.ChangeB = new System.Windows.Forms.Button();
			this.CancelB = new System.Windows.Forms.Button();
			this.InfoL = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.NUD)).BeginInit();
			this.SuspendLayout();
			// 
			// FixedValueRB
			// 
			this.FixedValueRB.AutoSize = true;
			this.FixedValueRB.Checked = true;
			this.FixedValueRB.Location = new System.Drawing.Point(12, 12);
			this.FixedValueRB.Name = "FixedValueRB";
			this.FixedValueRB.Size = new System.Drawing.Size(114, 19);
			this.FixedValueRB.TabIndex = 0;
			this.FixedValueRB.TabStop = true;
			this.FixedValueRB.Text = "Set to fixed value";
			this.FixedValueRB.UseVisualStyleBackColor = true;
			this.FixedValueRB.CheckedChanged += new System.EventHandler(this.FixedValueRB_CheckedChanged);
			// 
			// MultiplyRB
			// 
			this.MultiplyRB.AutoSize = true;
			this.MultiplyRB.Location = new System.Drawing.Point(12, 37);
			this.MultiplyRB.Name = "MultiplyRB";
			this.MultiplyRB.Size = new System.Drawing.Size(116, 19);
			this.MultiplyRB.TabIndex = 1;
			this.MultiplyRB.Text = "Multiply by value";
			this.MultiplyRB.UseVisualStyleBackColor = true;
			this.MultiplyRB.CheckedChanged += new System.EventHandler(this.MultiplyRB_CheckedChanged);
			// 
			// numericUpDown1
			// 
			this.NUD.DecimalPlaces = 1;
			this.NUD.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.NUD.Location = new System.Drawing.Point(62, 62);
			this.NUD.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.NUD.Name = "numericUpDown1";
			this.NUD.Size = new System.Drawing.Size(120, 27);
			this.NUD.TabIndex = 2;
			this.NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NUD.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// ChangeB
			// 
			this.ChangeB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangeB.Location = new System.Drawing.Point(46, 110);
			this.ChangeB.Name = "ChangeB";
			this.ChangeB.Size = new System.Drawing.Size(80, 30);
			this.ChangeB.TabIndex = 3;
			this.ChangeB.Text = "Change";
			this.ChangeB.UseVisualStyleBackColor = true;
			this.ChangeB.Click += new System.EventHandler(this.ChangeB_Click);
			// 
			// CancelB
			// 
			this.CancelB.Location = new System.Drawing.Point(132, 110);
			this.CancelB.Name = "CancelB";
			this.CancelB.Size = new System.Drawing.Size(80, 30);
			this.CancelB.TabIndex = 4;
			this.CancelB.Text = "Cancel";
			this.CancelB.UseVisualStyleBackColor = true;
			this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
			// 
			// InfoL
			// 
			this.InfoL.AutoSize = true;
			this.InfoL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InfoL.ForeColor = System.Drawing.Color.DimGray;
			this.InfoL.Location = new System.Drawing.Point(9, 143);
			this.InfoL.Name = "InfoL";
			this.InfoL.Size = new System.Drawing.Size(211, 13);
			this.InfoL.TabIndex = 5;
			this.InfoL.Text = "End result is limited to the interval [0.0, 2.0]";
			// 
			// FChangeSizeFactor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(259, 166);
			this.ControlBox = false;
			this.Controls.Add(this.InfoL);
			this.Controls.Add(this.CancelB);
			this.Controls.Add(this.ChangeB);
			this.Controls.Add(this.NUD);
			this.Controls.Add(this.MultiplyRB);
			this.Controls.Add(this.FixedValueRB);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FChangeSizeFactor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Change size factor for selected towns";
			this.Load += new System.EventHandler(this.FChangeSizeFactor_Load);
			((System.ComponentModel.ISupportInitialize)(this.NUD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton FixedValueRB;
		private System.Windows.Forms.RadioButton MultiplyRB;
		private System.Windows.Forms.NumericUpDown NUD;
		private System.Windows.Forms.Button ChangeB;
		private System.Windows.Forms.Button CancelB;
		private System.Windows.Forms.Label InfoL;
	}
}