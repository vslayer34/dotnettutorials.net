using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class CreditCard
{
    public string CardNumber { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;


    public static List<CreditCard> GenerateCreditCards(int number)
    {
        List<CreditCard> creditCards = new();

        for (int i = 0; i < number; i++)
        {
            CreditCard creditCard = new()
            {
                CardNumber = "10000000" + i,
                Name = "Credit Card - " + i
            };


            creditCards.Add(creditCard);
        }

        return creditCards;
    }    
}
