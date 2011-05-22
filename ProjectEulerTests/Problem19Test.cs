using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem19Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(171, new Problem19().Solve());
    }

    [Test]
    public void CalculateStartingDayOfWeek() {
      Assert.AreEqual(new DateTime(1901, 1, 1).DayOfWeek, new Problem19().CalculateStartingDayOfWeek());
    }

    [Test]
    public void IsLeapYear() {
      Assert.False(new Problem19().IsLeapYear(1901));
      Assert.True(new Problem19().IsLeapYear(1908));
      Assert.True(new Problem19().IsLeapYear(2000));
    }

    [Test]
    public void CalculateFutureDayOfWeek() {
      var startingDayOfWeek = DayOfWeek.Friday;
      Assert.AreEqual(DayOfWeek.Friday, new Problem19().CalculateFutureDayOfWeek(startingDayOfWeek, 28));
      Assert.AreEqual(DayOfWeek.Saturday, new Problem19().CalculateFutureDayOfWeek(startingDayOfWeek, 29));
      Assert.AreEqual(DayOfWeek.Sunday, new Problem19().CalculateFutureDayOfWeek(startingDayOfWeek, 30));
      Assert.AreEqual(DayOfWeek.Monday, new Problem19().CalculateFutureDayOfWeek(startingDayOfWeek, 31));
      Assert.AreEqual(DayOfWeek.Tuesday, new Problem19().CalculateFutureDayOfWeek(startingDayOfWeek, 32));
      Assert.AreEqual(DayOfWeek.Wednesday, new Problem19().CalculateFutureDayOfWeek(startingDayOfWeek, 33));
      Assert.AreEqual(DayOfWeek.Thursday, new Problem19().CalculateFutureDayOfWeek(startingDayOfWeek, 34));
    }
  }
}
