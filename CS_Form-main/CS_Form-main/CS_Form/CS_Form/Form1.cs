﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {



                TestButton testButton = new TestButton((i % 5)* 100, (i % 2)* 100, 100, 100,i);

                Controls.Add(testButton);
            }
           // TestButton testButton2 = new TestButton(100,100,100,100);
           //
           // Controls.Add(testButton2);
           //
           // TestButton testButton3 = new TestButton(100, 0, 100, 100);
           //
           // Controls.Add(testButton3);
           //
           // TestButton testButton4 = new TestButton(100, 200, 100, 100);
           //
           // Controls.Add(testButton4);
           //
           // TestButton testButton5 = new TestButton(200, 0, 100, 100);
           //
           // Controls.Add(testButton5);
           //
           // TestButton testButton6 = new TestButton(200, 100, 100, 100);
           //
           // Controls.Add(testButton6);
           //
           // TestButton testButton7 = new TestButton(200, 200, 100, 100);
           //
           // Controls.Add(testButton7);
           //
           // TestButton testButton8 = new TestButton(300, 0, 100, 100);
           //
           // Controls.Add(testButton8);
           //
           // TestButton testButton9 = new TestButton(300, 100, 100, 100);
           //
           // Controls.Add(testButton9);
           //
           // TestButton testButton10 = new TestButton(300, 200, 100, 100);
           //
           // Controls.Add(testButton10);

        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
