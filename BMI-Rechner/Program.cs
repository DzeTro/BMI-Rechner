
while (true)
{
    Console.WriteLine("Bitte gib dein Körpergewicht ein: ");
    double kilogramm = double.Parse(Console.ReadLine());
    Console.WriteLine("Bitte gib deine Körpergröße ein: ");
    double groesse = double.Parse(Console.ReadLine());
    
    PrüfeEingabe(kilogramm, groesse);

    BMIBeurteilung(BMIRechner(kilogramm, groesse));
}

void PrüfeEingabe(double kilogramm, double groesse)
{
    if (kilogramm == groesse)
        Console.WriteLine("Du bist breit wie hoch, du bist quadratisch.");

    if (kilogramm == (groesse / 2))
        Console.WriteLine("Du bist halb so breit wie hoch.");
}

static double BMIRechner (double kilogramm, double groesse)
{ 
    double zwischenergebniss = (kilogramm / (groesse * groesse))*10000;
    double BMI = Math.Round(zwischenergebniss, 2);
    Console.WriteLine("Dein BMI beträgt: "+ BMI);
    return BMI;
}

static bool BMIBeurteilung (double BMI)
{
    if (BMI < 20)
    {
        Console.WriteLine("Du hast Untergewicht!");
        return true;
    }
    else if (BMI <= 20 || BMI < 25)
    {
        Console.WriteLine("Du hast Normalgewicht!");
        return true;
    }
    else if (BMI <= 25 || BMI < 30)
    {
        Console.WriteLine("Du hast Übergewicht!");
        return true;
    }
    else if (BMI <= 30 || BMI < 40)
    {
        Console.WriteLine("Du hast Starkes Übergewicht!");
        return true;
    }
    else if (BMI >= 40)
    {
        Console.WriteLine("Du hast Extremes Übergewicht!");
        return true;
    }
    return false;

}
