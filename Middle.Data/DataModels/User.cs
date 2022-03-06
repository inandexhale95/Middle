using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Middle.Data.DataModels
{
    public class User
    {
        [Key]
        public int UserNo { get; set; }
        [MinLength(4, ErrorMessage = "아이디는 4자 이상 입력해주세요.")]
        [Required(ErrorMessage = "아이디를 입력해주세요.")]
        public string UserId { get; set; }
        [MinLength(6, ErrorMessage = "비밀번호는 6자 이상 입력해주세요.")]
        [Required(ErrorMessage = "비밀번호를 입력해주세요.")]
        public string UserPassword { get; set; }
    }
}
