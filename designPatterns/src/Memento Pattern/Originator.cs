class Game  //Originator
{
    private string _name = "Guest"; 
    private string _money = "0";
    private string _weapon = "unarmed";

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetMoney(string money)
    {
        _money = money;
    }

    public void SetWeapon(string weapon)
    {
        _weapon = weapon;
    }
    public CheckPoint createCheckPoint()
    {
         return new CheckPoint(_name, _money, _weapon);
    
    }

    public void LoadCheckPoint(CheckPoint checkPoint)
    {
        _name = checkPoint.GetName();
        _money = checkPoint.GetMoney();
        _weapon = checkPoint.GetWeapon();
    }

    public void showCurrentState()
    {
        Console.WriteLine($"Name: {_name}, Money: {_money}, Weapon: {_weapon}");
    }
}
