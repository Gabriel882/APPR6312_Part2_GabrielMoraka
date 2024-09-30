using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
	/// Interaction logic for RegisterVolunteer.xaml
	/// </summary>
	public partial class RegisterVolunteer : Window
	{
		public RegisterVolunteer()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, RoutedEventArgs e)
		{
			ChooseOption chooseoption = new ChooseOption();
			chooseoption.Show();
			this.Close(); // Closing this Window
		}

		private void Submit_Click(object sender, RoutedEventArgs e)
		{
			// Validate user input
			if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || !IsValidName(textBoxFirstName.Text))
			{
				errormessage.Text = "Enter a valid first name with no numbers or special characters.";
				textBoxFirstName.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
			{
				errormessage.Text = "Enter your surname.";
				textBoxLastName.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(textBoxcellphone.Text) || !IsValidPhoneNumber(textBoxcellphone.Text))
			{
				errormessage.Text = "Enter a valid phone number (10 digits).";
				textBoxcellphone.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(textBoxpassword.Password) || !IsValidPassword(textBoxpassword.Password))
			{
				errormessage.Text = "Please enter a password that contains at least one number.";
				textBoxpassword.Focus();
				return;
			}

			// Store the data in Azure SQL Database
			string connectionString = "Server=tcp:st10180168.database.windows.net,1433;Initial Catalog=AppliedProgramming;Persist Security Info=False;User ID=ST10180168;Password=GABKUTmor5%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand("INSERT INTO VolunteerRegistration (FirstName, LastName, Cellphone, Password) VALUES (@FirstName, @LastName, @Cellphone, @Password)", con))
					{
						cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
						cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
						cmd.Parameters.AddWithValue("@Cellphone", textBoxcellphone.Text);
						cmd.Parameters.AddWithValue("@Password", textBoxpassword.Password);

						cmd.ExecuteNonQuery();
					}

					// Show success message and transition to the next page
					TaskManagement taskManagement = new TaskManagement();
					taskManagement.Show();
					Close();
				}
				catch (Exception ex)
				{
					errormessage.Text = "Error: " + ex.Message;
				}
			}
		}

		private bool IsValidName(string name)
		{
			// Ensure the name contains only letters
			return name.All(char.IsLetter);
		}

		private bool IsValidPhoneNumber(string phoneNumber)
		{
			// Ensure the phone number is exactly 10 digits long and consists only of digits
			return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
		}

		private bool IsValidPassword(string password)
		{
			// Ensure the password contains at least one digit
			return password.Any(char.IsDigit);
		}




		private void button2_Click(object sender, RoutedEventArgs e)
		{
			textBoxFirstName.Clear();
			textBoxLastName.Clear();
			textBoxcellphone.Clear();
			textBoxpassword.Clear();
		}

		private void Login_Click(object sender, RoutedEventArgs e)
		{
		 
			VolunteerLogin volunteerLogin = new VolunteerLogin();
			volunteerLogin.Show();
			Close();



		}


	}
}
