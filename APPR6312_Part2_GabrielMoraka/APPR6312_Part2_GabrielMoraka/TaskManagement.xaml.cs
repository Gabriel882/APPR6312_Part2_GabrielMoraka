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
	/// Interaction logic for TaskManagement.xaml
	/// </summary>
	public partial class TaskManagement : Window
	{
		public TaskManagement()
		{
			InitializeComponent();
		}


		private void LoadTasks()
		{
			// Example data loading
			var tasks = new List<Task>
			{
				new Task { TaskName = "Distribute Food", TaskDescription = "Distribute food to affected areas.", DueDate = DateTime.Now.AddDays(1) },
				new Task { TaskName = "Set Up Shelter", TaskDescription = "Set up temporary shelters.", DueDate = DateTime.Now.AddDays(3) },
				new Task { TaskName = "Distribution of clothing", TaskDescription = "Distribute clothing to affected areas.", DueDate = DateTime.Now.AddDays(1) },
				new Task { TaskName = "Medical Assistance", TaskDescription = "Distribute medical to affected areas.", DueDate = DateTime.Now.AddDays(1) },
				new Task { TaskName = "Clean-Up and Restoration", TaskDescription = "Help clean up and restore homes.", DueDate = DateTime.Now.AddDays(3) },
				
			};

			TasksListView.ItemsSource = tasks;
			TasksComboBox.ItemsSource = tasks;
			TasksDataGrid.ItemsSource = tasks;
		}

		private void LoadVolunteers()
		{
			// Example data loading
			var volunteers = new List<Volunteer>
			{
				new Volunteer { VolunteerName = "John Doe" },
				new Volunteer { VolunteerName = "Jane Smith" },
				new Volunteer { VolunteerName = "Dave Jen" },
				new Volunteer { VolunteerName = "Johnny Bravo" },
				new Volunteer { VolunteerName = "Adam Kim" },
				new Volunteer { VolunteerName = "Zeus Patel" }
			};

			VolunteersComboBox.ItemsSource = volunteers;
			VolunteersMessageComboBox.ItemsSource = volunteers;
		}

		private void Refresh_Click(object sender, RoutedEventArgs e)
		{
			// Refresh data
			LoadTasks();
			LoadVolunteers();
		}

		private void Logout_Click(object sender, RoutedEventArgs e)
		{
			// Handle logout logic
			ChooseOption chooseOption = new ChooseOption();
			chooseOption.Show();
			Close();
		}

		private void AssignTask_Click(object sender, RoutedEventArgs e)
		{
			// Logic to assign selected task to selected volunteer
			var selectedTask = (Task)TasksComboBox.SelectedItem;
			var selectedVolunteer = (Volunteer)VolunteersComboBox.SelectedItem;

			if (selectedTask != null && selectedVolunteer != null)
			{
				MessageBox.Show($"Task '{selectedTask.TaskName}' assigned to '{selectedVolunteer.VolunteerName}'");
				// Update task assignments here
			}
			else
			{
				MessageBox.Show("Please select both a task and a volunteer.");
			}
		}

		private void SendMessage_Click(object sender, RoutedEventArgs e)
		{
			// Logic to send message to selected volunteer
			var selectedVolunteer = (Volunteer)VolunteersMessageComboBox.SelectedItem;
			var message = MessageTextBox.Text;

			if (selectedVolunteer != null && !string.IsNullOrEmpty(message))
			{
				MessageBox.Show($"Message sent to '{selectedVolunteer.VolunteerName}': {message}");
				// Send message logic here
			}
			else
			{
				MessageBox.Show("Please select a volunteer and enter a message.");
			}
		}
	}

	public class Task
	{
		public string TaskName { get; set; }
		public string TaskDescription { get; set; }
		public DateTime DueDate { get; set; }
		public string AssignedTo { get; set; } // This could be updated when assigning tasks
	}

	public class Volunteer
	{
		public string VolunteerName { get; set; }
	}
}
	

