using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem19 : Problem {
    Dictionary<int, int> daysInMonthLookup = new Dictionary<int, int> {
      {1, 31}, {2, 28}, {3, 31}, {4, 30}, {5, 31}, {6, 30}, {7, 31}, {8, 31},
      {9, 30}, {10, 31}, {11, 30}, {12, 31}
    };
    DateTime KNOWN_DATE = new DateTime(1900, 1, 1);
    DateTime STARTING_DATE = new DateTime(1901, 1, 1);
    DateTime END_DATE = new DateTime(2000, 12, 31);

    public override long Solve() {
      long numberOfSundaysOnFirstOfMonth = 0;
      var currentDate = STARTING_DATE;
      var dayOfWeek = CalculateStartingDayOfWeek();

      while (currentDate < END_DATE) {
        var numberOfDaysUntilNextMonth = CalculateNumberOfDaysUntilNextMonth(currentDate);
        var firstOfNextMonthDayOfWeek = CalculateFutureDayOfWeek(dayOfWeek, numberOfDaysUntilNextMonth);
        if (firstOfNextMonthDayOfWeek == DayOfWeek.Sunday) {
          numberOfSundaysOnFirstOfMonth++;
        }
        currentDate = currentDate.AddDays(numberOfDaysUntilNextMonth);
        dayOfWeek = firstOfNextMonthDayOfWeek;
      }

      return numberOfSundaysOnFirstOfMonth;
    }

    int CalculateNumberOfDaysUntilNextMonth(DateTime currentDate) {
      var numberOfDaysUntilNextMonth = daysInMonthLookup[currentDate.Month];
      if (currentDate.Month == 2 && IsLeapYear(currentDate.Year)) numberOfDaysUntilNextMonth++;
      return numberOfDaysUntilNextMonth;
    }

    public DayOfWeek CalculateStartingDayOfWeek() {
      //Starting Date is exactly one year later. jan 1, 1901
      var daysInOneYear = daysInMonthLookup.Sum(dm => dm.Value);
      if (IsLeapYear(KNOWN_DATE.Year)) daysInOneYear++;
      //since we're given jan 1, 1900 is monday.
      return CalculateFutureDayOfWeek(DayOfWeek.Monday, daysInOneYear);
    }

    public bool IsLeapYear(int year) {
      if (year % 100 == 0) return year % 400 == 0;
      return year % 4 == 0;
    }

    public DayOfWeek CalculateFutureDayOfWeek(DayOfWeek startingDayOfWeek, int numberOfDaysInFuture) {
      return (DayOfWeek)(((int)startingDayOfWeek + numberOfDaysInFuture) % 7);
    }

  }
}
