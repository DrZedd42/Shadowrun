namespace Shadowrun.Data.Character
{
	[PropertyChanged.AddINotifyPropertyChangedInterface]
	public class Attribute
	{
		public int BaseValue { get; set; }
		public int CurrentValue { get { return BaseValue; } }

		public int BaseLimit { get; set; }
		public int CurrentLimit { get { return BaseLimit; } }

		public string GetAttributeDisplay
		{
			get
			{
				return $"{CurrentValue}/{CurrentLimit}";
			}
		}

		public Attribute() : this(1, 6) { }
		public Attribute(int baseVal, int baseLimit)
		{
			BaseValue = baseVal;
			BaseLimit = baseLimit;
		}

		public override string ToString()
		{
			return $"{BaseValue}/{BaseLimit}";
		}
	}
}
