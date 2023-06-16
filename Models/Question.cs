namespace LIT.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string SomeQuestion { get; set; }
        public string SomeAnswer { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Question()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {    
        }
    }
}
