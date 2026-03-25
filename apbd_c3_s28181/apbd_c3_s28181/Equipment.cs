

public abstract class Equipment
{
    private static int _idCounter = 1;
    public int Id { get; }
    public string Name { get; set; }
    public EquipmentStatusType Status { get; set; }
    public string Data="abc";
    protected Equipment(string name)
    {
        Id = _idCounter++;
        Name = name;
        Status = EquipmentStatusType.Available;
    }
}