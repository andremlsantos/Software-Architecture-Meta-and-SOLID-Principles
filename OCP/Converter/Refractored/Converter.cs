using SOLID.OCP.Converter.Violation;

namespace SOLID.OCP.Converter.Refractored
{
    public interface Converter
    {
        string Convert(Document document);
    }
}
