using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Middle.Data.DataModels
{
    public class GuestBoard
    {
        [Key]
        public int Id { get; set; }
        [MinLength(2, ErrorMessage = "두자리 이상 입력해주세요.")]
        [Required(ErrorMessage = "이름을 입력해주세요.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "내용을 입력해주세요.")]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
