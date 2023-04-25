using System;

namespace FitGenius
{
    public class JournalEntry
    {
        public string ExerciseName { get; set; }
        public double Weight { get; set; }
        public string WeightUnit { get; set; }
        public DateTime Date { get; set; }

        public JournalEntry(string exerciseName, double weight, string weightUnit, DateTime date)
        {
            ExerciseName = exerciseName;
            Weight = weight;
            WeightUnit = weightUnit;
            Date = date;
        }

        public string WeightMeasurement
        {
            get { return $"{Weight:N1} {WeightUnit}"; }
        }
    }
}
