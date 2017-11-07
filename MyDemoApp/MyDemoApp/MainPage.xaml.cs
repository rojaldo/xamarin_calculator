using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyDemoApp
{
    public partial class MainPage : ContentPage
    {
        private int firstFigure;
        private int currentFigure;
        private string myOperator;
        private bool resolved = true;

        void button_clicked(object sender, EventArgs e)
        {
            if(this.resolved == true)
            {
                this.label_result.Text = "";
                this.resolved = false;
            }
            Button clickedButton = (Button)sender;
            Console.WriteLine("output: "+clickedButton.Text);
            if (clickedButton.Equals(button_0))
            {
                addFigure(0);
            }else if (clickedButton.Equals(button_1))
            {
                addFigure(1);
            }
            else if (clickedButton.Equals(button_2))
            {
                addFigure(2);
            }
            else if (clickedButton.Equals(button_3))
            {
                addFigure(3);
            }
            else if (clickedButton.Equals(button_4))
            {
                addFigure(4);
            }
            else if (clickedButton.Equals(button_5))
            {
                addFigure(5);
            }
            else if (clickedButton.Equals(button_6))
            {
                addFigure(6);
            }
            else if (clickedButton.Equals(button_7))
            {
                addFigure(7);
            }
            else if (clickedButton.Equals(button_8))
            {
                addFigure(8);
            }
            else if (clickedButton.Equals(button_9))
            {
                addFigure(9);
            }
            else if (clickedButton.Equals(button_plus))
            {
                addOperator("+");
            }
            else if (clickedButton.Equals(button_minus))
            {
                addOperator("-");
            }
            else if (clickedButton.Equals(button_multiply))
            {
                addOperator("*");
            }
            else if (clickedButton.Equals(button_divide))
            {
                addOperator("/");
            }
            else if (clickedButton.Equals(button_equal))
            {
                resolve();
            }
        }

        private void resolve()
        {
            if (this.myOperator.Equals("+")){
                this.label_result.Text = this.firstFigure + "+" + this.currentFigure + "=" + (this.firstFigure + this.currentFigure);
            }
            else if (this.myOperator.Equals("-")){
                this.label_result.Text = this.firstFigure + "-" + this.currentFigure + "=" + (this.firstFigure - this.currentFigure);
            }
            else if (this.myOperator.Equals("*")){
                this.label_result.Text = this.firstFigure + "*" + this.currentFigure + "=" + (this.firstFigure * this.currentFigure);
            }
            else if (this.myOperator.Equals("/")){
                this.label_result.Text = this.firstFigure + "/" + this.currentFigure + "=" + (this.firstFigure / this.currentFigure);
            }
            this.currentFigure = 0;
            this.firstFigure = 0;
            this.resolved = true;
        }

        private void addOperator(string v)
        {
            this.label_result.Text = this.label_result.Text + v;
            this.firstFigure = this.currentFigure;
            this.myOperator = v;
            this.currentFigure = 0;
        }

        void addFigure(int figure)
        {
            this.label_result.Text = this.label_result.Text + figure;
            this.currentFigure = this.currentFigure * 10 + figure;
        }
        public MainPage()
        {
            Console.WriteLine("Start app");
            InitializeComponent();
        }
    }
}
