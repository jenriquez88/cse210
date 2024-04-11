class Address
{
    public string _street { get; set; }
    public string _city { get; set; }
    public string _state { get; set; }
    public string _zip { get; set; }

    public Address(string street, string city, string state, string zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_zip}";
    }
}
