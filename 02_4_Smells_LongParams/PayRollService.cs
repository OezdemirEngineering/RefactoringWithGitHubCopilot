using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_4_Smells_LongParams;

public class PayRollService
{
    public double CalculateSalary(double baseSalary, double overtimeHours, double overtimeRate, double bonus, double taxRate, double deductions)
    {
        // Grundgehalt und Überstunden berechnen
        double overtimePay = overtimeHours * overtimeRate;
        double grossSalary = baseSalary + overtimePay + bonus;

        // Abzüge berechnen
        double tax = grossSalary * taxRate;
        double netSalary = grossSalary - tax - deductions;

        return netSalary;
    }
}

