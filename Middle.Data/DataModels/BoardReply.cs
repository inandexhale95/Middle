using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Middle.Data.DataModels
{
    [Table("BoardReply")]
    public class BoardReply
    {
        [Key]
        public int ReplyNo { get; set; }
        [Required]
        public string ReplyContent { get; set; }
        public DateTime CreateDate { get; set; }

        [ForeignKey("ContentNo")]
        public BoardContent ContentNo { get; set; }
    }
}
