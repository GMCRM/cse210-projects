using System;
using System.Collections.Generic;

public class ShopItem
{
    private string _name;
    private int _pointCost;
    private bool _isPurchased;

    public ShopItem(string name, int pointCost)
    {
        _name = name;
        _pointCost = pointCost;
        _isPurchased = false;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPointCost()
    {
        return _pointCost;
    }

    public bool GetIsPurchased()
    {
        return _isPurchased;
    }

    public void Purchase()
    {
        _isPurchased = true;
    }

    public string GetDetails()
    {
        string purchaseStatus = _isPurchased ? "[Purchased]" : $"[{_pointCost} points]";
        return $"{_name} {purchaseStatus}";
    }
}