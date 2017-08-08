using Shadowrun.Data.Character;

namespace Shadowrun.Controls
{
	[PropertyChanged.AddINotifyPropertyChangedInterface]
    public partial class StatBlockVertical
    {
		public StatBlock CurrentStatBlock { get; set; }
		public string Test { get; set; }

		public StatBlockVertical()
		{
			InitializeComponent();
			DataContext = this;
		}

		public void SetStatBlockData(StatBlock b)
		{
			CurrentStatBlock = b;
		}
    }
}
