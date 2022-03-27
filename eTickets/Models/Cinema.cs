using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="LOGO")]
        public string Logo { get; set; }
        [Display(Name = "NAME")]
        public string Name { get; set; }
        [Display(Name = "DESCRIPTION")]

        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
