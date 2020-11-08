using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_8.Models
{
   public class User
   {
      //   F i e l d s   &   P r o p e r t i e s

      public int Id { get; set; }
      [Required(ErrorMessage = "First Name Required")]
      public string Fname { get; set; }
      [Required(ErrorMessage = "Last Name Required")]
      public string Lname { get; set; }
      [Required(ErrorMessage = "UserName Invalid")]
      public string Uname { get; set; }
      //Title name will be set to N/a if left blank.
      public string Tname {get; set; }
      [Required(ErrorMessage = "Email is required")]
      public string Email { get; set; }
      [Required(ErrorMessage = "Please Confirm Email")]
      public string CEmail { get; set; }
      [Required(ErrorMessage = "Password is Required")]
      public string Password { get; set; }
      [Required(ErrorMessage = "Please Confirm Email")]
      public string CPassword { get; set; }


      //   C o n s t r u c t o r s

      //   M e t h o d s
   }
}
