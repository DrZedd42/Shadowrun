using System.Windows;

using PropertyChanged;
using System;

namespace Shadowrun.Controls
{
	[AddINotifyPropertyChangedInterface]
	public partial class AttributeSpinner
	{
		public delegate void EmptyNotifyEvent();

		public event EmptyNotifyEvent OnIncrease;
		public event EmptyNotifyEvent OnDecrease;

		// Dependency properties
		public static readonly DependencyProperty AttributeNameProperty = DependencyProperty.Register("AttributeName", typeof(string), typeof(AttributeSpinner), new PropertyMetadata("attrib_value_missing"));
		public string AttributeName { get { return (string)GetValue(AttributeNameProperty); } set { SetValue(AttributeNameProperty, value); } }

		public static readonly DependencyProperty MinValueProperty = DependencyProperty.Register("MinValue", typeof(int), typeof(AttributeSpinner), new PropertyMetadata(0));
		public int MinValue { get { return (int)GetValue(MinValueProperty); } set { SetValue(MinValueProperty, value); } }

		public static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register("MaxValue", typeof(int), typeof(AttributeSpinner), new PropertyMetadata(100));
		public int MaxValue { get { return (int)GetValue(MaxValueProperty); } set { SetValue(MaxValueProperty, value); } }

		public static readonly DependencyProperty AllowKeyInputProperty = DependencyProperty.Register("AllowKeyInput", typeof(bool), typeof(AttributeSpinner), new PropertyMetadata(false));
		public bool AllowKeyInput { get { return (bool)GetValue(AllowKeyInputProperty); } set { SetValue(AllowKeyInputProperty, value); } }

		public static readonly DependencyProperty EnableIncreaseProperty = DependencyProperty.Register("EnableIncrease", typeof(bool), typeof(AttributeSpinner), new PropertyMetadata(true));
		public bool EnableIncrease { get { return (bool)GetValue(EnableIncreaseProperty); } set { SetValue(EnableIncreaseProperty, value); } }

		public static readonly DependencyProperty EnableDecreaseProperty = DependencyProperty.Register("EnableDecrease", typeof(bool), typeof(AttributeSpinner), new PropertyMetadata(true));
		public bool EnableDecrease { get { return (bool)GetValue(EnableDecreaseProperty); } set { SetValue(EnableDecreaseProperty, value); } }

		// Value properties
		//public int Value { get; set; }
		public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(AttributeSpinner), new PropertyMetadata(0));
		public int Value { get { return (int)GetValue(ValueProperty); } set { SetValue(ValueProperty, value); } }

		public AttributeSpinner()
		{
			InitializeComponent();
			Value = 1;
		}

		private void DecreaseButton_Click(object sender, RoutedEventArgs e)
		{
			Value = (Value - 1) < MinValue ? MinValue : Value - 1;
			if (Value == MinValue) DecreaseButton.IsEnabled = false;
			else IncreaseButton.IsEnabled = true;

			OnDecrease?.Invoke();
		}

		private void IncreaseButton_Click(object sender, RoutedEventArgs e)
		{
			Value = (Value + 1) > MaxValue ? MaxValue : Value + 1;
			if (Value == MaxValue) IncreaseButton.IsEnabled = false;
			else DecreaseButton.IsEnabled = true;

			OnIncrease?.Invoke();
		}
	}
}
