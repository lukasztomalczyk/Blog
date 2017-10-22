using System;
using DataAccessLayer.Models;

namespace BussinesLayer.Objects
{
    public class PostObject
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public DateTime DataTime { get; set; }
        public int CurrentUserId { get; set; }
        public User CurrentUser { get; set; }
    }
}