using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Personeel.Shared;

namespace Personeel.WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Employee employee;

    public MainWindow()
    {
        InitializeComponent();
        employee = new Employee();

        MessageBoxResult result =
            MessageBox.Show("Starten met ingevulde waarden?", "Start", MessageBoxButton.YesNo, MessageBoxImage.Question);

        if (result == MessageBoxResult.Yes)
        {
            //Example data:
            firstNameTextBox.Text = "John";
            lastNameTextBox.Text = "Doe";
            startYearTextBox.Text = "2010";
            sexComboBox.SelectedIndex = 0;
        }
        else if (result == MessageBoxResult.No)
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            startYearTextBox.Text = "2000";
            sexComboBox.SelectedIndex = 0;
            firstNameTextBox.Focus();
        }

        ProcessInput();
    }

    private void OnIncreaseScore_Clicked(object sender, RoutedEventArgs e)
    {
        employee.IncreaseScore();
        resultTextBox.Text = employee.ShowSummary();
    }

    private void OnDecreaseScore_Clicked(object sender, RoutedEventArgs e)
    {
        employee.DecreaseScore();
        resultTextBox.Text = employee.ShowSummary();
    }



    private void OnInput_LostFocus(object sender, RoutedEventArgs e)
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        try
        {
            employee.FirstName = firstNameTextBox.Text;
            employee.LastName = lastNameTextBox.Text;
            if (int.TryParse(startYearTextBox.Text, out int year))
            {
                employee.StartYear = year;
            }
            if (char.TryParse(((ComboBoxItem)sexComboBox.SelectedItem).Content.ToString(), out char sex))
            {
                employee.Sex = sex;
            }

            resultTextBox.Text = employee.ShowSummary();
        }
        catch (Exception)
        {
            MessageBox.Show("Onverwachte fout", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}