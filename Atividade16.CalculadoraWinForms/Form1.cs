using System.Collections;

namespace Atividade16.CalculadoraWinForms
{
     public partial class Calculadora : Form
     {
          private double numberOne, numberTwo, OperationResult;
          private List<double> listOfNumbers = new List<double>();
          private int numberLength = 13;
          private string operation;

          public Calculadora()
          {
               InitializeComponent();
          }

          private void Calculadora_Load(object sender, EventArgs e)
          {

          }

          private void textBox1_TextChanged(object sender, EventArgs e)
          {
          }

          private void button0_Click(object sender, EventArgs e)
          {
               if (numberField.Text.Length < numberLength)
                    numberField.Text += "0";
          }
          private void button1_Click(object sender, EventArgs e)
          {
               if (numberField.Text.Length < numberLength)
                    numberField.Text += "1";
          }
          private void button2_Click(object sender, EventArgs e)
          {
               if (numberField.Text.Length < numberLength)
                    numberField.Text += "2";
          }
          private void button3_Click(object sender, EventArgs e)
          {
               if (numberField.Text.Length < numberLength)
                    numberField.Text += "3";
          }

          private void button4_Click(object sender, EventArgs e)
          {
               if (numberField.Text.Length < numberLength)
                    numberField.Text += "4";
          }

          private void button5_Click(object sender, EventArgs e)
          {
               if (numberField.Text.Length < numberLength)
                    numberField.Text += "5";
          }

          private void button6_Click(object sender, EventArgs e)
          {
               if (numberField.Text.Length < numberLength)
                    numberField.Text += "6";
          }

          private void button7_Click(object sender, EventArgs e)
          {
               if (numberField.Text.Length < numberLength)
                    numberField.Text += "7";
          }

          private void button8_Click(object sender, EventArgs e)
          {
               if (numberField.Text.Length < numberLength)
                    numberField.Text += "8";
          }

          private void button9_Click(object sender, EventArgs e)
          {
               if (numberField.Text.Length < numberLength)
                    numberField.Text += "9";
          }

          private void buttonEqual_Click(object sender, EventArgs e)
          {
               numberField.Text = MathOperation().ToString();
               numberOne = 0;
               numberTwo = 0;
          }
          private double MathOperation()
          {
               if (operation == "+")
                    return numberOne + numberTwo;

               else if (operation == "-")
                    return numberOne - numberTwo;

               else if (operation == "/")
                    return numberOne / numberTwo;

               else if (operation == "*")
                    return numberOne * numberTwo;

               return numberOne;
          }

          private void buttonSum_Click(object sender, EventArgs e)
          {
               if (textOperation.Text == "")
                    numberOne = double.Parse(numberField.Text);

               else
               {
                    numberTwo = double.Parse(numberField.Text);
               }

               numberField.Text = "";
               textOperation.Text = $"{numberOne} + ";
               operation = "+";
          }
          private void buttonSubtraction_Click(object sender, EventArgs e)
          {
               if (textOperation.Text == "")
                    numberOne = double.Parse(numberField.Text);

               else
               {
                    numberTwo = double.Parse(numberField.Text);
               }

               numberField.Text = "";
               textOperation.Text = $"{numberOne} - ";
               operation = "-";
          }

          private void buttonMultiplication_Click(object sender, EventArgs e)
          {
               if (textOperation.Text == "")
                    numberOne = double.Parse(numberField.Text);

               else
               {
                    numberTwo = double.Parse(numberField.Text);
               }

               numberField.Text = "";
               textOperation.Text = $"{numberOne} x ";
               operation = "*";
          }

          private void buttonDivide_Click(object sender, EventArgs e)
          {
               if (textOperation.Text == "")
                    numberOne = double.Parse(numberField.Text);

               else
               {
                    numberTwo = double.Parse(numberField.Text);
               }

               numberField.Text = "";
               textOperation.Text = $"{numberOne} * ";
               operation = "/";
          }
     }
}