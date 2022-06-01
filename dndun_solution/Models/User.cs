﻿using System;
using Microsoft.AspNetCore.Identity;

namespace dndun_solution.Models
{
	public class User:IdentityUser
	{
        public string? Role { get; set; }
        public string? FullName { get; set; }
        public string? DeviceToken { get; set; }
        public string? Status { get; set; }
        public string? Code { get; set; }
        public string? Gender { get; set; }
        public string? City { get; set; }
        public DateTime? Birth { get; set; }
        public double? Points { get; set; }
        public double? SurveysBalance { get; set; }
        public DateTime? CreatedAt { get; set; }
        public User() {
            CreatedAt = DateTime.UtcNow.AddHours(3);
            Status = "ACTIVE";
            Points = 0;
            SurveysBalance = 0;

        }
    }
}

