using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TransportFeverTownsEditor.Classes
{
	public static class Utils
	{
		public static void DisplayTownsMessage(List<Town> towns, string actionThatHappened)
		{
			string list = string.Join(", ", towns.OrderBy(town => town.Name).Select(town => town.Name));
			MessageBox.Show($"The following {towns.Count} {(towns.Count == 1 ? "town" : "towns")} have been {actionThatHappened}:{Environment.NewLine}{Environment.NewLine}{list}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void DisplayDeletedTownsMessage(List<Town> towns)
		{
			DisplayTownsMessage(towns, "deleted");
		}

		public static void DisplaySelectedTownsMessage(List<Town> towns)
		{
			DisplayTownsMessage(towns, "selected");
		}
	}
}
