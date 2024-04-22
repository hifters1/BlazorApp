namespace BlazorApp2.Models
{
    public class Preference
    {
        //This model was used to create the table Users using the migration tool in PMC.
        public int PreferenceId { get; set; }         //Entity framework treats as primary key
        public string PreferenceValue { get; set; }   //Required for display purposes
        public virtual ICollection<User>? Users { get; set; }  //Creates a list of preferences for displaying
                                                               //Entity framework will load when needed

    }
}
