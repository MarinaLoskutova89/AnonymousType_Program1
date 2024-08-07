using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    public static class Program1
    {
        public static void SolarSystem()
        {
            var venus = new { Name = "Venus", SerialNumberFromTheSun = 2, EquatorLength = 38025, PreviousPlanet = (object?)null };
            var earth = new { Name = "Earth", SerialNumberFromTheSun = 3, EquatorLength = 40075, PreviousPlanet = venus };
            var mars = new { Name = "Mars", SerialNumberFromTheSun = 4, EquatorLength = 21344, PreviousPlanet = earth };
            var anotherVenus = new { Name = "Venus", SerialNumberFromTheSun = 2, EquatorLength = 38025, PreviousPlanet = mars };

            Console.WriteLine($"Name = {venus.Name},\n" +
                              $"Serial number from the Sun = {venus.SerialNumberFromTheSun},\n" +
                              $"Equator length = {venus.EquatorLength},\n" +
                              $"Previous planet = {venus.PreviousPlanet},\n" +
                              $"Is equivalent to Venus: {venus.Equals(venus)}");
            Console.WriteLine();
            Console.WriteLine($"Name = {earth.Name},\n" +
                              $"Serial number from the Sun = {earth.SerialNumberFromTheSun},\n" +
                              $"Equator length = {earth.EquatorLength},\n" +
                              $"Previous planet = {earth.PreviousPlanet},\n" +
                              $"Is equivalent to Venus: {earth.Equals(venus)}");
            Console.WriteLine();
            Console.WriteLine($"Name = {mars.Name},\n" +
                              $"Serial number from the Sun = {mars.SerialNumberFromTheSun},\n" +
                              $"Equator length = {mars.EquatorLength},\n" +
                              $"Previous planet = {mars.PreviousPlanet},\n" +
                              $"Is equivalent to Venus: {mars.Equals(venus)}");
            Console.WriteLine();
            Console.WriteLine($"Name = {anotherVenus.Name},\n" +
                              $"Serial number from the Sun = {anotherVenus.SerialNumberFromTheSun},\n" +
                              $"Equator length = {anotherVenus.EquatorLength},\n" +
                              $"Previous planet = {anotherVenus.PreviousPlanet},\n" +
                              $"Is equivalent to Venus: {anotherVenus.Equals(venus)}");
            Console.WriteLine();
        }
        public static void AnotherSolarSystem()
        {
            var planets = new[]
            {
                new { Name = "Venus", SerialNumberFromTheSun = 2, EquatorLength = 38025 },
                new { Name = "Earth", SerialNumberFromTheSun = 3, EquatorLength = 40075 },
                new { Name = "Mars", SerialNumberFromTheSun = 4, EquatorLength = 21344 },
                new { Name = "Venus", SerialNumberFromTheSun = 2, EquatorLength = 38025 }
            };

            int counter = 0;
            foreach (var planet in planets)
            {
                var previousPlanet = counter == 0 ? (object?)null : planets[counter - 1];

                Console.WriteLine($"Name = {planet.Name},\n" +
                              $"Serial number from the Sun = {planet.SerialNumberFromTheSun},\n" +
                              $"Equator length = {planet.EquatorLength},\n" +
                              $"Previous planet = {previousPlanet},\n" +
                              $"Is equivalent to Venus: {planet.Equals(planets[0])}");
                Console.WriteLine();
                counter++;
            }
        }
    }
}
