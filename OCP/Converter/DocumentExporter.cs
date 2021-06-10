using System;
using System.Security.Policy;

namespace SOLID.OCP.Converter
{
    /*
     * The DocumentExporter class is not closed to change
     */
    class DocumentExporter
    {
        public ConverterType Type { get; set; }

        private Url GetFileUrl()
        {
            return null;
        }

        private void ShowSuccessDialog()
        {
            Console.WriteLine("Success");
        }

        /*
         * Every time a new export format must be supported, the DocumentExporter class must be modified.
         * Enums and switch statements are strong indicators that a class is not closed to changes.
         * If the enum changes, then every related switch statement must also be changed.
         */
        private void ExportDocument(Document doc)
        {
            var fileURL = GetFileUrl();

            switch (Type)
            {
                case Converter.ConverterType.XMLConverterType:
                    {
                        XMLConverter xmlConverter = new XMLConverter();
                        String xmlFileContent = xmlConverter.ConvertDocumentToXML(doc);
                        xmlConverter.WriteToURL(fileURL);
                        break;
                    }

                case Converter.ConverterType.BinaryConverterType:
                    {
                        BinaryConverter binaryConverter = new BinaryConverter();
                        String binaryFileContent = binaryConverter.ConvertDocumentToBinary(doc);
                        binaryConverter.WriteToURL(fileURL);
                        break;
                    }

                default:
                    Console.WriteLine("Unrecognized converter type");
                    return;
            }

            ShowSuccessDialog();
        }
    }
}
