namespace Etap2.Shared.Entities
{
    public class TextAnalyzeResult
    {
        public int textLength { get; set; }
        public bool isAnyLetter { get; set; }

        public bool isAnyDigit { get; set; }

        public bool isAnySpecialCharacter { get; set; }

    }
}
