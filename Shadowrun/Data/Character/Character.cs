namespace Shadowrun.Data.Character
{
	public class Character
	{
		public GeneralInformation GeneralInformation { get; set; }
		public StatBlock Attributes { get; set; }

		public Character()
		{
			GeneralInformation = new GeneralInformation();
			Attributes = new StatBlock();
		}

		public Character(RaceEnum race)
		{
			GeneralInformation = new GeneralInformation();
			Attributes = Race.GetRace(race).Attributes;
		}
	}
}
