using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComiCore.Model
{
    public class Movies : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Manufacture { get; set; }
        public string Status { get; set; }
        public int Episode { get; set; }
        public string Path { get; set; }
        public Quality Quality { get; set; }
        public DateTime Time { get; set; }
        public string Country { get; set; }
        public Language Language { get; set; }
        public Kind Kind { get; set; }
        public virtual ICollection<GenreMovies> GenresMovies { get; set; }
        public virtual ICollection<MoviesDirector> MoviesDirectors { get; set; }
        public virtual ICollection<MoviesActor> MoviesActors { get; set; }
        public virtual ICollection<Trailer> Trailers { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
    public enum Quality
    {
        HD,
        HDRip
    }
    public enum Language
    {
        [Display(Name = "Tiếng Việt")]
        Vietnamese,
        [Display(Name = "Thuyết minh")]
        ThuyetMinh,
        [Display(Name = "Lồng tiếng")]
        LongTieng,
        VietSub
    }
    public enum Kind
    {
        [Display(Name = "Phim lẻ")]
        PhimLe,
        [Display(Name = "Phim bộ")]
        PhimBo,
        [Display(Name = "Phim chiếu rạp")]
        PhimChieuRap
    }
}
