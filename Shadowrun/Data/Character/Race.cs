namespace Shadowrun.Data.Character
{
	public class Race
	{
		public string Name { get { return RaceEnumValue.ToString(); } }
		public RaceEnum RaceEnumValue { get; set; }
		public StatBlock Attributes { get; set; }

		public Race()
		{
			Attributes = new StatBlock();
		}

		public static Race GetRace(RaceEnum race)
		{
			var r = new Race()
			{
				RaceEnumValue = race
			};

			switch (race)
			{
				case RaceEnum.Human:
					break;
				case RaceEnum.Elf:
					r.Attributes.Agility.BaseValue = 2;
					r.Attributes.Agility.BaseLimit = 7;
					r.Attributes.Charisma.BaseValue = 3;
					r.Attributes.Charisma.BaseLimit = 8;
					break;
				case RaceEnum.Dwarf:
					r.Attributes.Body.BaseValue = 3;
					r.Attributes.Body.BaseLimit = 8;
					r.Attributes.Strength.BaseValue = 3;
					r.Attributes.Strength.BaseLimit = 8;
					r.Attributes.Willpower.BaseValue = 2;
					r.Attributes.Willpower.BaseLimit = 7;
					break;
				case RaceEnum.Ork:
					r.Attributes.Body.BaseValue = 4;
					r.Attributes.Body.BaseLimit = 9;
					r.Attributes.Strength.BaseValue = 3;
					r.Attributes.Strength.BaseLimit = 8;
					r.Attributes.Logic.BaseLimit = 5;
					r.Attributes.Charisma.BaseLimit = 5;
					break;
				case RaceEnum.Troll:
					r.Attributes.Body.BaseValue = 5;
					r.Attributes.Body.BaseLimit = 10;
					r.Attributes.Agility.BaseLimit = 5;
					r.Attributes.Logic.BaseLimit = 5;
					r.Attributes.Strength.BaseValue = 5;
					r.Attributes.Strength.BaseLimit = 10;
					r.Attributes.Logic.BaseLimit = 5;
					r.Attributes.Intuition.BaseLimit = 5;
					r.Attributes.Charisma.BaseLimit = 4;
					break;
			}

			return r;
		}
	}
}
