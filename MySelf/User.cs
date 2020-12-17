using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MySelf
{
    [Table("Register")]
   public  class User
    {
        public int Id { get; set; }
        [Column("UserName")]
        [MaxLength(256)]
        [Key]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsFamle { get; set; }
        public int FailedTry { get; set; }
    }
}
