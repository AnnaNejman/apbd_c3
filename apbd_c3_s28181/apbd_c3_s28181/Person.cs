namespace apbd_c3_s28181;

public abstract class Person
{
    private static int _idCounter = 1;
    public int Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    protected Person(string firstName, string lastName)
    {
        Id = _idCounter++;
        FirstName = firstName;
        LastName = lastName;
    }
    public abstract int MaxLoans { get; }
}