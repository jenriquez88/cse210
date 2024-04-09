class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customername, Address address)
    {
        _customerName = customername;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _address;
    }
}