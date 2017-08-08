using Shadowrun.Data.Character;

namespace Shadowrun.Windows.CharacterCreation
{
	public partial class CharacterCreationWindow
	{
		public Character CurrentCharacter { get; private set; }

		public CharacterCreationWindow()
		{
			InitializeComponent();

			CurrentCharacter = new Character(Data.RaceEnum.Human);

			RightStatBlock.SetStatBlockData(CurrentCharacter.Attributes);
		}

		public void UpdateCharacterData()
		{
			// Modify CurrentCharacter
			var charInfo = (P_CharacterInfo)CharInfoFrame.Content;
			CurrentCharacter.GeneralInformation.Name = charInfo.CharacterName;
			CurrentCharacter.Attributes = charInfo.Attributes;

			// Push UI Changes
			RightStatBlock.SetStatBlockData(CurrentCharacter.Attributes);
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			UpdateCharacterData();
			int x = 0;
		}
	}
}
