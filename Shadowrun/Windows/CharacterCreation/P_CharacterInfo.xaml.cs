using System;
using System.Windows;

using Shadowrun.Data.Character;

using PropertyChanged;

namespace Shadowrun.Windows.CharacterCreation
{
	[AddINotifyPropertyChangedInterface]
	public partial class P_CharacterInfo
	{
		public string CharacterName { get; set; }
		public StatBlock Attributes { get; set; }

		public P_CharacterInfo()
		{
			InitializeComponent();

			Attributes = new StatBlock();
			CharacterName = "Testy Mctest";
		}

		private void RaceComboBox_DropDownClosed(object sender, System.EventArgs e)
		{
			// Update statblock in the windows
			Enum.TryParse(RaceComboBox.SelectedValue.ToString(), out Data.Definitions.DataRepo.RaceEnum newRace);
			var w = (CharacterCreationWindow)Application.Current.MainWindow;
			w.RightStatBlock.SetStatBlockData(Data.Definitions.DataRepo.GetRaceStatBlock(newRace));
		}
	}
}
