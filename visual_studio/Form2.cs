using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2( string textbox)
        {
            InitializeComponent();
            this.Text = textbox;
            label1.Text = textbox; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                var pysrc = 
                @"def print_text(str1):           
                    return str1";
                // Creating Engine for excecuting python code
                var engine = IronPython.Hosting.Python.CreateEngine();
                // Creating a scope for ourself because we don't have global scope like earlier versions
                var scope = engine.CreateScope();
                engine.Execute(pysrc, scope);
                // To invoke the funtion dynamically
                var res = scope.GetVariable("print_text");
               // var calcAddTyped = scope.GetVariable<Func<string, string>>("print_text");
               // var resultTyped = calcAddTyped("Hello World !!");
               string lable_text = label1.Text;
                var result = res(lable_text);
                label2.Text = result;
            }
            catch (Exception E)
            {
                Console.WriteLine("Oops! We couldn't print your message because of an exception: " + E.Message);
            }
        }
    }
}
