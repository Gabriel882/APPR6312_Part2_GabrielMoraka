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
using System.Windows.Shapes;

namespace APPR6312_Part2_GabrielMoraka
{
	/// <summary>
	/// Interaction logic for LoginPage.xaml
	/// </summary>
	public partial class LoginPage : Window
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		ChooseOption chooseOption = new ChooseOption();


		private void button1_Click(object sender, RoutedEventArgs e)
		{

			if (textBoxUserName.Text.Length == 0)
			{
				errormessage.Text = "Enter a User Name .";
				textBoxUserName.Focus();
			}

			else if (!Regex.IsMatch(textBoxUserName.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9][\w\.-]$"))
			{
				errormessage.Text = "Enter the correct User Name.";
				textBoxUserName.Select(0, textBoxUserName.Text.Length);
				textBoxUserName.Focus();
			}

			else
			{
				string UserName = textBoxUserName.Text;
				string password = passwordBox1.Password;


				string connectionString = "Server=tcp:st10180168.database.windows.net,1433;Initial Catalog=AppliedProgramming;Persist Security Info=False;User ID=ST10180168;Password=GABKUTmor5%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

				using (SqlConnection con = new SqlConnection(connectionString))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand("SELECT * FROM Registration WHERE UserName = @UserName AND Password = @Password", con))
					{
						cmd.Parameters.AddWithValue("@UserName", UserName);
						cmd.Parameters.AddWithValue("@Password", password); // Consider hashing the password before comparison

						SqlDataAdapter adapter = new SqlDataAdapter(cmd);
						DataSet dataSet = new DataSet();
						adapter.Fill(dataSet);

						if (dataSet.Tables[0].Rows.Count > 0)
						{
							string username = dataSet.Tables[0].Rows[0]["FirstName"].ToString() + " " + dataSet.Tables[0].Rows[0]["LastName"].ToString();
							chooseOption.TextBlockName.Text = username;
							chooseOption.Show();
							Close();
						}
						else
						{
							errormessage.Text = "Sorry! Please enter existing UserName/password.";
						}
					}
				}
			}

		}

		private void RegisterLink_Click(object sender, RoutedEventArgs e)
		{

			MainWindow maninwindow = new MainWindow();
			maninwindow.Show();
			Close();
		}


	}
}
