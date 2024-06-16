namespace Vehicle_Rental_System;

public class CargoVan : Vehicle
{
    public CargoVan(string brand, string model, decimal value, DateTime reservationStartDate, DateTime reservationEndDate, DateTime actualReturnDate, int driverExperience)
        : base(brand, model, value, reservationStartDate, reservationEndDate, actualReturnDate)
    {
        if (driverExperience < 0)
        {
            throw new ArgumentException("Driver experience cannot be negative");
        }

        DriverExperience = driverExperience;
    }

    private int driverExperience;
    public int DriverExperience
    {
        get => driverExperience;

        set
        {
            if (driverExperience < 0)
            {
                throw new ArgumentException("Driver experience cannot be negative");
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
        decimal dailyRentalCost = RentalCostPerDay();
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

    public override decimal InsurancePerDay()
    {
        decimal insurranceperDay = Value;
        decimal insurranceCost = (0.03m / 100m) * (insurranceperDay);

        if (DriverExperience > 5)
        {
            insurranceCost *= 0.85m;
        }

        return insurranceCost;
    }

    public override decimal RentalCostPerDay()
    {
        if ((ReservationEndDate - ReservationStartDate).Days >= 7)
        {
            return 40;
        }

        return 50;
    }
}