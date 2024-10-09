

try
{
    var temp = string.Empty;
    while (string.IsNullOrEmpty(temp))
    {
        Console.WriteLine("Enter your email: ");
        temp = Console.ReadLine();
    }
    EMail email = (EMail)temp;

    Console.WriteLine($"Your email is : {email} ");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();


{
    void SendEmail(string email)
    {
        // Send EMail 
    }

    string email = "+1 912 123 4567"; // Invalid EMail - no exception
    SendEmail(email);

}

{
    void SendEmail(EMail email)
    {
        // Send email 
    }

    EMail email = (EMail)"+1 912 123 4567"; // Invalid EMail - an exception throws here
    SendEmail(email);
}

public string Name { get; set; }
public string Email { get; set; }
public string Password { get; set; }
public string Username { get; set; }
public string PhoneNumber { get; set; }
public long CustomerId { get; set; }
public long OrderId { get; set; }
public long SupplierId { get; set; }
public long ProductId { get; set; }