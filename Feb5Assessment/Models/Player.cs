using System;
using System.Collections.Generic;

namespace Feb5Assessment.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public int? JerseyNo { get; set; }
        public string? Position { get; set; }
        public string? Team { get; set; }
    }
}
