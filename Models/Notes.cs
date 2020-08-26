using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotesApi.Models
{
    public partial class Notes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NoteText { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime DateCreated { get; set; }
    }
}
