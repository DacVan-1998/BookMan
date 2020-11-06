using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMan.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required, DisplayName("Tiêu đề")]
        public string Name { get; set; }

        [Required, DisplayName("Tác giả")]
        public string Authors { get; set; }

        [Required, DisplayName("Nhà xuất bản")]
        public string Publisher { get; set; }

        [Required, DisplayName("Năm xuất bản"), Range(1990, 2020)]
        public int Year { get; set; }

        [DisplayName("Tóm tắt")]
        public string Description { get; set; }
    }
}
