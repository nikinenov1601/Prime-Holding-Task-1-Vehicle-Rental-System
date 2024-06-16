namespace Vehicle_Rental_System;

public interface IVehicle
{
    public abstract decimal CalculateInsuranceCost();

    public abstract decimal CalculateRentalCost();

    public abstract decimal RentalCostPerDay();

    public abstract decimal InsurancePerDay();
}
