﻿namespace XblApp.Shared.DTOs
{
    public class GameDTO
    {
        public long GameId { get; set; }
        public string? GameName { get; set; }
        public int TotalAchievements { get; set; }
        public int TotalGamerscore { get; set; }
        public int TotalGamers { get; set; }
    }
}
