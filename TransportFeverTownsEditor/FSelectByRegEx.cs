using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TransportFeverTownsEditor.Classes;

namespace TransportFeverTownsEditor
{
	public partial class FSelectByRegEx : Form
	{
		private DataGridView DGV;

		public FSelectByRegEx(DataGridView dgv)
		{
			InitializeComponent();
			DGV = dgv;
		}

		private void FSelectByRegEx_Load(object sender, EventArgs e)
		{
			//
		}

		private void SelectB_Click(object sender, EventArgs e)
		{
			try
			{
				string pattern = InputTB.Text.Trim();
				List<Town> selectedTowns = new List<Town>();
				for (int index = 0; index < DGV.Rows.Count; index++)
				{
					DataGridViewRow row = DGV.Rows[index];
					Town town = row.DataBoundItem as Town;
					row.Selected = Regex.IsMatch(town.Name, pattern, RegexOptions.IgnoreCase);
					if (row.Selected)
					{
						selectedTowns.Add(town);
					}
				}
				Utils.DisplaySelectedTownsMessage(selectedTowns);
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CancelB_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
