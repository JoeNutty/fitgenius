using System;
using System.IO;
using Xamarin.Forms;

namespace FitGenius
{
    public partial class JournalCreationPage : ContentPage
    {
        private string filePath;

        public JournalCreationPage()
        {
            InitializeComponent();
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "journal_entries.txt");
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ExerciseNameEntry.Text) || string.IsNullOrEmpty(WeightEntry.Text) || UnitOfMeasurementPicker.SelectedIndex == -1 || EntryDatePicker.Date == null)
            {
                DisplayAlert("Error", "Please fill in all fields", "OK");
                return;
            }

            string entryString = string.Format("{0},{1},{2},{3}", ExerciseNameEntry.Text, WeightEntry.Text, UnitOfMeasurementPicker.SelectedItem.ToString(), EntryDatePicker.Date.ToString());
            File.AppendAllText(filePath, entryString + Environment.NewLine);

            Navigation.PopAsync();
        }
    }
}
