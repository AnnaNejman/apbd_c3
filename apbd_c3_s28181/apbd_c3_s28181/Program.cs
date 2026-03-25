using apbd_c3_s28181;
//sprzet
var service = new Service();
var laptop1 = new Laptop("Dell XPS", 16, "i7");
var laptop2 = new Laptop("Lenovo ThinkPad", 8, "i5");
var projector1 = new Projector("Epson X1", 0, 3);
var camera1 = new Camera("Canon EOS", 24, true);

service.AddEquipment(laptop1);
service.AddEquipment(laptop2);
service.AddEquipment(projector1);
service.AddEquipment(camera1);

//user
var student1 = new Student("Jan", "Kowalski");
var student2 = new Student("Joanna", "Kowalska");
var employee1 = new Employee("Adam", "Nowak");
var employee2 = new Employee("Anna", "Nowak");

service.AddUser(student1);
service.AddUser(student2);
service.AddUser(employee1);
service.AddUser(employee2);

//rent
service.RentEquipment(student1, laptop1, 7);
service.RentEquipment(employee1, laptop2, 90);

//niepoprawny rent
try
{
    service.RentEquipment(student1, laptop2, 7);
    service.RentEquipment(student1, projector1, 7); //
}
catch (Exception ex)
{
    Console.WriteLine($"Błąd: {ex.Message}");
}

//zwrot w terminie
Console.WriteLine("Zwrot w terminie:");
service.ReturnEquipment(laptop1);

// zwrot opozniony
Console.WriteLine("Zwrot po terminie:");
service.RentEquipment(student2, camera1, -3);
service.ReturnEquipment(camera1);

//raport
Console.WriteLine("===== RAPORT KOŃCOWY =====");
service.Report();