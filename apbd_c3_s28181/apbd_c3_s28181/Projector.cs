namespace apbd_c3_s28181;

public class Projector:Equipment
{
    public int a {get; set;}
    public int b {get; set;}

    public Projector(string name, int a, int b) : base(name)
    {
        this.a = a;
        this.b = b;
    }
}