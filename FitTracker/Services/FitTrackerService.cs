using FitTracker.Models;

namespace FitTracker.Services
{
    public class FitTrackerService
    {
        public UserProfile UserProfile { get; set; } = new UserProfile();
        public List<WorkoutLog> Workouts { get; set; } = new List<WorkoutLog>();
        public List<Goal> Goals { get; set; } = new List<Goal>();

        public void AddWorkout(WorkoutLog workout)
        {
            workout.Date = DateTime.Now;
            Workouts.Add(workout);
        }

        public void AddGoal(Goal goal)
        {
            Goals.Add(goal);
        }

        public void UpdateGoalProgress(string description, int progress)
        {
            var goal = Goals.Find(g => g.Description == description);
            if (goal != null)
            {
                goal.Progress += progress;
            }
        }
    }
}
