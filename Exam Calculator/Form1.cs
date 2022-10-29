namespace Exam_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            
            
            

            
            try
            {
                double midtermVal = Convert.ToDouble(textBoxMidterm.Text);
                double finalVal = Convert.ToDouble(textBoxFinal.Text);
                double snc = (midtermVal * 0.3) + (finalVal * 0.7);
                if (snc >= 60)
                {
                    labelResult.Text = "Congratulations!\nYou've passed the exam.";
                }
                else if (snc < 60)
                {
                    labelResult.Text = "Sorry!\nYou have not passed the exam.";
                }
            }
            catch (Exception ex)
            {
                labelResult.Text = "An error occured.\nPlease check your value.";
            }






           
            
            
           
            


        }
    }
}