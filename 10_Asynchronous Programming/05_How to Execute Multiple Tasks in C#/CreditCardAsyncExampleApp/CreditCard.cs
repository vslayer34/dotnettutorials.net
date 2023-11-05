using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardAsyncExampleApp;

public class CreditCard
{
    public string CardNumber { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;

    public static List<CreditCard> GenerateCreditCards(int number)
    {
        List<CreditCard> creditCards = new();

        for (int i = 0; i < number; i++)
        {
            CreditCard card = new()
            {
                CardNumber = "10000000" + i,
                Name = "Credit Card - " + i
            };

            creditCards.Add(card);
        }

        return creditCards;
    }
}
