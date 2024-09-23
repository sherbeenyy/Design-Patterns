class CheckPoint // mememto
{
    private readonly string _name;
    private readonly string _money;
    private readonly string _weapon;

    private readonly DateTime _CreationDate;

    public CheckPoint(string name, string money,string weapon)
    {
        _name = name;
        _money = money;
        _weapon = weapon;
        _CreationDate = DateTime.Now;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetMoney()
    {
        return _money;
    }

    public string GetWeapon()
    {
        return _weapon;
    }

    public DateTime GetCreationDate()
    {
        return _CreationDate;
    }

    public void showCheckPoint()
    {
        Console.WriteLine($"Name: {_name}, Money: {_money}, Weapon: {_weapon}, Creation Date: {_CreationDate}") ;
    }


}