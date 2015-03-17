using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace QuickCalc
{
	public class ViewModel : INotifyPropertyChanged
	{
		public ICommand NumberPress { get; set; }
		public ICommand OperatorPress { get; set; }
		public ICommand Calculate { get; set; }

		private string _numberDisplay = "0";

		public string NumberDisplay
		{
			get { return _numberDisplay; }
			set
			{
				if (_numberDisplay == value)
					return;
				_numberDisplay = value;
				NotifyPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
