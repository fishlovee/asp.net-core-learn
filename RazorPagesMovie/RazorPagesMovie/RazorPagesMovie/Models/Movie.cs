using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;




namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name ="电影名")]
        public string Titile { get; set; }

        [Display(Name = "发行日期")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "描述")]
        public string Genre { get; set; }

        [Display(Name = "发行价")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
