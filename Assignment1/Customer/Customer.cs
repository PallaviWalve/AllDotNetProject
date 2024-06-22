namespace CustomerLibrary;

public class Customer
{
    public int custId { get; set; }

    public string custName { get; set; }

    public string City { get; set; }

    public Customer()
    {

    }

    public Customer(int id, string name, string city)
    {
        this.custId = id;
        this.custName = name;
        this.City = city;
    }
}

