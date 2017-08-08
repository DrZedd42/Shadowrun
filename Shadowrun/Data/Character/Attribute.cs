namespace Shadowrun.Data.Character
{
	[PropertyChanged.AddINotifyPropertyChangedInterface]
	public class Attribute
	{
		public int BaseValue { get; set; }
		public int TempValue { get; set; }
		public int CurrentValue { get { return BaseValue + TempValue; } }

		public int BaseLimit { get; set; }
		public int TempLimit { get; set; }
		public int CurrentLimit { get { return BaseLimit + TempLimit; } }

		public string GetAttributeDisplay
		{
			get
			{
				return $"{CurrentValue}/{CurrentLimit}";
			}
		}

		public string GetAttributeDisplayWithTemp
		{
			get
			{
				return $"{CurrentValue}/{CurrentLimit} ({TempValue.ToString("+#;-#;+0")}/{TempLimit.ToString("+#;-#;+0")})";
			}
		}

		public Attribute() : this(1, 6) { }
		public Attribute(int baseVal, int baseLimit)
		{
			BaseValue = baseVal;
			BaseLimit = baseLimit;
			TempValue = 0;
			TempLimit = 0;
		}

		public override string ToString()
		{
			return $"{BaseValue}/{BaseLimit}";
		}
	}
}
