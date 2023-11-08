using Etap2.Shared.Entities;
using Etap2.Shared.Interfaces;

namespace Etap2.Core.Services
{
    public class TextAnalyzerService : ITextAnalyzerService
    {

        public TextAnalyzerService()
        {
        }

        public TextAnalyzeResult PerformAnalysis(string hugeInputValue)
        {
            TextAnalyzeResult result = new()
            {
                textLength = hugeInputValue.Length
            };

            foreach (char c in hugeInputValue)
            {
                if (!result.isAnyLetter && char.IsLetter(c))
                {
                    result.isAnyLetter = true;
                }
                else if (!result.isAnyDigit && char.IsDigit(c))
                {
                    result.isAnyDigit = true;
                }
                else if (!result.isAnySpecialCharacter && !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    result.isAnySpecialCharacter = true;
                }

                if (result.isAnyDigit && result.isAnyLetter && result.isAnySpecialCharacter)
                {
                    break;
                }

            }


            return result;

        }

    }

}

