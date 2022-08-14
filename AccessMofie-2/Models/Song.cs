using System;
using System.Collections.Generic;
using System.Text;

namespace AccessMofie_2.Models
{
    class Song
    {
        private string _name;
        private string _genre;
        //private string _singer;
        public double Rating;
        public double NewRating;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length>=100)
                {
                    _name = value;
                }
            }
        }
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                switch (value)
                {
                    case "Pop":
                    case "Rock":
                    case "Jazz":
                    _genre = value;
                    break;
                }
            }
        }
        public Singer Singer { get; set; }
        public void AddRating(double Rating)
        {
          
        }
        public double GetAverageRating()
        {
            return 0;
        }
    }
}
