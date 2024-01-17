namespace ClassLibrary
{
    public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public People(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }
        public virtual string ShowInfo()
        {
            return $"{LastName} {FirstName} {DateOfBirth}";
        }

    }
}