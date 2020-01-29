namespace MediaChill.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;
    using System.IO;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Collections.Generic;

    public enum Genre { 
        Humour, 
        Science_Fiction,
        Action,
        Horreur,
        Animation,
        Romantique,
        Thriller
    };
    public class Model1 : DbContext
    {
        
        public Model1()
            : base("name=Model1")
        {
        }

        
         public virtual DbSet<Film> Films { get; set; }
    }

    public class Film
    {
        public Film() { }

        public Film(string title, string realName, Genre genre, int duration, string image, string video)
        {
            Title = title;
            RealName = realName;
            Genre = genre;
            Duration = duration;
            Image = image;
            Video = video;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        
        public string RealName { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public int Duration { get; set; }
        public int note { get; set; }
        public int Compteur { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        
        

    }
}