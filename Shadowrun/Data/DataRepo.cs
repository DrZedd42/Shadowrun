using Shadowrun.Data.Character;

namespace Shadowrun.Data
{
	public class DataRepo
	{
		public static StatBlock GetRaceStatBlock_remove(RaceEnum race)
		{
			var b = new StatBlock();

			switch (race)
			{
				case RaceEnum.Human:
					break;
				case RaceEnum.Elf:
					b.Agility.BaseValue = 2;
					b.Agility.BaseLimit = 7;
					b.Charisma.BaseValue = 3;
					b.Charisma.BaseLimit = 8;
					break;
				case RaceEnum.Dwarf:
					b.Body.BaseValue = 3;
					b.Body.BaseLimit = 8;
					b.Strength.BaseValue = 3;
					b.Strength.BaseLimit = 8;
					b.Willpower.BaseValue = 2;
					b.Willpower.BaseLimit = 7;
					break;
				case RaceEnum.Ork:
					b.Body.BaseValue = 4;
					b.Body.BaseLimit = 9;
					b.Strength.BaseValue = 3;
					b.Strength.BaseLimit = 8;
					b.Logic.BaseLimit = 5;
					b.Charisma.BaseLimit = 5;
					break;
				case RaceEnum.Troll:
					b.Body.BaseValue = 5;
					b.Body.BaseLimit = 10;
					b.Agility.BaseLimit = 5;
					b.Logic.BaseLimit = 5;
					b.Strength.BaseValue = 5;
					b.Strength.BaseLimit = 10;
					b.Logic.BaseLimit = 5;
					b.Intuition.BaseLimit = 5;
					b.Charisma.BaseLimit = 4;
					break;
			}

			return b;
		}
	}
}
