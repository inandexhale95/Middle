using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Middle.Data.DataModels
{
    [Table("BoardUser")]
    public class BoardUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2), MaxLength(15)]
        [Display()]
        public string Name { get; set; }
        [Required]
        [MinLength(6), MaxLength(20)]
        public string Password { get; set; }
    }
}
