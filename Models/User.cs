using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class User
    {
        //This model was used to create the table Users using the migration tool in PMC.
        [Key]
        public int Id { get; set; }         //Entity framework treats as primary key
        [Required]
        public string UserName { get; set; }    //Required for display purposes
        public int? PreferenceId { get; set; }  //Have decided that this field is not needed
        public string? PreferenceValue { get; set; }  //Display name of preference
        public ICollection<Preference> Preferences { get; set; }  //Single instance to Preferences

    }
}
