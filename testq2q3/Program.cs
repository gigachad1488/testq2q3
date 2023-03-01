using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testq2q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


    }
    class Processor
    { }

    class Lidar
    { }


    class Mobile
    {
        private string model;
        private Processor processor;
        private int ram;
        private int rom;
        private string OS;

        public Mobile(string model, Processor processor, int ram, int rom, string OS)
        {
            this.model = model;
            this.processor = processor;
            this.ram = ram;
            this.rom = rom;
            this.OS = OS;
        }
        public void Turnon()
        {

        }

        public void Turnoff()
        {

        }

        public void MakePhoto()
        {

        }
    }

    class Iphone : Mobile
    {
        private Lidar lidar;

        public Iphone(string model, Processor processor, int ram, int rom, string OS, Lidar lidar) : base(model, processor, ram, rom, OS)
        {
            this.lidar = lidar;
        }

        public void Lidarscan()
        {

        }
    }

}
