using Vehicle_Rental_System;

DateTime startDate = DateTime.Parse("2024-06-03");
DateTime endDate = DateTime.Parse("2024-06-13");
DateTime actualReturnDate = DateTime.Parse("2024-06-13");

Vehicle car = new Car("Mitsubishi", "Mirage", 15000, startDate, endDate, actualReturnDate, 3);

Console.WriteLine(car.ToString());