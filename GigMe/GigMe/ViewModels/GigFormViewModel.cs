using System.Collections.Generic;
using GigMe.Models;

namespace GigMe.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; } //Need numeric value for each option
        public IEnumerable<Genre> Genres { get; set; }
    }
}