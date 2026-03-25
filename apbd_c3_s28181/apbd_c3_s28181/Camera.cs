namespace apbd_c3_s28181;

public class Camera:Equipment
{
    public int pixels {get; set;}
    public bool digital {get; set;}

    public Camera(string name, int pixels, bool digital) : base(name)
    {
        this.pixels = pixels;
        this.digital = digital;
    }
}