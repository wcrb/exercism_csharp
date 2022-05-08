using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interestRate = float.NaN;

        switch (balance)
        {
            case var b when b >= 5000: 
              interestRate = 2.475F;
              break;
            case var b when b >= 1000:
                interestRate = 1.621F;
                break;
            case var b when b >= 0:
                interestRate = 0.5F;
                break;
            default:
                interestRate = 3.213F;
                break;
        }

        return interestRate;
}

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance) / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;

        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        };

        return years;
    }
}
