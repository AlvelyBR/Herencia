using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Estudiante estudiante1 = new Estudiante("Juan", 1);
            
            Profesor profesor1 = new Profesor("Sra. López");

            Curso curso1 = new Curso { nombreCurso = "Matemáticas", recuentoClases = 20, recuentoEjercs = 50 };
           
            profesor1.Cursos.Add(curso1);
           
            Clase claseA = new Clase("Primaria A");
            claseA.Estudiantes.Add(estudiante1);
            claseA.Profesores.Add(profesor1);

            
            Console.WriteLine($"Clase: {claseA.claseTipo}");
            Console.WriteLine("Estudiantes:");
            foreach (var estudiante in claseA.Estudiantes)
            {
                Console.WriteLine($"- {estudiante.nombre} (ID: {estudiante.id})");
            }

            Console.WriteLine("Profesores:");
            foreach (var profesor in claseA.Profesores)
            {
                Console.WriteLine($"- {profesor.nombre}");
                Console.WriteLine("  Cursos impartidos:");
                foreach (var curso in profesor.Cursos)
                {
                    Console.WriteLine($"    * {curso.nombreCurso} - Clases: {curso.recuentoClases}, Ejercicios: {curso.recuentoEjercs}");
                }
            }
        }

    }
}
