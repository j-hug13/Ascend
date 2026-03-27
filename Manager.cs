using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Ascend
{
    public static class Manager
    {
        public static ObservableCollection<Workout> WorkoutHistory { get; set; } = new();

        public static int Strength { get; set; } = 0;
        public static int Agility { get; set; } = 0;
        public static int Dexterity { get; set; } = 0;
        public static int Endurance { get; set; } = 0;

        public static int Level { get; set; } = 0;
        public static int Experience { get; set; } = 0;
        public static int XPToNextLevel { get; set; } = 100;

        public static void LogWorkout(Workout workout)
        {
            WorkoutHistory.Add(workout);

            switch(workout.Category)
            {
                case "Strength Training":
                    Strength += 1;
                    Experience += 20;
                    break;
                case "Cardio":
                    Agility += 1;
                    Experience += 20;
                    break;
                case "Flexibility":
                    Dexterity += 1;
                    Experience += 20;
                    break;
                default:
                    Endurance += 1;
                    Experience += 20;
                    break;
            }

            while (Experience >= XPToNextLevel)
            {
                Experience -= XPToNextLevel;
                Level += 1;
                XPToNextLevel = (int)(XPToNextLevel * 1.5);
            }
        }

        public static void RemoveWorkout(Workout workout)
        {
            if (WorkoutHistory.Contains(workout) == false) return;

            WorkoutHistory.Remove(workout);
            int removeXP = 0;

            switch (workout.Category)
            {
                case "Strength Training":
                    Strength -= 1;
                    removeXP = 20;
                    break;
                case "Cardio":
                    Agility -= 1;
                    removeXP = 20;
                    break;
                case "Flexibility":
                    Dexterity -= 1;
                    removeXP = 20;
                    break;
                default:
                    Endurance -= 1;
                    removeXP = 20;
                    break;
            }

            Experience -= removeXP;

            if (Experience < 0 && Level > 1)
            {
                Level -= 1;
                Experience = XPToNextLevel - removeXP;
            }
        }
    }
}
