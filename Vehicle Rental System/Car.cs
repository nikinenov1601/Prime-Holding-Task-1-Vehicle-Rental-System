namespace Vehicle_Rental_System;

public class Car : Vehicle
{
    public Car(string brand, string model, decimal value, DateTime reservationStartDate, DateTime reservationEndDate, DateTime actualReturnDate, int safetyRating)
        : base(brand, model, value, reservationStartDate, reservationEndDate, actualReturnDate)
    {
        if (safetyRating > 5 || safetyRating < 0)
        {
            throw new ArgumentException("Invalid safety rating.");
        }

        SafetyRating = safetyRating;
    }


    private int safetyRating;
    public int SafetyRating
    {
        get => safetyRating;

        private set
        {
            if (safetyRating > 5 || safetyRating < 0)
            {
                throw new ArgumentException("Invalid safety rating.");
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
        decimal dailyRentalCost;
        decimal totalRentalCost;

        dailyRentalCost = RentalCostPerDay();

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
            return 15;
        }

        return 20;
    }

    public override decimal InsurancePerDay()
    {
        decimal insurranceCost = Value / 10000;

        if (SafetyRating >= 4)
        {
            insurranceCost *= 0.9m;
        }

        return insurranceCost;
    }
}