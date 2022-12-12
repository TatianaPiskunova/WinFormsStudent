using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace экзамен
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
         
            r1 = richTextBox1;
            lab1 = label1_ListStud;
        }
      
        public static RichTextBox r1 = new RichTextBox();
        public static Label lab1 = new Label();
    }
}
