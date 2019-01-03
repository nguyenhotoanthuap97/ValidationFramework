using System;
using System.Windows.Forms;
using MyValidate.Validator;
using MyValidate.SpecifyValidator;
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
            Validator validator = new IsEmailString(LangCode.en);

            string text = (textBox1.Text);
            validator.Check(text);

            Validator validator2 = new IsNotNullOrEmptyString(validator);
            validator2.Check(text);

            Validator validator3 = new IsNotNullOrWhiteSpaceString(validator2);
            validator3.Check(text);

            MessageBox.Show(validator3.ErrorToString(new UniqueError()));

        }
    }
}
