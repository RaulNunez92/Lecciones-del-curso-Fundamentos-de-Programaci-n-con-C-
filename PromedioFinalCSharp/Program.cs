using System.Globalization;

Console.WriteLine("=== Cálculo del Promedio Final ===");
Console.WriteLine("Los parciales valen 55%, el examen 30% y el trabajo final 15%.\n");

double p1 = LeerNota("Ingrese la nota del parcial 1: ");
double p2 = LeerNota("Ingrese la nota del parcial 2: ");
double p3 = LeerNota("Ingrese la nota del parcial 3: ");
double p4 = LeerNota("Ingrese la nota del parcial 4: ");
double examen = LeerNota("Ingrese la nota del examen: ");
double trabajoFinal = LeerNota("Ingrese la nota del trabajo final: ");

double promedioParciales = ((p1 + p2 + p3 + p4) / 4) * 0.55;
double promedioFinal = promedioParciales + (examen * 0.30) + (trabajoFinal * 0.15);

Console.WriteLine($"\nPromedio de parciales (55%): {promedioParciales:F2}");
Console.WriteLine($"Promedio final: {promedioFinal:F2}%");
Console.WriteLine(promedioFinal >= 60 ? "El estudiante aprobó." : "El estudiante reprobó.");

static double LeerNota(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        string? texto = Console.ReadLine();

        if (double.TryParse(texto, NumberStyles.Number, CultureInfo.CurrentCulture, out double nota) &&
            nota >= 0 && nota <= 100)
        {
            return nota;
        }

        Console.WriteLine("Escriba una nota válida entre 0 y 100.");
    }
}
