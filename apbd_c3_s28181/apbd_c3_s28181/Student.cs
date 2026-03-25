namespace apbd_c3_s28181;

public class Student : Person
{
    public Student(string f, string l) : base(f, l) { }
    
    public override int MaxLoans => 2;
}