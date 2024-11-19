﻿namespace Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<string> Roles { get; set; } = [];
    }

}
