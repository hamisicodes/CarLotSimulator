using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() { }

        public Car(int year, string make, string model, string engineNoise, string honkNoise)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
        }
        public int Year {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"Engine Noise: {noise}");
        }

        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine($"Honk Noise: {noise}");
        }



    }
}
