using Etap2.Presenters;
using System.Diagnostics;

namespace Etap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TextAnalyzerDataPresenter textAnalyzerDataPresenter;

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            textAnalyzerDataPresenter.PerformAnalysis(hugeTextInput.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textAnalyzerDataPresenter = new TextAnalyzerDataPresenter(textLenInput, isAnyDigitInput, isAnyLetterInput, isAnySpecialCharInput, timeElapsedInput);
        }
    }
}