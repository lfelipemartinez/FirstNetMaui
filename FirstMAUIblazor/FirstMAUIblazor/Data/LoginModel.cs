using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMAUIblazor.Data
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Field required")]
        [StringLength(50,ErrorMessage ="Maximum character belowed is 50")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Field required")]
        [StringLength(50, ErrorMessage = "Maximum character belowed is 50")]

        public string Password { get; set; }
        public string Email { get; set; }
    }
}
