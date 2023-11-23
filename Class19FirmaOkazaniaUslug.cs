using System;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }


    public Client(int id, string name, string address, string phoneNumber, string email)
    {
        Id = id;
        Name = name;
        Address = address;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}

Client client = new Client(1, "Иванов Иван", "ул. Ленина, 1", "1234567890", "ivanov@example.com");
client.PhoneNumber = "0987654321";


//Console.WriteLine("Имя клиента: {0}", client.Name);
//Console.WriteLine("Адрес клиента: {0}", client.Address);
//Console.WriteLine("Телефон клиента: {0}", client.PhoneNumber);
//Console.WriteLine("Email клиента: {0}", client.Email);

//using System;

//namespace AccountingFirm
//{
//    public class Client
//    {
//        public string Name { get; set; }
//        public string Address { get; set; }
//        public string Email { get; set; }
//        public string Phone { get; set; }
//        public DateTime RegistrationDate { get; set; }

//        public Client(string name, string address, string email, string phone, DateTime registrationDate)
//        {
//            Name = name;
//            Address = address;
//            Email = email;
//            Phone = phone;
//            RegistrationDate = registrationDate;
//        }

//    }
//}
