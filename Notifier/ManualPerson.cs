using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Notifier
{
	public class Person : INotifyPropertyChanged
	{
		private string firstName;
		private string lastName;

		public string LastName
		{
			get
			{
				return this.lastName;
			}
			set
			{
				this.lastName = value;
				OnPropertyChanged("LastName");
				OnPropertyChanged("FullName");
			}
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				this.firstName = value;
				OnPropertyChanged("FirstName");
				OnPropertyChanged("FullName");
			}
		}

		public string FullName
		{
			get
			{
				return this.FirstName + " " + this.LastName;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}


