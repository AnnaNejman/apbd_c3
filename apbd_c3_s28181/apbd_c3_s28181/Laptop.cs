
namespace apbd_c3_s28181;

public class Laptop: Equipment
{
    public int ram {get; set;}
    public string cpu {get; set;}

    public Laptop(string name, int ram, string cpu) : base(name)
    {
        this.ram = ram;
        this.cpu = cpu;
    }
}