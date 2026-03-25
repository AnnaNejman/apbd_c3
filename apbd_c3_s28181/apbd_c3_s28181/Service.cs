namespace apbd_c3_s28181;

public class Service
{
    private List<Person> users = new();
    private List<Equipment> equipment = new();
    private List<Rent> rentals = new();

    public void AddUser(Person user) => users.Add(user);

    public void AddEquipment(Equipment eq) => equipment.Add(eq);

    public void GetAllEquipment()
    {
        foreach (var e in equipment)
        {
            Console.WriteLine(e);
        }
    }

    public void GetAllAvailableEquipment()
    {
        foreach (var e in equipment)
        {
            if(e.Status==EquipmentStatusType.Available)
                Console.WriteLine(e);
        }
    }
    public void RentEquipment(Person user, Equipment eq, int days)
    {
        if (eq.Status != EquipmentStatusType.Available)
            throw new Exception("Niedostępny");

        int activeLoans = rentals.Count(r => r.User == user && r.IsActive);
        if (activeLoans >= user.MaxLoans)
        {
            throw new Exception("Przekroczono limit wypożyczeń");
        }

        var rental = new Rent(user, eq, days);
        rentals.Add(rental);
        eq.Status = EquipmentStatusType.Rented;
    }

    public void ReturnEquipment(Rent rent)
    {
        rent.Return(); 
        rent.Equipment.Status = EquipmentStatusType.Available;

        Console.WriteLine($"Kara {rent.FinancialPenalty} zł");
    }

    public void MakeUnavailable(Equipment eq)
    { 
        eq.Status = EquipmentStatusType.Unavailable;
    }

    public IEnumerable<Rent> GetUserActiveRentals(Person p)
    {
        List<Rent> result = new List<Rent>();

        foreach (var r in rentals)
        {
            if (r.User == p && r.IsActive)
            {
                result.Add(r);
            }
        }

        return result;
    }
    public IEnumerable<Rent> GetOverdueRentals()
    {
        List<Rent> result = new List<Rent>();

        foreach (var r in rentals)
        {
            if (r.IsActive && r.DueDate < DateTime.Now)
            {
                result.Add(r);
            }
        }

        return result;
    }
    public void Report()
    {
        Console.WriteLine($"Sprzęt: {equipment.Count}");
        Console.WriteLine($"Dostępne: {equipment.Count(e => e.Status == EquipmentStatusType.Available)}");
        Console.WriteLine($"Wypożyczone: {equipment.Count(e => e.Status == EquipmentStatusType.Rented)}");
        
    }
}