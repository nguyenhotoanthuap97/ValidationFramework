using System;
using System.Windows.Forms;
using MyValidate.Validator;
using MyValidate.Message;
using MyValidate.Result;
using System.Collections.Generic;

namespace DemoValidate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //validator = new Validator(LangCode.vi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validator validator = new Validator();
            Validator validator = new Validator(LangCode.vi);

            string text = (textBox1.Text);
            validator.IsEmail("text",text);
            MessageBox.Show(validator.ErrorToString(new ErrorByName("tn")));
            MessageBox.Show(validator.ErrorToString(new UniqueError()));

        }
    }
}
