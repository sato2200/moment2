using System.ComponentModel.DataAnnotations;

namespace moment2.Models;

 public class PlaylistModel
{
    public PlaylistModel()
    {
        Tags = new List<string>();
    }

    //String för song. Obligatorisk och felmeddelande 
    [Required(ErrorMessage = "Please enter a song name")]
    public string? Song { get; set; }

    //String för album. Obligatorisk och felmeddelande 
    [Required(ErrorMessage = "Please enter an album name")]
    public string? Album { get; set; }

    //String för albumversion. Obligatorisk och felmeddelande 
    [Required(ErrorMessage = "Please select a Album version")]
    public string? AlbumVersion { get; set; }


    //int för år. Obligatorisk, begränsad mellan åren 1989-9999, felmeddelande
    [Required]
    [Range(1989, 9999, ErrorMessage = "Please enter a valid year")]
    public int Year { get; set; }

    //String för genre. Obligatorisk och felmeddelande 
    [Required(ErrorMessage = "Please select a genre")]
    public string? Genre { get; set; }

    //Tags för feelings.
    public List<string> Tags { get; set; } = new List<string>();
}