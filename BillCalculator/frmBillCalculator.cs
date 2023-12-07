

namespace Lab2Fixed
{
    public partial class frmBillCalculator : Form
    {
        public frmBillCalculator()
        {
            InitializeComponent();
        }

        //declare a list of customers
        private List<Customer> customerList = new List<Customer>();

        //display list of customer information
        public void displayCustomers()
        {
            foreach (Customer customer in customerList)
            {
                string customerInfo = $"{customer.AccountNum}: {customer.LastName}, {customer.FirstName}. kWh used: {customer.NumberOfKwh}. Bill amount: ${customer.BillAmount}";
                listExistingCust.Items.Add(customerInfo);
            }

        }
        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            //convert account number so that it is checked and stored as an integer, not a string
            int acctNum = Int32.Parse(txtAccNum.Text);

            //because Kwh Used is stored as a decimal in a customer object, and used for calculation, it is converted to decimal and 
            // made into a variable for later use, here
            decimal kWhUsed = Convert.ToDecimal(txtKwh.Text);

            //calculate bill amount and create variable
            decimal billAmount = Customer.CalculateCharge(Convert.ToDecimal(txtKwh.Text));

            //create new customer
            Customer newCustomer = new Customer(acctNum, txtFName.Text, txtLName.Text, kWhUsed, billAmount);

            //validate string inputs
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ -.abcdefghijklmnopqrstuvwxyz";
            if (InputValidator(txtFName.Text, alpha, " first name")
                & InputValidator(txtLName.Text, alpha, " last name")

            // validate number inputs
            & InputValidator(txtKwh.Text, "1234567890.", " number of kWh used")
                & InputValidator(txtAccNum.Text, "1234567890", "n account number")

            //check that account number is not redundant
            & AccountRedundancyValidator(acctNum)
                //check that kwh is positive
                & KwhIsPositive(kWhUsed)) //!!! why is messagebox appearing twice?
            {
                AddToDB(newCustomer);
                txtNumOfCust.Text = NumOfCust();
                txtKwhUsed.Text = NumOfKwhUsed();
                txtAvgBillAmount.Text = $"${AvgBillAmt()}";
            }

            // update customer list display
            listExistingCust.Items.Clear();
            displayCustomers();
        }

        //Generate a new account number
        public int AcctNumGenerator()
        {
            Random random = new Random();
            int acctNum = random.Next();
            return acctNum;
        }

        //check that input is of the correct type
        public bool InputValidator(string input, string parameter, string type)
        {
            //check whether input characters appear inside desired parameter string
            for (int i = 0; i < input.Length; i++)
            {
                if (!parameter.Contains(input[i]))
                {
                    MessageBox.Show($"Input failed. Please enter a{type}");
                    return false;
                }
            }
            return true; // returns true in the absence of unwanted chars

        }

        //check whether account number is already in database
        public bool AccountRedundancyValidator(int acctNum)
        {
            if (customerList.Any(cust => cust.AccountNum == acctNum))
            {
                MessageBox.Show($"Input failed. That account number is already attached to a customer in our database. Please find that account in the database, or enter a new account number.");
                return false;
            }
            else
                return true;
        }
        // check whether kwh input is positive
        public bool KwhIsPositive(decimal num)
        {
            //decimal num = Convert.ToDecimal(kwh);

            if (num <= 0)
            {
                MessageBox.Show("Input failed. Please enter a positive number for kWh used.");
                return false;
            }
            else
                return true;

        }

        //add customer object to customer list
        public void AddToDB(Customer cust)
        {
            customerList.Add(cust);
        }

        //load form and display customer list 
        private void Main_Load(object sender, EventArgs e)
        {
            displayCustomers();

        }
        ////calculate # of customers processed
        public string NumOfCust()
        {
            return customerList.Count.ToString();
        }

        //// calculate # of kWh used
        public string NumOfKwhUsed()
        {
            decimal total = 0;

            foreach (Customer cust in customerList)
            {
                total += cust.NumberOfKwh;
            }

            return total.ToString();
        }

        //// calculate average bill amount
        public string AvgBillAmt()
        {
            decimal count = 0;
            decimal sum = 0;

            foreach (Customer cust in customerList)
            {
                sum += cust.BillAmount;
                count += 1;
            }

            decimal average = sum / count;
            return average.ToString("0.00");
        }

        private void frmBillCalculator_Load(object sender, EventArgs e)
        {

        }
        ////allow user to generate new account number 
        private void btnAcctGen_Click(object sender, EventArgs e)
        {
            int newAccountNum = AcctNumGenerator();
            txtAccNum.Text = Convert.ToString(newAccountNum);

        }
    }
}