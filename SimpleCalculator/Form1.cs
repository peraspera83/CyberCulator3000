using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCalculator
{
    public partial class CyberCulator3000 : Form
    {
        double result;
        string operation;
        bool first = true;
        bool keyPresed = false;
        string resultMem;

        public CyberCulator3000()
        {
            InitializeComponent();
        }

        private void delOperation(string op)
        {
            if (op != null && this.keyPresed == true)
            {
                string operand = txtOperand.Text;
                int opIndex = operand.IndexOf(op);
                operand = operand.Remove(opIndex, 1);
                this.keyPresed = false;
                txtOperand.Text = operand;

            }
        }

        private void postCulation()
        {
            first = false;
            txtOperand.Clear();
            txtOperand.Focus();
        }

        private void dispOperation(string operation)
        {
            txtOperationDisp.Text = operation;
        }

        private void clickCulation(string operation)
        {
            this.operation = operation;

            if (txtOperand.Text == "")
            {
                dispOperation(operation);
                txtOperand.Focus();
            }
            else
            {
                double operand = Convert.ToDouble(txtOperand.Text);
                if (first)
                {
                    result = operand;
                    dispOperation(operation);
                }
                else
                {
                    dispOperation(operation);

                    if (operation == "+") { result += operand; }
                    else if (operation == "-") { result -= operand; }
                    else if (operation == "*") { result *= operand; }
                    else { result /= operand; }

                    txtResult.Text = result.ToString();
                    resultList(result);
                }
            }
            txtOperand.Focus();
        }

        private void back()
        {
            if (resultMem != null)
            {
                string[] resultMemList;
                resultMem = resultMem.Trim();
                resultMemList = resultMem.Split(' ');
                int resLen = resultMemList.Length;

                if (resLen > 1)
                {
                    txtResultMem.Text = "";

                    resultMemList = resultMemList.Reverse().ToArray();
                    resultMemList = resultMemList.Skip(1).ToArray();
                    resultMemList = resultMemList.Reverse().ToArray();
                    resLen = resultMemList.Length;

                    resultMem = string.Join(" ", resultMemList);
                    txtResultMem.Text = resultMem;
                    result = Convert.ToDouble(resultMemList[resLen - 1]);
                    txtResult.Text = result.ToString();
                }
            }
            txtOperand.Focus();
        }

        private void resultList(double result)
        {

            resultMem += " " + result.ToString();
            txtResultMem.Text = resultMem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            clickCulation("+");
            postCulation();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            clickCulation("-");
            postCulation();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            clickCulation("*");
            postCulation();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            clickCulation("/");
            postCulation();
        }

        private void txtOperand_TextChanged(object sender, EventArgs e)
        {
            delOperation(operation);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (txtOperand.Text == "")
            {
                MessageBox.Show("Please enter a digit");
            }
            else
            {
                double operand = Convert.ToDouble(txtOperand.Text);

                if (first)
                {
                    MessageBox.Show("Please enter second digit");
                }
                else
                {
                    if (operation == "+") { result += operand; }
                    if (operation == "-") { result -= operand; }
                    if (operation == "*") { result *= operand; }
                    if (operation == "/") { if (operand == 0) {
                            MessageBox.Show("Cannot divide by zero");
                            txtOperand.Clear(); }
                        else { result /= operand; }
                    }

                    txtResult.Text = Convert.ToString(result);
                    resultList(result);
                }
            }
            operation = "";
            txtOperationDisp.Text = operation;
            postCulation();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            first = true;
            operation = "";
            resultMem = "";
            result = 0;
            txtOperand.Clear();
            txtResult.Clear();
            txtOperationDisp.Clear();
            txtResultMem.Clear();
            txtOperand.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMemoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOperand.Text = cmbMemoryList.SelectedItem.ToString();
        }

        private void btnMemPlus_Click(object sender, EventArgs e)
        {
            cmbMemoryList.Items.Add(result.ToString());
            txtOperand.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbMemoryList.Items.Clear();
            txtOperand.Focus();
        }

        private void btnDelChar_Click(object sender, EventArgs e)
        {
            back();
            txtOperand.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyPresed = false;

            if (e.KeyCode == Keys.Add)
            {
                btnAdd.PerformClick();
                this.keyPresed = true;
            }
            if (e.KeyCode == Keys.Subtract)
            {
                btnSubstract.PerformClick();
                keyPresed = true;
            }
            if (e.KeyCode == Keys.Multiply)
            {
                btnMultiply.PerformClick();
                keyPresed = true;
            }
            if (e.KeyCode == Keys.Divide)
            {
                btnDivide.PerformClick();
                keyPresed = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnCalculate.PerformClick();
            }
        }

        private void txtOperationDisp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtResultMem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
