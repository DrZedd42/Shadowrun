using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

using Shadowrun.Data.Character;

using PropertyChanged;
using System.Windows.Media;
using System.Linq;

namespace Shadowrun.Windows.CharacterCreation
{
	[AddINotifyPropertyChangedInterface]
	public partial class P_CharacterInfo
	{
		public string CharacterName { get; set; }
		public StatBlock Attributes { get; set; }

		int StartingAttributePoints = 10;
		public int RemainingAttributePoints { get; set; }
		public string RemainingAttributePointsString { get { return $"{RemainingAttributePoints} left"; } }

		public P_CharacterInfo()
		{
			InitializeComponent();
			DataContext = this;

			RemainingAttributePoints = StartingAttributePoints;

			Attributes = new StatBlock();
			CharacterName = "Testy Mctest";
		}

		private void AttributeSpinner_OnIncrease() => WindowNotifyUpdate();
		private void RaceComboBox_SelectionChanged(object s, SelectionChangedEventArgs e) => RaceChanged();
		private void RaceComboBox_DropDownClosed(object sender, EventArgs e) => RaceChanged();
		private void RaceComboBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e) => RaceChanged();

		void RaceChanged()
		{
			Enum.TryParse(RaceComboBox.SelectedValue.ToString(), out Data.RaceEnum newRace);
			Attributes = Race.GetRace(newRace).Attributes;
			RemainingAttributePoints = StartingAttributePoints;

			foreach(var aspin in AttributeSpinners.Children.OfType<Controls.AttributeSpinner>())
			{
				aspin.UpdateButtonState();
			}

			WindowNotifyUpdate();
		}


		void WindowNotifyUpdate()
		{
			if (Attributes == null) return;
			((CharacterCreationWindow)Application.Current.MainWindow).UpdateCharacterData();
		}
	}
}