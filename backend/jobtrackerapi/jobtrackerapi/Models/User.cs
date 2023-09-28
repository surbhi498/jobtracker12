﻿using System;

namespace jobtrackerapi.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName {get;set;}

        public string? Email { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
