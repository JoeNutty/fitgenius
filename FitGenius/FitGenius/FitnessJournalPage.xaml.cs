using System;
using System.Collections.ObjectModel;
using System.IO;
using Xamarin.Forms;

namespace FitGenius
{
    public partial class FitnessJournalPage : ContentPage
    {
        private string filePath;
        private ObservableCollection<JournalEntry> journalEntries;

        public FitnessJournalPage()
        {
            InitializeComponent();
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "journal_entries.txt");
            journalEntries = new ObservableCollection<JournalEntry>();
            JournalEntriesListView.ItemsSource = journalEntries;
            ReadJournalEntries();
        }

        private void ReadJournalEntries()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var entryValues = line.Split(',');

                    if (entryValues.Length == 4)
                    {
                        var entry = new JournalEntry(
                            exerciseName: entryValues[0],
                            weight: double.Parse(entryValues[1]),
                            weightUnit: entryValues[2],
                            date: DateTime.Parse(entryValues[3]));

                        journalEntries.Add(entry);
                    }
                }
            }
        }


        private async void AddJournalEntryButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JournalCreationPage());
        }

    }
}
