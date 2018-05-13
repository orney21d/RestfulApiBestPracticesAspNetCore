﻿using System;
using System.Collections.Generic;

namespace AspNetCoreWebApiSamples.Models
{
    public class AuthorForCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Genre { get; set; }

        public ICollection<BookForCreationDto> Books { get; set; } = new List<BookForCreationDto>();
    }
}