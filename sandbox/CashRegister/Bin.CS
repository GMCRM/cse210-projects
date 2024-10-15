class Bin
{
    //attributes
    private string _denomination;
    private int _amount;
    private int _value;
    //methods

    public Bin(string denomination, int amount, float value)
    {   
        _denomination = denomination;
        _amount = amount;
        _value = value;
    }

    public void ModifyAmount(int amount)
    {
        _amount = amount;
    }
