﻿namespace FitTrackApp.WebAPI.DTOs
{
    public class AchievementUpsertDTO
    {
        public int Id { get; set; }
        public int? GoalId { get; set; }
        public DateTime? Date { get; set; }
        public int? AchievedTime { get; set; }
        public int? AchievedFrequency { get; set; }
        public bool? Achieved { get; set; }
    }
}
