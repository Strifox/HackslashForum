﻿using HackslashForum.Models;
using System;

namespace HackslashForum
{
    public class Comment
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime DateTimeCommentMade { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }

        public ApplicationUser User { get; set; }
        public Post Post { get; set; }

    }
}