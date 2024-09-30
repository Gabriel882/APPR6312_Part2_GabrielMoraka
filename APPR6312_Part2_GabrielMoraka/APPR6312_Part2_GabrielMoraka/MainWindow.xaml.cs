using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace APPR6312_Part2_GabrielMoraka
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public void Button_Click(object sender, RoutedEventArgs e)
		{
			LoginPage login = new LoginPage();
			login.Show();
			Close();
		}

		public void Submit_Click(object sender, RoutedEventArgs e)
		{




			if (!Regex.IsMatch(textBoxFirstName.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9][\w\.-]$"))
			{
				string firstname = textBoxFirstName.Text;
				string lastname = textBoxLastName.Text;
				string username = textBoxUserName.Text;
				string password = passwordBox1.Password;

				errormessage.Text = "Enter a Name with no numbers no special characters";
				textBoxFirstName.Select(0, textBoxFirstName.Text.Length);
				textBoxFirstName.Focus();
			}



			else if (textBoxLastName.Text.Length == 0)
			{
				errormessage.Text = "Enter a Surname Name";
				textBoxLastName.Focus();
			}

			if (textBoxUserName.Text.Length == 3)
			{
				errormessage.Text = "Enter an User Name, with One Number";
				textBoxUserName.Focus();
			}


			else if (!Regex.IsMatch(textBoxUserName.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9][\w\.-]$"))
			{




				errormessage.Text = "Enter a user Name, No special characters .";
				textBoxUserName.Select(0, textBoxUserName.Text.Length);
				textBoxUserName.Focus();

			}
			else
			{
				string firstname = textBoxFirstName.Text;
				string lastname = textBoxLastName.Text;
				string username = textBoxUserName.Text;
				string password = passwordBox1.Password;

				if (passwordBox1.Password.Length == 0)
				{
					errormessage.Text = "Enter password.";
					passwordBox1.Focus();
				}
				else if (passwordBoxConfirm.Password.Length == 0)
				{
					errormessage.Text = "Enter Confirm password.";
					passwordBoxConfirm.Focus();
				}
				else if (passwordBox1.Password != passwordBoxConfirm.Password)
				{
					errormessage.Text = "Confirm password must be same as password.";
					passwordBoxConfirm.Focus();
				}
				else
				{
					errormessage.Text = "";
					string connectionString = "Server=tcp:st10180168.database.windows.net,1433;Initial Catalog=AppliedProgramming;Persist Security Info=False;User ID=ST10180168;Password=GABKUTmor5%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

					using (SqlConnection con = new SqlConnection(connectionString))
					{
						con.Open();
						using (SqlCommand cmd = new SqlCommand("INSERT INTO Registration (FirstName, LastName, UserName, Password) VALUES (@FirstName, @LastName, @UserName, @Password)", con))
						{
							cmd.Parameters.AddWithValue("@FirstName", firstname);
							cmd.Parameters.AddWithValue("@LastName", lastname);
							cmd.Parameters.AddWithValue("@UserName", username);
							cmd.Parameters.AddWithValue("@Password", password); // Consider hashing the password
							cmd.ExecuteNonQuery();
						}
					}
					errormessage.Text = "You have Registered successfully. Process to login";

				}
			}
		}

		private void button2_Click(object sender, RoutedEventArgs e)
		{

			textBoxFirstName.Clear();
			textBoxLastName.Clear();
			textBoxUserName.Clear();
			passwordBox1.Clear();
			passwordBoxConfirm.Clear();



		}

		private void button3_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

	}
}
