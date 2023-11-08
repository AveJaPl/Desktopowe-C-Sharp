using Etap2.Core.Services;
using Etap2.Shared.Interfaces;
using System.Diagnostics;

namespace Etap2.Presenters
{
    public class TextAnalyzerDataPresenter
    {
        private readonly TextBox _textLenInput;
        private readonly TextBox _isAnyDigitInput;
        private readonly TextBox _isAnyLetterInput;
        private readonly TextBox _isAnySpecialCharInput;
        private readonly TextBox _timeElapsedInput;

        private readonly ITextAnalyzerService _textAnalyzerService;

        public TextAnalyzerDataPresenter(TextBox? textLenInput, TextBox? isAnyDigitInput, TextBox? isAnyLetterInput, TextBox? isAnySpecialCharInput, TextBox? timeElapsedInput)
        {
            _textLenInput = textLenInput;
            _isAnyDigitInput = isAnyDigitInput;
            _isAnyLetterInput = isAnyLetterInput;
            _isAnySpecialCharInput = isAnySpecialCharInput;
            _timeElapsedInput = timeElapsedInput;
            _textAnalyzerService = new TextAnalyzerService();
        }


        public void PerformAnalysis(string hugeInputValue)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            Shared.Entities.TextAnalyzeResult result = _textAnalyzerService.PerformAnalysis(hugeInputValue);

            stopwatch.Stop();

            _textLenInput.Text = result.textLength.ToString();
            _isAnyDigitInput.Text = result.isAnyDigit ? "Tak" : "Nie";
            _isAnyLetterInput.Text = result.isAnyLetter ? "Tak" : "Nie";
            _isAnySpecialCharInput.Text = result.isAnySpecialCharacter ? "Tak" : "Nie";
            _timeElapsedInput.Text = stopwatch.Elapsed.ToString();

        }
    }
}
