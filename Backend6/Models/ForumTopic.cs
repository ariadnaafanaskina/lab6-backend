﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend6.Models
{
    public class ForumTopic
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public String CreatorId { get; set; }
        public ApplicationUser Creator { get; set; }
        public Guid ForumId { get; set; }
        public Forum Forum { get; set; }
        public DateTime Created { get; set; }

        [Required]
        [MaxLength(200)]
        public String Name { get; set; }
        public ICollection<ForumMessage> ForumMessages { get; set; }

    }
}
