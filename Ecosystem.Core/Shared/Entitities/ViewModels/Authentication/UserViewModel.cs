﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Shared.Entitities.ViewModels.Authentication
{
    public class UserViewModel: IViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [MaxLength(512)]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}
