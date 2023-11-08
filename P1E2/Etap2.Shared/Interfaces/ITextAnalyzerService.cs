using Etap2.Shared.Entities;

namespace Etap2.Shared.Interfaces
{
    public interface ITextAnalyzerService
    {

        TextAnalyzeResult PerformAnalysis(string text);
    }
}
