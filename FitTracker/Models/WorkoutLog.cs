namespace FitTracker.Models
{
    public class WorkoutLog
    {
        public string WorkoutType { get; set; }
        public int Duration { get; set; } // in minutes
        public DateTime Date { get; set; }
    }
}
