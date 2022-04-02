using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIITExam.Models
{
    public class Coin
    {
        [DisplayName("Id")]
        [Required(ErrorMessage = "Please enter Id")]
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "Please enter Description")]
        public string Description { get; set; }
        [DisplayName("CreatAt")]
        [Required(ErrorMessage = "Please enter CreateAt")]
        public DateTime CreateAt { get; set; }
        [DisplayName("UpdateAt")]
        [Required(ErrorMessage = "Please enter UpdateAt")]
        public DateTime UpdateAt { get; set; }
        [DisplayName("Status")]
        [Required(ErrorMessage = "Please enter Status")]
        public int Status { get; set; }
    }
}