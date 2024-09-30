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
	/// Interaction logic for ManageProfile.xaml
	/// </summary>
	public partial class ManageProfile : Window



	{
		private string connectionString = "Server=tcp:st10180168.database.windows.net,1433;Initial Catalog=AppliedProgramming;Persist Security Info=False;User ID=ST10180168;Password=GABKUTmor5%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

		public ManageProfile()
		{
			InitializeComponent();
		}

		private void UpdateButton_Click(object sender, RoutedEventArgs e)
		{
			// Validate inputs
			if (string.IsNullOrWhiteSpace(NameTextBox.Text))
			{
				StatusMessage.Text = "Please enter a valid name.";
				return;
			}

			if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
			{
				StatusMessage.Text = "Please enter a valid username.";
				return;
			}

			if (string.IsNullOrWhiteSpace(NewPasswordBox.Password))
			{
				StatusMessage.Text = "Please enter a new password.";
				return;
			}

			if (NewPasswordBox.Password != ConfirmPasswordBox.Password)
			{
				StatusMessage.Text = "Passwords do not match.";
				return;
			}

			// Update the profile in the database
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					string query = "UPDATE Registration SET FirstName = @FirstName, Password = @Password WHERE UserName = @CurrentUserName";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@FirstName", NameTextBox.Text);
						command.Parameters.AddWithValue("@Password", NewPasswordBox.Password); 
						command.Parameters.AddWithValue("@CurrentUserName", UsernameTextBox.Text); // Current username is now the one being updated

						int rowsAffected = command.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							StatusMessage.Text = "Profile updated successfully!";
						}
						else
						{
							StatusMessage.Text = "Profile update failed. Username not found.";
						}
					}
				}
				catch (Exception ex)
				{
					StatusMessage.Text = $"Error: {ex.Message}";
				}
				finally
				{
					connection.Close();
				}
			}

			ClearFields();
		}

		// Method to delete user account
		private void DeleteAccountButton_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButton.YesNo, MessageBoxImage.Warning);

			if (result == MessageBoxResult.Yes)
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					try
					{
						connection.Open();
						string query = "DELETE FROM Registration WHERE UserName = @UserName";

						using (SqlCommand command = new SqlCommand(query, connection))
						{
							command.Parameters.AddWithValue("@UserName", UsernameTextBox.Text); // Replace with actual current username

							int rowsAffected = command.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								StatusMessage.Text = "Account deleted successfully!";
							}
							else
							{
								StatusMessage.Text = "Account deletion failed. Username not found.";
							}
						}
					}
					catch (Exception ex)
					{
						StatusMessage.Text = $"Error: {ex.Message}";
					}
					finally
					{
						connection.Close();
					}
				}
			}
		}

		private void ClearFields()
		{
			NameTextBox.Clear();
			UsernameTextBox.Clear();
			NewPasswordBox.Clear();
			ConfirmPasswordBox.Clear();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ChooseOption chooseOption = new ChooseOption();
			chooseOption.Show();
			Close();

		}
	}

}

