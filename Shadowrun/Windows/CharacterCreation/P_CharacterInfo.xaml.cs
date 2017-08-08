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

		private void AttributeSpinner_OnIncrease() => WindowNotifyUpdate();

		private void RaceComboBox_DropDownClosed(object sender, EventArgs e)
		{
			Enum.TryParse(RaceComboBox.SelectedValue.ToString(), out Data.RaceEnum newRace);
			Attributes = Data.Definitions.DataRepo.GetRaceStatBlock(newRace);

			WindowNotifyUpdate();
		}


		void WindowNotifyUpdate()
		{
			((CharacterCreationWindow)Application.Current.MainWindow).UpdateCharacterData();
		}
	}
}