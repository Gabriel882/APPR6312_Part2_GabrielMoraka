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
using System.Windows.Shapes;

namespace APPR6312_Part2_GabrielMoraka
{
	/// <summary>
	/// Interaction logic for ChooseOption.xaml
	/// </summary>
	public partial class ChooseOption : Window
	{
		public ChooseOption()
		{
			InitializeComponent();
		}

		public void buttonLogin_Click(object sender, RoutedEventArgs e)
		{
			LoginPage login = new LoginPage();
			login.Show();
			Close();
		}

		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			
				this.Close();
			
		}

		private void EnterAnDisasterIncident_Click(object sender, RoutedEventArgs e)
		{
			DisasterReport disasterReport = new DisasterReport();	
			disasterReport.Show();
			Close();
		}

		private void ResourceDonation_Click(object sender, RoutedEventArgs e)
		{
			DonationApp app = new DonationApp();
			app.Show();
			Close();
		}

		private void VolunteerManagement_Click(object sender, RoutedEventArgs e)
		{
			RegisterVolunteer registerVolunteer = new RegisterVolunteer();
			registerVolunteer.Show();
			Close();
		}

		private void manageAccount_Click(object sender, RoutedEventArgs e)
		{

			ManageProfile manageProfile = new ManageProfile();
			manageProfile.Show(); 
			Close();


		}
	}
}
