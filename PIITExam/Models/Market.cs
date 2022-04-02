using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIITExam.Models
{
    public class Market
    {
        [DisplayName("Id")]
        [Required(ErrorMessage = "Please enter Id")]
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }
        [DisplayName("BaseAsset")]
        [Required(ErrorMessage = "Please enter BaseAsset")]
        public string BaseAsset { get; set; }
        [DisplayName("QuoteAsset")]
        [Required(ErrorMessage = "Please enter QuoteAsset")]
        public string QuoteAsset { get; set; }
        [DisplayName("LastPrice")]
        [Required(ErrorMessage = "Please enter LastPrice")]
        public string LastPrice { get; set; }
        [DisplayName("Volumn24h")]
        [Required(ErrorMessage = "Please enter Volumn24h")]
        public string Volumn24h { get; set; }
        [DisplayName("MarketId")]
        [Required(ErrorMessage = "Please enter MarketId")]
        public int MarketId { get; set; }
        [DisplayName("CreateAt")]
        [Required(ErrorMessage = "Please enter CreateAt")]
        public DateTimeKind CreateAt { get; set; }
        [DisplayName("UpdateAt")]
        [Required(ErrorMessage = "Please enter UpdateAt")]
        public DateTime UpdateAt { get; set; }
        [DisplayName("Status")]
        [Required(ErrorMessage = "Please enter Status")]
        public int Status { get; set; }
    }
}