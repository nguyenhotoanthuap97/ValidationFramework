using System;
using System.Windows.Forms;
using MyValidate.Validator;
using MyValidate.Message;
using MyValidate.Result;
using MyValidate.ValidateMethod;
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
            string firstname = firstnametxb.Text;
            string lastname = lastnametxb.Text;
            int discount = HelperMethod.ToInt(discounttxb.Text);
            string password = passwordtxb.Text;
            string email = emailtxb.Text;

            Validator validator = MyCustomValidator(firstname, lastname, discount, password, email);
            MessageBox.Show(validator.ErrorToString(new AllError()));
        }

        public Validator MyCustomValidator(string firstname, string lastname, int discount, string password, string email)
        {
            Validator validator = new Validator(LangCode.vi);
            validator.IsNotNullOrEmpty("firstname", firstname)
                .IsNotNullOrEmpty("lastname", lastname)
                .IsMaxLength("lastname", lastname, 40)
                .IsNotZero("discount", discount)
                .IsBetweenLength("email", email, 6, 40)
                .IsEmail("email", email)
                .IsPassword("password", password)
                .Must("custom",()=>
                {
                    return false;
                });
            return validator;
        }
    }
}
