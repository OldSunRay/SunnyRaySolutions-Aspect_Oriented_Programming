using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using PostSharp;
using PostSharp.Patterns.Model;

namespace Notifier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            person = new Person { FirstName = "Adam", LastName = "Greene" };
            InitializeComponent();
        }        
 
        public Person person { get; set; }

		private void ChangeFirstName_Click(object sender, RoutedEventArgs e)
		{
			person.FirstName = "Changed";
		}

		private void ChangeLastName_Click(object sender, RoutedEventArgs e)
		{
			person.LastName = "Changed";
		}
	}
}
