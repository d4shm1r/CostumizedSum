using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostumizedSum {
    public partial class Form1 : Form {
        /*
         * This form app is a simple
         * calculator which calculates
         * a costumized sum with user defined
         * start value and end value.
         * The formula will be uploaded at Readme.md
         * on this repo.
         */
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            int startValue = Convert.ToInt32(textBox1.Text);
            int endValue = Convert.ToInt32(textBox2.Text);
            int sum2 = 0;
            int sum3 = 0;


            for (int j = 1; j <= endValue; j++) {
                sum2 = sum2 + j;
            }

            for (int k = 1; k <= startValue - 1; k++) {
                sum3 = sum3 + k;
            }
            int sum1 = sum2 - sum3;
            textBox3.Text = Convert.ToString(sum1);

            /*
            The above program could be simplified into this shorter code
            it works the same.

            int startValue = Convert.ToInt32(textBox1.Text);
            int endValue = Convert.ToInt32(textBox2.Text);
            int sum = 0;
            for (int i = startValue; i <= endValue; i++) {
                sum = sum + i;
            }
            textBox3.Text = Convert.ToString(sum);
            */
        }
    }
}
