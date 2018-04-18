﻿using HackslashForum.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackslashForum
{
    public enum Category
    {
        [Display(Name = "Diskussion")]
        Discussion,
        [Display(Name = "Fråga")]
        Question
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateTimePostCreated { get; set; } = DateTime.Now;
        public Category Category { get; set; }
        public string Content { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }

        public IList<Comment> Comments { get; set; }
        public ApplicationUser User { get; set; }
    }
}
