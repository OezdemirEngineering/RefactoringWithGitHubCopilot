using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_3_Smells_LongFunctions;

public class TripService
{
    public double CalculateTripCost(string destination, int nights, int passengers, bool includeCarRental, bool isPeakSeason)
    {
        // Überprüfen der Eingaben
        if (string.IsNullOrEmpty(destination))
        {
            Console.WriteLine("Invalid destination.");
            return 0;
        }

        if (nights <= 0 || passengers <= 0)
        {
            Console.WriteLine("Invalid number of nights or passengers.");
            return 0;
        }

        // Berechnung der Flugkosten
        double flightCost = passengers * 200; // $200 pro Passagier

        // Berechnung der Hotelkosten
        double hotelCost = nights * 100; // $100 pro Nacht

        // Berechnung der Mietwagenkosten
        double carRentalCost = 0;
        if (includeCarRental)
        {
            carRentalCost = nights * 50; // $50 pro Nacht
        }

        // Saisonabhängiger Aufschlag
        double seasonalSurcharge = isPeakSeason ? 1.2 : 1.0; // 20% Aufschlag in der Hochsaison

        // Gesamtkosten berechnen
        double totalCost = (flightCost + hotelCost + carRentalCost) * seasonalSurcharge;

        Console.WriteLine($"Total cost for trip to {destination}: {totalCost}");
        return totalCost;
    }
}
