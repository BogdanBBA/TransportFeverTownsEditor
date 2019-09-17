using System;
using System.Windows.Forms;
using TransportFeverTownsEditor.Classes;

namespace TransportFeverTownsEditor
{
	public partial class FChangeSizeFactor : Form
	{
		private enum ChangeSizeFactorMethod { FixedValue, Multiply }

		private DataGridView DGV;
		private ChangeSizeFactorMethod ChangeMethod;

		public FChangeSizeFactor(DataGridView dgv)
		{
			InitializeComponent();
			DGV = dgv;
			ChangeMethod = ChangeSizeFactorMethod.FixedValue;
		}

		private void FChangeSizeFactor_Load(object sender, EventArgs e)
		{
			//
		}

		private void FixedValueRB_CheckedChanged(object sender, EventArgs e)
		{
			NUD.Maximum = 2;
			ChangeMethod = ChangeSizeFactorMethod.FixedValue;
		}

		private void MultiplyRB_CheckedChanged(object sender, EventArgs e)
		{
			NUD.Maximum = 20;
			ChangeMethod = ChangeSizeFactorMethod.Multiply;
		}

		private float ChangeSizeFactor(float sizeFactor, float factor, ChangeSizeFactorMethod method)
		{
			float result = sizeFactor;
			switch (method)
			{
				case ChangeSizeFactorMethod.FixedValue:
					result = factor;
					break;
				case ChangeSizeFactorMethod.Multiply:
					result = sizeFactor * factor;
					break;
				default:
					break;
			}
			return Math.Min(2.0f, Math.Max(0.0f, result));
		}

		private void ChangeB_Click(object sender, EventArgs e)
		{
			float value = (float)NUD.Value;
			foreach (DataGridViewRow item in DGV.SelectedRows)
			{
				Town town = item.DataBoundItem as Town;
				float newSizeFactor = ChangeSizeFactor(town.SizeFactor, value, ChangeMethod);
				town.SizeFactor = newSizeFactor;
			}
			DGV.Refresh();
			Close();
		}

		private void CancelB_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
