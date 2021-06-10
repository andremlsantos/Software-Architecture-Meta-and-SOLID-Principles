using SOLID.OCP.Converter.Violation;
using System;

namespace SOLID.OCP.Converter.Refractored
{
    public class BinaryConverter : Converter
    {
        public string Convert(Document document)
        {
            Console.WriteLine("Converting binary");

            return string.Empty;
        }
    }
}
