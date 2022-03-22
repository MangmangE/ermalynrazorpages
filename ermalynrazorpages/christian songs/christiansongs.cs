using System.ComponentModel.DataAnnotations;
namespace ermalynrazorpages.christian_songs
{
    public class christiansongs
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
       public  string Price{ get; set; } = string.Empty;
    }
}
