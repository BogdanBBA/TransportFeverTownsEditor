using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TransportFeverTownsEditor.Classes;

namespace TransportFeverTownsEditor
{
	public partial class FMain : Form
	{
		private bool FileOpened = false;
		private readonly List<Town> DeletedTowns = new List<Town>();

		#region Form events
		public FMain()
		{
			InitializeComponent();
		}

		private void FMain_Resize(object sender, EventArgs e)
		{
			DGV.Size = new Size(Width - 44, Height - 99);
			StatusL.Left = DGV.Right - StatusL.Width;
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string fileName = openFileDialog.FileName;
					string mapName = Path.GetFileName(Path.GetDirectoryName(fileName));
					string backupFileName = fileName.Replace("map.lua", "original-map.lua");
					if (!File.Exists(backupFileName))
					{
						File.Copy(fileName, backupFileName, false);
					}

					List<string> lines = File.ReadAllLines(openFileDialog.FileName, Encoding.UTF8).ToList();
					List<string> townLines = lines.Where(line => Regex.IsMatch(line, Town.LINE_REGEX)).ToList();
					List<Town> towns = townLines.Select(line => new Town(line))
						.OrderBy(town => town.Name)
						.ThenByDescending(town => town.SizeFactor)
						.ThenBy(town => town.Position.X)
						.ThenBy(town => town.Position.Y)
						.ToList();
					InitializeFormData(mapName, towns);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					InitializeFormData("---", new List<Town>());
				}
			}
		}

		private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			RefreshStatus();
		}

		private void DGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			RefreshStatus();
		}

		private void DGVSource_ListChanged(object sender, ListChangedEventArgs e)
		{
			RefreshStatus();
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!FileOpened)
				return;
			string fileName = openFileDialog.FileName;
			string fileContents = File.ReadAllText(fileName, Encoding.UTF8);

			foreach (Town town in DeletedTowns)
			{
				fileContents = fileContents.Replace(town.OriginalInput + Environment.NewLine, "");
			}

			for (int index = 0; index < DGVSource.Count; index++)
			{
				Town town = DGVSource[index] as Town;
				if (town.HasChanged)
				{
					fileContents = fileContents.Replace(town.OriginalInput, town.ToLuaLine());
				}
			}

			File.WriteAllText(fileName, fileContents, Encoding.UTF8);
			Process.Start(fileName);
		}

		private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DGV.SelectAll();
		}

		private void SelectNoneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DGV.ClearSelection();
		}

		private void SelectByRegExToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FSelectByRegEx(DGV).ShowDialog(this);
		}

		private void InvertSelectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int index = 0; index < DGV.Rows.Count; index++)
			{
				DGV.Rows[index].Selected = !DGV.Rows[index].Selected;
			}
		}

		private void DeleteSelectedTownsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List<Town> townsDeletedNow = new List<Town>();
			foreach (DataGridViewRow item in DGV.SelectedRows)
			{
				Town town = item.DataBoundItem as Town;
				townsDeletedNow.Add(town);
				DeletedTowns.Add(town);
				DGV.Rows.Remove(item);
			}
			Utils.DisplayDeletedTownsMessage(townsDeletedNow);
		}

		private void DeleteTownsOnTheEdgeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!FileOpened)
				return;
			new FDeleteTownsOnTheEdge(DGV, DGVSource, DeletedTowns).ShowDialog(this);
		}

		private void ChangeSizeFactorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!FileOpened)
				return;
			new FChangeSizeFactor(DGV).ShowDialog(this);
		}

		private void ExitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion

		#region Utility methods
		private void RefreshStatus()
		{
			StatusL.Text = $"Selected {DGV.SelectedRows.Count} / {DGV.Rows.Count}";
		}

		private void InitializeFormData(string name, List<Town> towns)
		{
			DeletedTowns.Clear();

			DGVSource.Clear();
			towns.ForEach(town => DGVSource.Add(town));

			OpenedFileL.Text = $"Opened file: {name} ({towns.Count} towns)";
			FileOpened = true;
		}
		#endregion
	}
}
