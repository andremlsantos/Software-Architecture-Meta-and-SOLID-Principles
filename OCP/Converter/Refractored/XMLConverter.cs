using SOLID.OCP.Converter.Violation;
using System;

namespace SOLID.OCP.Converter.Refractored
{
    public class XMLConverter : Converter
    {
        public string Convert(Document document)
        {
            Console.WriteLine("Converting xml");

            return string.Empty;
        }
    }
}
