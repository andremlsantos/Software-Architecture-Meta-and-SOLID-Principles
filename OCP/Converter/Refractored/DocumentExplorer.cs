using SOLID.OCP.Converter.Violation;
using System;
using System.Security.Policy;

namespace SOLID.OCP.Converter.Refractored
{
    public class DocumentExplorer
    {
        private readonly Converter _converter;

        public DocumentExplorer(Converter converter)
        {
            _converter = converter;
        }

        private Url GetFileUrl()
        {
            return null;
        }

        private void ShowSuccessDialog()
        {
            Console.WriteLine("Success");
        }

        private void ExportDocument(Document document)
        {
            var fileURL = GetFileUrl();
            var fileContent = _converter.Convert(document);
            ShowSuccessDialog();
        }

    }
}
