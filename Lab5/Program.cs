using System;

Prices menu = new()
{
    Drink = 10,
    First = 20,
    Second = 30,
};

Choices client1 = new()
{
    DrinkQuantity = 200,
    FirstQuantity = 250,
    SecondQuantity = 0,
};

Choices client2 = new()
{
    DrinkQuantity = 200,
    FirstQuantity = 0,
    SecondQuantity = 300,
};

static int ClientTotal(Prices prices, Choices choices)
{
    int client_total = choices.DrinkQuantity * prices.Drink + choices.FirstQuantity * prices.First + choices.SecondQuantity * prices.Second;
    return client_total;
}

int client1_total = ClientTotal(menu, client1);
Console.WriteLine("Итоговая стоимость " + client1_total);

int client2_total = ClientTotal(menu, client2);
Console.WriteLine("Итоговая стоимость " + client2_total);

class Prices
{
    public int Drink;
    public int First;
    public int Second;
}

class Choices
{
    public int DrinkQuantity;
    public int FirstQuantity;
    public int SecondQuantity;
}
