using System.Diagnostics;

namespace Etap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            string baseText = hugeTextInput.Text;
            bool isAnyLetter = false;
            bool isAnyDigit = false;
            bool isAnySpecialChar = false;

            textLenInput.Text = baseText.Length.ToString();


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (char c in baseText)
            {
                if (!isAnyLetter && char.IsLetter(c))
                {
                    isAnyLetter = true;
                }
                else if (!isAnyDigit && char.IsDigit(c))
                {
                    isAnyDigit = true;
                }
                else if (!isAnySpecialChar && !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    isAnySpecialChar = true;
                }

                if (isAnyDigit && isAnyLetter && isAnySpecialChar)
                {
                    break;
                }

            }

            stopwatch.Stop();

            isAnyDigitInput.Text = isAnyDigit.ToString();
            isAnyLetterInput.Text = isAnyLetter.ToString();
            isAnySpecialCharInput.Text = isAnySpecialChar.ToString();
            timeElapsedInput.Text = stopwatch.Elapsed.ToString();

        }
    }
}