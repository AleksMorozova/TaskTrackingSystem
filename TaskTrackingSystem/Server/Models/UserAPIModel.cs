﻿using System;

namespace Server.Models
{
    public class UserAPIModel
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}