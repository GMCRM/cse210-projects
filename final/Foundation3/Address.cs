public class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    //contructor
    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }
    //method to check address is in Merica 🇺🇸
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }
    //method to get full adress in string
    public override string ToString()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}