using System.ComponentModel.DataAnnotations;
Console.Clear();

Console.WriteLine("We are going on a road trip for Fall Break. I'm going to ask you some specific questions albout the trip and then I'll calculate the trip summary from that info.");
Console.WriteLine();
Console.WriteLine("Questions:");
Console.Write("Where will we be driving? ");
string city = Console.ReadLine();
Console.Write("Who is the driver? ");
string driver = Console.ReadLine();
Console.Write($"How many miles to get to {city}? ");
string distanceText = Console.ReadLine();
double distanceNumber = Convert.ToDouble(distanceText);
Console.Write($"What is the average speed (MPH){driver} will be travelling? ");
string speedText = Console.ReadLine();
double speedNumber = Convert.ToDouble(speedText);
Console.Write("How many MPG does your car get? ");
string milesPerGallonText = Console.ReadLine();
double milesPerGallonNumber = Convert.ToDouble(milesPerGallonText);
Console.Write("How many gallons of gas does your car hold? ");
string gallonsText = Console.ReadLine();
double gallonsNumber = Convert.ToDouble(gallonsText);
Console.Write("Excluding the driver, how many riders in the car? ");
string ridersText = Console.ReadLine();
int ridersNumber = Convert.ToInt32(ridersText);
Console.Write("What unit of currency ($ £ ¥ €) do you use? ");
string currency = Console.ReadLine();
Console.Write("What is the fuel price per gallon ($)? ");
string gasPriceText = Console.ReadLine();
decimal gasPriceNumber = Convert.ToDecimal(gasPriceText);

Console.WriteLine("Press any key to continue");
Console.WriteLine();
Console.ReadKey();
Console.WriteLine("Trip Caluclations");
Console.WriteLine();
Console.WriteLine($"{"Driver:",-30}{driver,-10}");
Console.WriteLine($"{"Currency:",-30}{currency,-10}");
Console.WriteLine();
Console.WriteLine($"{"Distance(miles):",-30}{distanceNumber,-10}");
Console.WriteLine($"{"Average speed(mph):",-30}{speedNumber,-10}");

//Time driving 
double totalTime = distanceNumber / speedNumber;
int hours = (int)totalTime;
int minutes = Convert.ToInt32((totalTime - hours) * 60);
Console.Write($"{"Time Driving:",-30}{hours}H{minutes}{"M",-10}");

Console.WriteLine();
Console.WriteLine($"{"Vehicle Miles per Gallon:",-30}{milesPerGallonNumber,-10}");

double fuelNeeded = (distanceNumber / milesPerGallonNumber) * 2;
Console.WriteLine($"{"Fuel Needed (round trip):",-30}{fuelNeeded:F2}{" gallons",-10}");

double rangePerTank = gallonsNumber * milesPerGallonNumber;
Console.WriteLine($"{"Range per tank:",-30}{rangePerTank,-10:F2}");


double tanksRequired = (int)((distanceNumber + rangePerTank - 1) / rangePerTank);
int fuelStops = Convert.ToInt32(tanksRequired);
Console.WriteLine($"{"Estimated Fuel Stops:",-30}{fuelStops,-10}");

Console.WriteLine();
Console.WriteLine($"{"Gas Price per gallon:",-30}{currency}{gasPriceNumber,-10}");

//Fuel cost calcualtions
decimal fuelNeededDecimal = Convert.ToDecimal(fuelNeeded);
decimal fuelCost = gasPriceNumber * fuelNeededDecimal;
Console.WriteLine($"{"Fuel Cost:",-30}{currency}{fuelCost,-10:F2}");

int totalPeople = ridersNumber + 1;
Console.WriteLine($"{"Riders (split):",-30}{totalPeople,-10}");

//Cost per person calculation + ` to include driver
decimal ridersDecimal = Convert.ToDecimal(ridersNumber + 1);
decimal costPerPerson = fuelCost / ridersDecimal;
Console.WriteLine($"{"Cost per person:",-30}{currency}{costPerPerson:F2}{"(gallons)",-10}");
//Cost per mile calculation
decimal distanceDecimal = Convert.ToDecimal(distanceNumber);
decimal costPerMile = fuelCost / distanceDecimal;
Console.WriteLine($"{"Cost per mile:",-30}{currency}{costPerMile,-10:F2}");

//Cost per driving hour calculation
decimal totalTimeDecimal = Convert.ToDecimal(totalTime);
decimal costPerHour = fuelCost / totalTimeDecimal;
Console.WriteLine($"{"Cost per driving hour:",-30}{currency}{costPerHour,-10:F2}");

Console.WriteLine();
double songLength = 3.5;
Console.WriteLine($"{"Average song length:",-30}{songLength,-10}");

double totalTimeMusic = Convert.ToDouble(totalTime);
double totalMinutes = totalTime * 60;
double songsNeeded = totalMinutes / songLength;
int songsNumber = (int)(songsNeeded);
Console.WriteLine($"{"Number of songs needed:",-30}{songsNumber,-10}");
