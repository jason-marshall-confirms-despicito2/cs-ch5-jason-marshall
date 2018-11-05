using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program5_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Create a random object named rand and assign it a random integer
        Random rand = new Random();

        // Declare three integers: n, guess, and attempt
        int n, guess, attempt;

        // Before the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            // Call the getNumber method
            getNumber();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            // If txtNumber.Text can be parsed as an integer, assign that value to guess
                // Increment attempt
                // If guess = n

                    /* Output to lblOutput the following:
                     * 
                     * "You tried " + attempt + " time(s). \n" +
                     * "Your last guess is " + guess + "\n" +
                     * "Congratulations, you won! Enter a number to start again."
                     * 
                     */
                     // Clear txtNumber
                     // Call the getNumber method
                 
                // else if guess > n
                    
                    /* Output to lblOutput the following:
                     * 
                     * You tried " + attempt + " time(s).\n" + guess + " is too high. Try again."
                     * 
                     */
                     // Clear txtNumber

                // else

                    /* Output to lblOutput the following:
                     * 
                     * "You tried " + attempt + " time(s).\n" + guess + is too low, try again."
                     * 
                     */
                     // clear txtNumber
            }
        }

        // This is the getNumber method
        public void getNumber()
        {
            // Assign a random integer between 1 and 100 to integer n
            // Set attempt to 0
        }
    }
}
