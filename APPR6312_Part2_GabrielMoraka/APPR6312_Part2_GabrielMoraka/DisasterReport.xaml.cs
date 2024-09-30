using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
	/// Interaction logic for DisasterReport.xaml
	/// </summary>
	public partial class DisasterReport : Window
	{
		public DisasterReport()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ChooseOption chooseoption = new ChooseOption();
			chooseoption.Show();
			this.Close(); // Closing this Window
		}

		private void SubmitButton_Click(object sender, RoutedEventArgs e)
		{
			// Validation
			if (IncidentTypeComboBox.SelectedItem == null)
			{
				errormessageR.Text = "Select a type of incident that has occurred.";
				IncidentTypeComboBox.Focus();
				return;
			}

			if (!IncidentDatePicker.SelectedDate.HasValue)
			{
				errormessageR.Text = "Select date of incident.";
				IncidentDatePicker.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(IncidentTimeTextBox.Text))
			{
				errormessageR.Text = "Enter time of incident.";
				IncidentTimeTextBox.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
			{
				errormessageR.Text = "Enter the location of incident.";
				AddressTextBox.Focus();
				return;
			}

			if (CountryComboBox.SelectedItem == null)
			{
				errormessageR.Text = "Select a country.";
				CountryComboBox.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
			{
				errormessageR.Text = "Write a short description about the incident.";
				DescriptionTextBox.Focus();
				return;
			}

			if (SeverityLevelComboBox.SelectedItem == null)
			{
				errormessageR.Text = "Select a severity level.";
				SeverityLevelComboBox.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(ContactNameTextBox.Text))
			{
				errormessageR.Text = "Enter your contact information.";
				ContactNameTextBox.Focus();
				return;
			}

			if (ConsentCheckBox.IsChecked != true)
			{
				errormessageR.Text = "You must agree to the terms.";
				ConsentCheckBox.Focus();
				return;
			}

			// If all validations pass, insert data into the database
			try
			{
				string connectionString = "Server=tcp:st10180168.database.windows.net,1433;Initial Catalog=AppliedProgramming;Persist Security Info=False;User ID=ST10180168;Password=GABKUTmor5%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; // Azure SQL DB connection string

				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string query = "INSERT INTO DisasterReports (IncidentType, IncidentDate, IncidentTime, Location, Country, Description, SeverityLevel, ContactName, Consent) " +
								   "VALUES (@IncidentType, @IncidentDate, @IncidentTime, @Location, @Country, @Description, @SeverityLevel, @ContactName, @Consent)";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@IncidentType", IncidentTypeComboBox.Text);
						command.Parameters.AddWithValue("@IncidentDate", IncidentDatePicker.SelectedDate.Value);
						command.Parameters.AddWithValue("@IncidentTime", TimeSpan.Parse(IncidentTimeTextBox.Text));
						command.Parameters.AddWithValue("@Location", AddressTextBox.Text);
						command.Parameters.AddWithValue("@Country", CountryComboBox.Text);
						command.Parameters.AddWithValue("@Description", DescriptionTextBox.Text);
						command.Parameters.AddWithValue("@SeverityLevel", SeverityLevelComboBox.Text);
						command.Parameters.AddWithValue("@ContactName", ContactNameTextBox.Text);
						command.Parameters.AddWithValue("@Consent", ConsentCheckBox.IsChecked == true ? 1 : 0);

						command.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Thank you for filling in the information about the disaster.", "Report Submitted", MessageBoxButton.OK, MessageBoxImage.Information);

				// Clear form fields
				IncidentTypeComboBox.SelectedIndex = -1;
				IncidentDatePicker.SelectedDate = null;
				IncidentTimeTextBox.Clear();
				AddressTextBox.Clear();
				CountryComboBox.SelectedIndex = -1;
				DescriptionTextBox.Clear();
				SeverityLevelComboBox.SelectedIndex = -1;
				ContactNameTextBox.Clear();
				ConsentCheckBox.IsChecked = false;

			}
			catch (Exception ex)
			{
				// Log or handle the error
				MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}


	}
}
