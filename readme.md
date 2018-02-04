## Simple utility class for calculating Christian holidays

From time to time I still get questions about some post I did several years ago on [eksperten.dk](https://www.computerworld.dk/eksperten/spm/930284?k=7725302). As there's no license in the post, people are worried if they can use the code. Of course they can. Here it is.

Example of usage: 

```csharp
var thisYearsEaster = new HolidayCalculator().CalculateEasterSunday(DateTime.Now.Year);

var nextYearWhitSunday = new HolidayCalculator().GetWhitSunday(DateTime.Now.AddYears(1).Year);
```

The calculations for the most common (european) Christian holidays are defined. PR's are welcome if you miss some.
