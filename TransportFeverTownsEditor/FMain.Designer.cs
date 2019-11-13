namespace TransportFeverTownsEditor
{
	partial class FMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteSelectedTownsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteTownsOnTheEdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.changeSizeFactorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.OpenedFileL = new System.Windows.Forms.Label();
			this.DGV = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeFactorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DGVSource = new System.Windows.Forms.BindingSource(this.components);
			this.StatusL = new System.Windows.Forms.Label();
			this.selectByRegExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGVSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitApplicationToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
			// 
			// exitApplicationToolStripMenuItem
			// 
			this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
			this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.exitApplicationToolStripMenuItem.Text = "Exit application";
			this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.ExitApplicationToolStripMenuItem_Click);
			// 
			// operationsToolStripMenuItem
			// 
			this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.selectNoneToolStripMenuItem,
            this.selectByRegExToolStripMenuItem,
            this.invertSelectionToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteSelectedTownsToolStripMenuItem,
            this.deleteTownsOnTheEdgeToolStripMenuItem,
            this.toolStripSeparator3,
            this.changeSizeFactorToolStripMenuItem});
			this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
			this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.operationsToolStripMenuItem.Text = "Operations";
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.selectAllToolStripMenuItem.Text = "Select all";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
			// 
			// selectNoneToolStripMenuItem
			// 
			this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
			this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.selectNoneToolStripMenuItem.Text = "Select none";
			this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.SelectNoneToolStripMenuItem_Click);
			// 
			// invertSelectionToolStripMenuItem
			// 
			this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
			this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.invertSelectionToolStripMenuItem.Text = "Invert selection";
			this.invertSelectionToolStripMenuItem.Click += new System.EventHandler(this.InvertSelectionToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
			// 
			// deleteSelectedTownsToolStripMenuItem
			// 
			this.deleteSelectedTownsToolStripMenuItem.Name = "deleteSelectedTownsToolStripMenuItem";
			this.deleteSelectedTownsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteSelectedTownsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.deleteSelectedTownsToolStripMenuItem.Text = "Delete selected towns";
			this.deleteSelectedTownsToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedTownsToolStripMenuItem_Click);
			// 
			// deleteTownsOnTheEdgeToolStripMenuItem
			// 
			this.deleteTownsOnTheEdgeToolStripMenuItem.Name = "deleteTownsOnTheEdgeToolStripMenuItem";
			this.deleteTownsOnTheEdgeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.deleteTownsOnTheEdgeToolStripMenuItem.Text = "Delete towns on the edge";
			this.deleteTownsOnTheEdgeToolStripMenuItem.Click += new System.EventHandler(this.DeleteTownsOnTheEdgeToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
			// 
			// changeSizeFactorToolStripMenuItem
			// 
			this.changeSizeFactorToolStripMenuItem.Name = "changeSizeFactorToolStripMenuItem";
			this.changeSizeFactorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.changeSizeFactorToolStripMenuItem.Text = "Change size factor";
			this.changeSizeFactorToolStripMenuItem.Click += new System.EventHandler(this.ChangeSizeFactorToolStripMenuItem_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "*.lua";
			this.openFileDialog.FileName = "map.lua";
			this.openFileDialog.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\workshop\\content\\446800\\1687040299\\maps\\Wi" +
    "en";
			this.openFileDialog.Title = "Open desired map.lua file";
			// 
			// OpenedFileL
			// 
			this.OpenedFileL.AutoSize = true;
			this.OpenedFileL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OpenedFileL.Location = new System.Drawing.Point(12, 24);
			this.OpenedFileL.Name = "OpenedFileL";
			this.OpenedFileL.Size = new System.Drawing.Size(122, 21);
			this.OpenedFileL.TabIndex = 1;
			this.OpenedFileL.Text = "Opened file: ---";
			// 
			// DGV
			// 
			this.DGV.AllowUserToOrderColumns = true;
			this.DGV.AutoGenerateColumns = false;
			this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sizeFactorDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
			this.DGV.DataSource = this.DGVSource;
			this.DGV.Location = new System.Drawing.Point(16, 48);
			this.DGV.Name = "DGV";
			this.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV.Size = new System.Drawing.Size(772, 390);
			this.DGV.TabIndex = 2;
			this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
			this.DGV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseUp);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 250;
			// 
			// sizeFactorDataGridViewTextBoxColumn
			// 
			this.sizeFactorDataGridViewTextBoxColumn.DataPropertyName = "SizeFactor";
			this.sizeFactorDataGridViewTextBoxColumn.HeaderText = "SizeFactor";
			this.sizeFactorDataGridViewTextBoxColumn.Name = "sizeFactorDataGridViewTextBoxColumn";
			this.sizeFactorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// positionDataGridViewTextBoxColumn
			// 
			this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
			this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
			this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
			this.positionDataGridViewTextBoxColumn.ReadOnly = true;
			this.positionDataGridViewTextBoxColumn.Width = 250;
			// 
			// DGVSource
			// 
			this.DGVSource.DataSource = typeof(TransportFeverTownsEditor.Classes.Town);
			this.DGVSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.DGVSource_ListChanged);
			// 
			// StatusL
			// 
			this.StatusL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StatusL.Location = new System.Drawing.Point(325, 24);
			this.StatusL.Name = "StatusL";
			this.StatusL.Size = new System.Drawing.Size(463, 21);
			this.StatusL.TabIndex = 3;
			this.StatusL.Text = "---";
			this.StatusL.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// selectByRegExToolStripMenuItem
			// 
			this.selectByRegExToolStripMenuItem.Name = "selectByRegExToolStripMenuItem";
			this.selectByRegExToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.selectByRegExToolStripMenuItem.Text = "Select by RegEx";
			this.selectByRegExToolStripMenuItem.Click += new System.EventHandler(this.SelectByRegExToolStripMenuItem_Click);
			// 
			// FMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.OpenedFileL);
			this.Controls.Add(this.StatusL);
			this.Controls.Add(this.DGV);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transport Fever Towns Editor";
			this.Resize += new System.EventHandler(this.FMain_Resize);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGVSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label OpenedFileL;
		private System.Windows.Forms.DataGridView DGV;
		private System.Windows.Forms.BindingSource DGVSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sizeFactorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem deleteSelectedTownsToolStripMenuItem;
		private System.Windows.Forms.Label StatusL;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem changeSizeFactorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteTownsOnTheEdgeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectByRegExToolStripMenuItem;
	}
}

