﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tweetbook.Domain
{
    public class Tag
    {
        [Key]
        public string Name { get; set; }
        public string CreatorId { get; set; }
        [ForeignKey(nameof(CreatorId))]
        public IdentityUser CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
