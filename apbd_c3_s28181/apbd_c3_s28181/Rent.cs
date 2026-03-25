namespace apbd_c3_s28181;

public class Rent
{
    public Person User { get; }
    public Equipment Equipment { get; }
    public DateTime StartDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get; set; }
    public decimal FinancialPenalty { get; set; }

    public bool IsActive => ReturnDate == null;

    public Rent(Person user, Equipment equipment, int days)
    {
        User = user;
        Equipment = equipment;
        StartDate = DateTime.Now;
        DueDate = StartDate.AddDays(days);
    }

    public void Return()
    {
        ReturnDate = DateTime.Now;
        if (ReturnDate > DueDate)
        {
            int daysLate = (ReturnDate.Value - DueDate).Days;
            FinancialPenalty = daysLate * 10;       //10zl za dzien
        }
    }
}