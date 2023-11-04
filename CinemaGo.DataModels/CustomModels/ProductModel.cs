using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaGo.DataModels.CustomModels
{
    public  class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage= "*Product Name is required")]

        public string Name { get; set; }

        [Required(ErrorMessage= "*Product Price is required")]

        public int? Price { get; set; }

        [Required(ErrorMessage="*Product Stock is required")]

        public int? Stock { get; set; }

        [Required(ErrorMessage ="*Product Cinema is required")]

        public int? CinemaId { get; set; }

        public string CinemaName { get; set; }

        [Required(ErrorMessage = "*Product Category is required")]
        public int? CategoryId { get; set; }

        public string CategoryName { get; set; }

        [Required(ErrorMessage = "*Product Description is required")]

        public string Description { get; set; }

        [Required(ErrorMessage = "*Product Date is required")]

        public string Date { get; set; }

        [Required(ErrorMessage = "*Product Hour is required")]

        public int? Hour { get; set; }

        [Required(ErrorMessage = "*Product Minute is required")]

        public int? Minute { get; set; }

        [Required(ErrorMessage = "*Product TrailerUrl is required")]

        public string TrailerUrl { get; set; }

        [Required(ErrorMessage = "*Product Language is required")]

        public string Language { get; set; }

        [Required(ErrorMessage = "*Product ReleaseDate is required")]

        public string ReleaseDate { get; set; }

        [Required(ErrorMessage = "*Product RunningTime is required")]

        public string RunningTime { get; set; }

        [Required(ErrorMessage = "*Product Status is required")]

        public string Status { get; set; }


        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="*Kindly Upload Product Photo")]

        public string FileName { get; set; }

        public byte[] FileContent { get; set; }

        public bool CartFlag { get; set; }
    }
}
