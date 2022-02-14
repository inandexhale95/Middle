using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Middle.Data.DataModels
{
    [Table("BoardContent")]
    public class BoardContent
    {
        [Key]
        public int ContentNo { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }

        [ForeignKey("UserId")]
        public BoardUser UserId { get; set; }
    }
}
