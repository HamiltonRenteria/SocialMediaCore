using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaCore.Core.DTOs
{
    public class ComentDTO
    {
        public int ComentId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }
}
