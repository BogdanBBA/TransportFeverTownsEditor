using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportFeverTownsEditor.Classes;

namespace TransportFeverTownsEditor
{
	public partial class FDeleteTownsOnTheEdge : Form
	{
		private DataGridView DGV;
		private BindingSource DGVSource;
		private List<Town> DeletedTowns;

		public FDeleteTownsOnTheEdge(DataGridView dgv, BindingSource dgvSource, List<Town> deletedTowns)
		{
			InitializeComponent();
			DGV = dgv;
			DGVSource = dgvSource;
			DeletedTowns = deletedTowns;
		}

		private void FDeleteTownsOnTheEdge_Load(object sender, EventArgs e)
		{
			//
		}

		private bool IsInsideBounds(Rectangle bounds, Coord pos)
		{
			int x = (int)pos.X, y = (int)pos.Y;
			int l = bounds.Left, r = bounds.Right, t = bounds.Top, b = bounds.Bottom;
			bool xOk = l < x && x < r;
			bool yOk = t < y && y < b;
			return xOk && yOk;
		}

		private void DeleteB_Click(object sender, EventArgs e)
		{
			Size pxMapSize = new Size((int)NUD_W.Value, (int)NUD_H.Value);
			int pxEdge = (int)NUD_E.Value;

			// as far as I can tell, coordinates range from -2*W to +2*W, with W=pixel width
			int edge = 4 * pxEdge;
			Rectangle acceptableBounds = new Rectangle(
				-2 * pxMapSize.Width + edge,
				-2 * pxMapSize.Height + edge,
				4 * pxMapSize.Width - 2 * edge,
				4 * pxMapSize.Height - 2 * edge);

			List<Town> townsToDelete = new List<Town>();
			foreach (DataGridViewRow item in DGV.Rows)
			{
				Town town = item.DataBoundItem as Town;
				if (!IsInsideBounds(acceptableBounds, town.Position))
				{
					townsToDelete.Add(town);
				}
			}

			for (int index = 0; index < townsToDelete.Count; index++)
			{
				DGVSource.Remove(townsToDelete[index]);
			}
			DeletedTowns.AddRange(townsToDelete);
			townsToDelete.Clear();

			DGV.Refresh();
			Close();
		}

		private void CancelB_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
