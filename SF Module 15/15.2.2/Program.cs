using _15._2._2;
internal class Program
{
    private static void Main(string[] args)
    {
        var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 79994500508 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675334 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

        var result = (from x in contacts
                      let strPhone = x.Phone.ToString()
                      where strPhone.Length != 11 || !strPhone.StartsWith("7")
                      select x).Count();

    }
}