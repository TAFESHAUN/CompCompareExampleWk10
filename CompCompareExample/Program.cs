using Humanizer;
using FluentDate;
using FluentDateTime;

#region HUMANIZER
//Humanizer Test
Console.WriteLine(TimeSpan.FromMilliseconds(12900002).Humanize(3));
Console.WriteLine(TimeSpan.FromMilliseconds(473829).Humanize(3));
Console.WriteLine(TimeSpan.FromMilliseconds(3956488322).Humanize(3));
#endregion

#region FLUENTDATE

// Fluent DateTime estimations
DateTime.Now.NextDay();
DateTime.Now.NextYear();
DateTime.Now.PreviousYear();
DateTime.Now.WeekAfter();
DateTime.Now.Midnight();
DateTime.Now.Noon();

var date = FluentDateTime.TimeSpanExtensions.From(System.TimeSpan.FromSeconds(60), DateTime.Now);

Console.WriteLine($"THE OUTPUT OF TIMESPANEXTENSIONS {date}");

// Current DateTime manipulation
DateTime.Now.SetTime(11, 55, 0);

// DateTime expressions
2022.Mar(23);// (implicitly convertible to DateTime and DateTimeOffset)

#endregion