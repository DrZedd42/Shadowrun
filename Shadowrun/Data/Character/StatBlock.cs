namespace Shadowrun.Data.Character
{
	public class StatBlock
	{
		public Attribute Body { get; set; }
		public Attribute Agility { get; set; }
		public Attribute Reaction { get; set; }
		public Attribute Strength { get; set; }
		public Attribute Charisma { get; set; }
		public Attribute Intuition { get; set; }
		public Attribute Logic { get; set; }
		public Attribute Willpower { get; set; }

		public int Initiative { get { return Reaction.CurrentValue + Intuition.CurrentValue; } }

		public StatBlock()
		{
			Body = new Attribute();
			Agility = new Attribute();
			Reaction = new Attribute();
			Strength = new Attribute();
			Charisma = new Attribute();
			Intuition = new Attribute();
			Logic = new Attribute();
			Willpower = new Attribute();
		}
	}
}
