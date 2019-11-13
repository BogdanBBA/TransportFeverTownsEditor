namespace TransportFeverTownsEditor
{
	partial class FSelectByRegEx
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
			this.CancelB = new System.Windows.Forms.Button();
			this.SelectB = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.InputTB = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// CancelB
			// 
			this.CancelB.Location = new System.Drawing.Point(140, 56);
			this.CancelB.Name = "CancelB";
			this.CancelB.Size = new System.Drawing.Size(80, 30);
			this.CancelB.TabIndex = 6;
			this.CancelB.Text = "Cancel";
			this.CancelB.UseVisualStyleBackColor = true;
			this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
			// 
			// SelectB
			// 
			this.SelectB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectB.Location = new System.Drawing.Point(54, 56);
			this.SelectB.Name = "SelectB";
			this.SelectB.Size = new System.Drawing.Size(80, 30);
			this.SelectB.TabIndex = 5;
			this.SelectB.Text = "Select";
			this.SelectB.UseVisualStyleBackColor = true;
			this.SelectB.Click += new System.EventHandler(this.SelectB_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "Regulax expression";
			// 
			// textBox1
			// 
			this.InputTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InputTB.Location = new System.Drawing.Point(18, 27);
			this.InputTB.Name = "textBox1";
			this.InputTB.Size = new System.Drawing.Size(245, 23);
			this.InputTB.TabIndex = 8;
			this.InputTB.Text = ".*";
			this.InputTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FSelectByRegEx
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(281, 100);
			this.ControlBox = false;
			this.Controls.Add(this.InputTB);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CancelB);
			this.Controls.Add(this.SelectB);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FSelectByRegEx";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select towns by RegEx";
			this.Load += new System.EventHandler(this.FSelectByRegEx_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CancelB;
		private System.Windows.Forms.Button SelectB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox InputTB;
	}
}