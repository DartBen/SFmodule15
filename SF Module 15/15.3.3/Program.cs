using _15._3._3;
internal class Program
{
    private static void Main(string[] args)
    {
        var phoneBook = new List<Contact>();

        // добавляем контакты
        phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
        phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

        var GroupPhoneBook = from contact in phoneBook

                             group contact by contact.Email.Split('@').Last();



        foreach (var group in GroupPhoneBook)
        {
            Console.WriteLine();
            Console.WriteLine("По группам: "+ group.Key);

            if (group.Key.Contains("example"))
                Console.WriteLine("Ложная группа");

            foreach( var contact in group)
            {
                Console.WriteLine("Имя: " + contact.Name + "\nТелефон: "+contact.Phone + "\nПочта: " + contact.Email);
            }



        }



    }
}