namespace BlazorApp2.Models
{
    public class User
    {
        //This model was used to create the table Users using the migration tool in PMC.
        public int UserId { get; set; }         //Entity framework treats as primary key
        public string UserName { get; set; }    //Required for display purposes
        public int? PreferenceId { get; set; }  //Have decided that this field is not needed
        public string? PreferenceValue { get; set; }  //Display name of preference
        public virtual Preference? Preferences { get; set; }  //Single instance to Preferences

    }
}
