﻿using Microsoft.AspNetCore.Identity;

namespace AfriLearnBackend.Models
{
    public class AppUser : IdentityUser
    {
        public bool TermsAndConditionsChecked { get; set; }
        public string StudyLevel { get; set; }
        public bool IsSignedIn { get; set; }
        public string ProfilePhotoPath { get; set; }
        public string Institution { get; set; }
        public string Role { get; set; }
        public Setting Setting { get; set; }
    }
}
