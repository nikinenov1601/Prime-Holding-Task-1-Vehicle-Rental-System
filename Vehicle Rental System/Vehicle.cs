using System.Text;

namespace Vehicle_Rental_System;

public abstract class Vehicle : IVehicle
{
    protected Vehicle(string brand, string model, decimal value, DateTime reservationStartDate, DateTime reservationEndDate, DateTime actualReturnDate)
    {
        Brand = brand;
        Model = model;
        Value = value;
        ReservationStartDate = reservationStartDate;
        ReservationEndDate = reservationEndDate;
        ActualReturnDate = actualReturnDate;
    }

    public string Brand { get; }

    public string Model { get; }

    public decimal Value { get; }

    public DateTime ReservationStartDate { get; set; }

    public DateTime ReservationEndDate { get; set; }

    public DateTime ActualReturnDate { get; set; }

    public const string DateFormat = "yyyy-dd-MM";

    public abstract decimal CalculateInsuranceCost();

    public abstract decimal CalculateRentalCost();

    public abstract decimal RentalCostPerDay();

    public abstract decimal InsurancePerDay();

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Date: {DateTime.Now.ToString(DateFormat)}");
        sb.AppendLine($"Rented vehicle: {Brand} {Model}");
        sb.AppendLine($"Reservation start date: {ReservationStartDate.ToString(DateFormat)}");
        sb.AppendLine($"Reservation end date: {ReservationEndDate.ToString(DateFormat)}");
        sb.AppendLine($"Reservation rental days: {(ReservationEndDate - ReservationStartDate).Days} days");
        sb.AppendLine($"Actual Return date: {ActualReturnDate.ToString(DateFormat)}");
        sb.AppendLine($"Actual rental days: {(ActualReturnDate - ReservationStartDate).Days} days");
        sb.AppendLine($"Rental cost per day: ${RentalCostPerDay():f2}");
        sb.AppendLine($"Insurance per day: ${InsurancePerDay():f2}");
        sb.AppendLine($"Total rent: ${CalculateRentalCost():f2}");
        sb.AppendLine($"Total insurance: ${CalculateInsuranceCost():f2}");
        sb.AppendLine($"Total: ${CalculateInsuranceCost() + CalculateRentalCost():f2}");

        return sb.ToString();
    }
}