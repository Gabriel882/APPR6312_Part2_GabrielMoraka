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
	/// Interaction logic for VolunteerLogin.xaml
	/// </summary>
	public partial class VolunteerLogin : Window
	{
		public VolunteerLogin()
		{
			InitializeComponent();
		}



		private void button1_Click(object sender, RoutedEventArgs e)
		
		{
			// Retrieve user input
			string firstName = textBoxName.Text; // Assuming you have a TextBox for the first name
			string password = password1.Password; // Assuming you have a PasswordBox for the password

			// Connection string
			string connectionString = "Server=tcp:st10180168.database.windows.net,1433;Initial Catalog=AppliedProgramming;Persist Security Info=False;User ID=ST10180168;Password=GABKUTmor5%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();
					// Use a parameterized query to avoid SQL injection
					using (SqlCommand cmd = new SqlCommand("SELECT Password FROM VolunteerRegistration WHERE FirstName = @FirstName", con))
					{
						cmd.Parameters.AddWithValue("@FirstName", firstName);

						// Execute the command
						string Password = (string)cmd.ExecuteScalar();

						if (Password == password)
						{
							// Password is correct, proceed with login
							TaskManagement taskManagement = new TaskManagement();
							taskManagement.Show();
							Close();
						}
						else
						{
							// Incorrect password or username
							errormessage.Text = "Invalid first Name or password. Enter correct details";
						}
					}
				}
				catch (Exception ex)
				{
					errormessage.Text = "Error: " + ex.Message;
				}
			}
		}

		private void Register_Click(object sender, RoutedEventArgs e)
		{
			RegisterVolunteer registerVolunteer = new RegisterVolunteer();
			registerVolunteer.Show();
			Close();
		}


	}
}
