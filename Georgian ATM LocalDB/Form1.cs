using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Georgian_ATM_LocalDB
{
    public partial class Form1 : Form
    {
        double InterestRate, monthlyInterestRate, loanAmount, MonthlyPayment, TotalPayment;
        int numberOfYears;
        String iMonthlyPayment, iTotalPayment;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "8";
        }

        private void tbn9_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPin.Text = "";
            lblBalace.Visible = false;
            lblDeposit.Visible = false;
            lblLoan.Visible = false;
            lblWithdrawal.Visible = false;
            btnLoan.Enabled = false;
            btnDeposit.Enabled = false;
            btnBalance.Enabled = false;
            btnWithdrawal.Enabled = false;
            btnLoanSystem.Enabled = false;
            btnExitSystem.Enabled = false;
            btnResetSystem.Enabled = false;
            btnReceiptSystem.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("გსურს გათიშვა?", "Georgian ATM შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBalace.Visible = false;
            lblDeposit.Visible = false;
            lblLoan.Visible = false;
            lblWithdrawal.Visible = false;
            btnLoan.Enabled = false;
            btnDeposit.Enabled = false;
            btnBalance.Enabled = false;
            btnWithdrawal.Enabled = false;
            btnLoanSystem.Enabled = false;
            btnExitSystem.Enabled = false;
            btnResetSystem.Enabled = false;
            btnReceiptSystem.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String pin1 = String.Format(lblPin.Text);
            String pin2 = String.Format(lblPin.Text);
            String pin3 = String.Format(lblPin.Text);
            String pin4 = String.Format(lblPin.Text);
            String pin5 = String.Format(lblPin.Text);

            if (pin1 == "1234")
            {
                lblBalace.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawal.Visible = true;
                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdrawal.Enabled = true;
                lblPin.Text = "";
            }
            else if (pin2 == "2345")
            {
                lblBalace.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawal.Visible = true;
                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdrawal.Enabled = true;
                lblPin.Text = "";
            }
            else if (pin3 == "3456")
            {
                lblBalace.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawal.Visible = true;
                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdrawal.Enabled = true;
                lblPin.Text = "";
            }
            else if (pin4 == "4567")
            {
                lblBalace.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawal.Visible = true;
                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdrawal.Enabled = true;
                lblPin.Text = "";
            }
            else if (pin5 == "5678")
            {
                lblBalace.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawal.Visible = true;
                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdrawal.Enabled = true;
                lblPin.Text = "";
            }
            else
            {
                lblPin.Text = "PIN არასწორია!";
                lblBalace.Text = "შეცდომა:";
                lblBalace.Visible = true;
                btnLoan.Enabled = false;
                btnDeposit.Enabled = false;
                btnBalance.Enabled = false;
                btnWithdrawal.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReceiptSystem_Click(object sender, EventArgs e)
        {
            rtfReceipt.AppendText("სესხის კალკუტორიში" + "\n");
            rtfReceipt.AppendText("--------------------------------" + "\n");
            rtfReceipt.AppendText("შეიყვანეთ სესხის ოდენობა" + "\t" + txtAmountOfLoan.Text + "\n");
            rtfReceipt.AppendText("შეიყვანეთ წელი" + "\t" + txtNumberOfYears.Text + "\n");
            rtfReceipt.AppendText("შეიყვანეთ პროცენტი" + "\t" + "\t" + txtInterestRate.Text + "\n");
            rtfReceipt.AppendText("თვიური გადასახადი" + "\t" + lblMonthlyPayment.Text + "\n");
            rtfReceipt.AppendText("ჯამი" + "\t" + "\t" + "\t" + lblTotalPayment.Text + "\n");
            rtfReceipt.AppendText("----------------------------------------------" + "\n");
            rtfReceipt.AppendText("----------მადლობა----------" + "\n");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            btnLoanSystem.Enabled = true;
            btnExitSystem.Enabled = true;
            btnResetSystem.Enabled = true;
            btnReceiptSystem.Enabled = true;
        }

        private void btnExitSystem_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("გსურს გათიშვა?", "Georgian ATM შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnResetSystem_Click(object sender, EventArgs e)
        {
            txtAmountOfLoan.Clear();
            txtNumberOfYears.Clear();
            txtInterestRate.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtfReceipt.Clear();
        }

        private void btnLoanSystem_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInterestRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            loanAmount = Convert.ToDouble(txtAmountOfLoan.Text);

            MonthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));

            //-----------------------------------------------------------------------------------------------------------------
            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);
            //-----------------------------------------------------------------------------------------------------------------
            TotalPayment = MonthlyPayment * numberOfYears * 12;
            iTotalPayment = String.Format("{0:C}", MonthlyPayment);
            lblTotalPayment.Text = (iTotalPayment);

            txtAmountOfLoan.Text = String.Format("{0:C}", loanAmount);

        }
    }
}
