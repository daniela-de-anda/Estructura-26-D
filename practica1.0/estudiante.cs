using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class estudiante
{
    // Propiedades
    public string Nombre { get; set; }
    public string Carrera { get; set; }

    // Arreglo de calificaciones
    private double[] calificaciones;

    // Constructor
    public estudiante(string nombre, string carrera, int cantidadCalificaciones)
    {
        Nombre = nombre;
        Carrera = carrera;
        calificaciones = new double[cantidadCalificaciones];
    }

    // Método para capturar las calificaciones
    public void CapturarCalificaciones()
    {
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write("Ingresa la calificación " + (i + 1) + ": ");
            calificaciones[i] = Convert.ToDouble(Console.ReadLine());
        }
    }

    // Método para obtener el promedio
    public double ObtenerPromedio()
    {
        double suma = 0;

        for (int i = 0; i < calificaciones.Length; i++)
        {
            suma += calificaciones[i];
        }

        return suma / calificaciones.Length;
    }

    // Método para decir si el estudiante es regular
    public string EsRegular()
    {
        double promedio = ObtenerPromedio();

        if (promedio >= 70)
        {
            return "El estudiante es regular.";
        }
        else
        {
            return "El estudiante no es regular.";
        }
    }
}
