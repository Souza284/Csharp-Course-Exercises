// Exercise01 - Temperature converter

GetTemperature();

static void GetTemperature()
{
    Console.WriteLine("Please enter in the temperature in celcius: ");
    var temperature = decimal.Parse(Console.ReadLine()!);

    Console.WriteLine(temperature + "C -> " + FahrenheitConverter(temperature) + "F -> " + KelvinConverter(temperature) + "K");
}

static decimal FahrenheitConverter(decimal _temperature)
{
    return _temperature * 1.8m + 32;
}

static decimal KelvinConverter(decimal _temperature)
{
    return _temperature + 273.5m;
}