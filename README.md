# Prime-Holding-Task-1-Vehicle-Rental-System

Approach for the task explained step by step:

1. Firstly, I defined an interface class called "IVehicle" where I declared 4 abstract methods that will be essential for implementation of the bussiness logic later on.
2. I defined a base class called 'Vehicle' which would inherit the abstract methods from the IVehicle class.
3. I added the common properties between the 3 vehicles of options that we have with the proper data types/structs.
4. I defined a constructor in the base class that initializes the common fields.
5. Set a date format string in, which we would later implement in the ToString() method.
6. Create a ToString() method that would print the expected output.
7. Create the three vehicles of choice (Car, MotorCycle, CargoVan) that we have in separate child classes that inherit the base class Vehicle.
8. Added the exclusive properties (and their limitations) for each of the classes, initialized them in the constructor and implemented the bussiness logic from the instructions in the methods.
9. In the program I declared three variables for the 'start date', 'end date' & 'actual return date' with a struct/dat type of 'DateTime' parsed in the format that is expected the output to be in ('yyyy-mm-dd')
10. In the program I call the constructor provided with the values that correspond with the output that I expect to receive.
11. Finally, in the program I print out the ToString() method to receive the desired output.
