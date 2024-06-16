# Prime-Holding-Task-1-Vehicle-Rental-System

Approach for the task explained step by step:

1. Firstly, I defined an interface class called "IVehicle" where I declared 4 abstract methods that will be essential for implementation of the bussiness logic later on.
2. I defined a base abstract class called 'Vehicle' which would inherit the IVehicle interface, therefore the abstract methods that are stored in it.
3. In the 'Vehicle' class I added the common properties between the 3 vehicles of choice with the proper data types/structs.
4. In the 'Vehicle' class, I defined a constructor in the base class that initializes the common fields between the three vehicles of choice.
5. In the 'Vehicle' class I declared a string constant to set an exact date format which I would later implement in the ToString() method.
6. In the 'Vehicle' class I created a ToString() method that would print the expected output.
7. I defined the three vehicles of choice (Car, MotorCycle, CargoVan) in separate child classes that inherit the base class Vehicle.
8. In each of the vehicle of choice classes I added the exclusive properties,their limitations & initialized them in the constructor.
9. In each of the vehicle of choice classes I implemented the bussiness logic in the methods inherited from the Vehicle class, according to the instructions given.
10. In the program I declared three variables for the 'start date', 'end date' & 'actual return date' with a struct/dat type of 'DateTime' parsed in the format that is expected the output to be in ('yyyy-mm-dd')
11. In the program I call the constructor provided with the values that correspond with the output that I expect to receive.
12. Finally, in the program I print out the ToString() method to receive the desired output.
