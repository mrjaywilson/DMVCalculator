// Import API
using System;
using System.Drawing;
using System.Windows.Forms;

// Namespace Declaration
namespace CST_117_Project_1
{
    // Class Declaration
    public partial class frmCalculator : Form
    {
        // Declare and initialize Calculate object
        Calculate calculate = new Calculate();

        /// <summary>
        /// This is the entrypoint of the program
        /// </summary>
        public frmCalculator()
        {
            // Initialize
            InitializeComponent();
        }

        /// <summary>
        /// Switches form to calculate density
        /// </summary>
        private void btnDensity_Click(object sender, EventArgs e)
        {
            // Method to update form for density calculation
            UpdateForm(74, "p = m / V", Calculate.FormulaType.DENSITY);

            // Update label components
            lblComponentOne.Text = "Mass";
            lblComponentTwo.Text = "Volume";
            lblTitle.Text = "Calculate Density";
        }

        /// <summary>
        /// Switches form to calculate mass
        /// </summary>
        private void btnMass_Click(object sender, EventArgs e)
        {
            // Method to update form for density calculation
            UpdateForm(135, "m = p \u00B7 V", Calculate.FormulaType.MASS);

            // Update label components
            lblComponentOne.Text = "Density";
            lblComponentTwo.Text = "Volume";
            lblTitle.Text = "Calculate Mass";
        }

        /// <summary>
        /// Switches form to calculate volume
        /// </summary>
        private void btnVolume_Click(object sender, EventArgs e)
        {
            // Method to update form for density calculation
            UpdateForm(195, "V = m / p", Calculate.FormulaType.VOLUME);

            // Update label components
            lblComponentOne.Text = "Mass";
            lblComponentTwo.Text = "Density";
            lblTitle.Text = "Calculate Volume";
        }

        /// <summary>
        /// Exit the program
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Method to exit the program
            Application.Exit();
        }

        /// <summary>
        /// Update the form
        /// </summary>
        /// <param name="locationY">Update the location of the indicator on the y axis.</param>
        /// <param name="strFormula">Update formula label with formula for both reference and use.</param>
        /// <param name="currentFormula">Update enum to indicate which formula to use for calculation.</param>
        private void UpdateForm(int locationY, String strFormula, Calculate.FormulaType currentFormula)
        {
            // update indicator
            pnIndicator.Location = new Point(144, locationY);

            // Update formula label
            lblFormula.Text = strFormula;

            // Set enum
            calculate.currentFormula = currentFormula;
        }

        /// <summary>
        /// Calculate formula
        /// </summary>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare and initialize primitive type variables
            double mass = 0d,
                density = 0d,
                volume = 0d,
                answer = 0d;


            // Error catching
            try
            {
                // Switch check the enum to figure out which formula should be used
                switch (calculate.currentFormula)
                {
                    // If density...
                    case Calculate.FormulaType.DENSITY:

                        // Error catch text fields and place in proper variable
                        Double.TryParse(txtFieldOne.Text, out mass);
                        Double.TryParse(txtFieldTwo.Text, out volume);

                        // Do calculation
                        answer = mass / volume;

                        // Check the answer
                        if (Double.IsNaN(answer))
                        {
                            // let user know about the error
                            lblNotice.Text = "Error. Try Again.";
                        }
                        else
                        {
                            // Output the value with three exact digits past the decimal
                            lblFormula.Text = "Density = " + answer.ToString("#.000");

                            // Clean up the notice label
                            lblNotice.Text = "";
                        }

                        // Break from switch
                        break;

                    // If mass...
                    case Calculate.FormulaType.MASS:

                        // Error catch text fields and place in proper variable
                        Double.TryParse(txtFieldOne.Text, out density);
                        Double.TryParse(txtFieldTwo.Text, out volume);

                        // Do calculation
                        answer = density * volume;

                        // Check answer
                        if (Double.IsNaN(answer))
                        {
                            // let user know about error
                            lblNotice.Text = "Error. Try Again.";
                        }
                        else
                        {
                            // Output the value with three exact digits past the decimal
                            lblFormula.Text = "Mass = " + answer.ToString("#.000");

                            // Clean up the notice label
                            lblNotice.Text = "";
                        }

                        // Break from switch
                        break;

                    // If volume...
                    case Calculate.FormulaType.VOLUME:

                        // Error catch text fields and place in proper variable
                        Double.TryParse(txtFieldOne.Text, out mass);
                        Double.TryParse(txtFieldTwo.Text, out density);

                        // Do calculation
                        answer = mass / density;

                        // Check answer
                        if (Double.IsNaN(answer))
                        {
                            // Let the user know about the error
                            lblNotice.Text = "Error. Try Again.";
                        }
                        else
                        {
                            // Output the value with three exact digits past the decimal
                            lblFormula.Text = "Volume = " + answer.ToString("#.000");

                            // Clean up the notice label
                            lblNotice.Text = "";
                        }

                        // Break from switch
                        break;
                }
                // Catching an exceptions
            } catch (Exception exception)
            {
                // Show a message box with error message in the event an error occurs.
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
