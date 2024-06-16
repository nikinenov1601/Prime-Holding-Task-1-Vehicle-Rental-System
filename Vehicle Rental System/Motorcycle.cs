namespace Vehicle_Rental_System;

internal class Motorcycle : Vehicle
{
    public Motorcycle(string brand, string model, decimal value, DateTime reservationStartDate, DateTime reservationEndDate, DateTime actualReturnDate, int riderAge)
        : base(brand, model, value, reservationStartDate, reservationEndDate, actualReturnDate)
    {

        if (riderAge < 0)
        {
            throw new ArgumentException("Rider's age cannot be negative ");
        }

        RiderAge = riderAge;
    }

    private int riderAge;

    public int RiderAge
    {
        get => riderAge;
        set
        {
            if (riderAge < 0)
            {
                throw new ArgumentException("Rider's age cannot be negative ");
            }
        }
    }

    public override decimal CalculateInsuranceCost()
    {
        return InsurancePerDay() * ((ReservationEndDate - ReservationStartDate).Days);
    }

    public override decimal CalculateRentalCost()
    {
        int reservedRentalDays = (ReservationEndDate - ReservationStartDate).Days;
        int actualRentalDays = (ActualReturnDate - ReservationStartDate).Days;
        decimal dailyRentalCost = RentalCostPerDay(); ;
        decimal totalRentalCost;

        if (reservedRentalDays == actualRentalDays)
        {
            totalRentalCost = Math.Round(actualRentalDays * dailyRentalCost);
        }
        else
        {
            totalRentalCost = Math.Round(actualRentalDays * dailyRentalCost) + ((reservedRentalDays - actualRentalDays) * dailyRentalCost * 2);
        }

        return totalRentalCost;
    }

    public override decimal RentalCostPerDay()
    {
        if ((ReservationEndDate - ReservationStartDate).Days >= 7)
        {
            return 10;
        }

        return 15;
    }

    public override decimal InsurancePerDay()
    {
        decimal insurranceCost = Value / 5000;

        if (RiderAge < 25)
        {
            insurranceCost *= 0.8m;
        }

        return insurranceCost;
    }
}