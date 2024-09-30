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
using System.Data;
using System.Data.SqlClient;


namespace APPR6312_Part2_GabrielMoraka
{
	/// <summary>
	/// Interaction logic for DonationApp.xaml
	/// </summary>
	public partial class DonationApp : Window
	{
		public DonationApp()
		{
			InitializeComponent();
		}



		private void SubmitButton_Click(object sender, RoutedEventArgs e)
		{
			// Validate inputs
			if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
				string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
				string.IsNullOrWhiteSpace(PhoneTextBox.Text) ||
				ResourceTypeComboBox.SelectedItem == null ||
				string.IsNullOrWhiteSpace(QuantityTextBox.Text) ||
				ConditionComboBox.SelectedItem == null ||
				(!PickupRadioButton.IsChecked.GetValueOrDefault() && !DropoffRadioButton.IsChecked.GetValueOrDefault()) ||
				(!PickupRadioButton.IsChecked.GetValueOrDefault() && DropoffRadioButton.IsChecked.GetValueOrDefault() && string.IsNullOrWhiteSpace(DropoffLocationTextBox.Text)) ||
				!ConsentCheckBox.IsChecked.GetValueOrDefault() ||
				!TermsCheckBox.IsChecked.GetValueOrDefault())
			{
				MessageBox.Show("Please fill out all required fields and accept the terms.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
				return;
			}

			// Process the donation
			var donation = new
			{
				Name = NameTextBox.Text,
				Email = EmailTextBox.Text,
				Phone = PhoneTextBox.Text,
				ResourceType = (ResourceTypeComboBox.SelectedItem as ComboBoxItem).Content.ToString(),
				Quantity = int.Parse(QuantityTextBox.Text), // Assuming quantity is an integer
				Condition = (ConditionComboBox.SelectedItem as ComboBoxItem).Content.ToString(),
				Pickup = PickupRadioButton.IsChecked.GetValueOrDefault(),
				DropoffLocation = DropoffLocationTextBox.Text,
				PickupDate = PickupDatePicker.SelectedDate,
				SpecialInstructions = SpecialInstructionsTextBox.Text,
			};

			// Connection string to the Azure SQL Database
			string connectionString = "Server=tcp:st10180168.database.windows.net,1433;Initial Catalog=AppliedProgramming;Persist Security Info=False;User ID=ST10180168;Password=GABKUTmor5%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand("INSERT INTO Donations (Name, Email, Phone, ResourceType, Quantity, Condition, Pickup, DropoffLocation, PickupDate, SpecialInstructions) VALUES (@Name, @Email, @Phone, @ResourceType, @Quantity, @Condition, @Pickup, @DropoffLocation, @PickupDate, @SpecialInstructions)", con))
					{
						// Add parameters to avoid SQL injection
						cmd.Parameters.AddWithValue("@Name", donation.Name);
						cmd.Parameters.AddWithValue("@Email", donation.Email);
						cmd.Parameters.AddWithValue("@Phone", donation.Phone);
						cmd.Parameters.AddWithValue("@ResourceType", donation.ResourceType);
						cmd.Parameters.AddWithValue("@Quantity", donation.Quantity);
						cmd.Parameters.AddWithValue("@Condition", donation.Condition);
						cmd.Parameters.AddWithValue("@Pickup", donation.Pickup);
						cmd.Parameters.AddWithValue("@DropoffLocation", (object)donation.DropoffLocation ?? DBNull.Value); // Handle possible null
						cmd.Parameters.AddWithValue("@PickupDate", (object)donation.PickupDate ?? DBNull.Value); // Handle possible null
						cmd.Parameters.AddWithValue("@SpecialInstructions", (object)donation.SpecialInstructions ?? DBNull.Value); // Handle possible null

						// Execute the command
						cmd.ExecuteNonQuery();
					}

					// Show success message
					MessageBox.Show("Thank you for your donation! Your generous contribution is greatly appreciated.", "Donation Submitted", MessageBoxButton.OK, MessageBoxImage.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occurred while submitting your donation: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
				finally
				{
					con.Close(); // Ensure the connection is closed
				}
			}

			// Clear form fields (optional)
			ClearForm();
		}
		
		public void ClearForm()
		{
			NameTextBox.Clear();
			EmailTextBox.Clear();
			PhoneTextBox.Clear();
			ResourceTypeComboBox.SelectedIndex = -1;
			
			QuantityTextBox.Clear();
			ConditionComboBox.SelectedIndex = -1;
			PickupRadioButton.IsChecked = false;
			DropoffRadioButton.IsChecked = false;
			DropoffLocationTextBox.SelectedDate = null;
			PickupDatePicker.SelectedDate = null;
			SpecialInstructionsTextBox.Clear();
			ConsentCheckBox.IsChecked = false;
			TermsCheckBox.IsChecked = false;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			
			ChooseOption chooseoption  = new ChooseOption();
			chooseoption.Show();
			this.Close(); // Closing this Window
		}
	}
}
