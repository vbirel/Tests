﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    class Information
    {
        public static int idTicer, idStudent, idGrup, idTime, idTest;
        public static string nameTicher, nameStudent, connectionString, nameTest;
        public static int taupOfTest = 0;

        public static void TextBoxDynamic(Panel panel, int left, int top, int width, int height)
        {
            TextBox tb = new TextBox(); 
            tb.Multiline = true; 
            tb.ScrollBars = ScrollBars.Both;
            tb.Height = height;
            tb.Width = width;
            tb.Left = left;
            tb.Top = top;
            tb.BackColor = Color.White;            
            tb.ReadOnly = false;
            panel.Controls.Add(tb); 
        }
       
        public static void RadioButtonDynamic(Panel panel, int left, int top, int width, int height)
        {
            RadioButton rb = new RadioButton();
            rb.Checked = false;
            rb.Height = height;
            rb.Width = width;
            rb.Left = left;
            rb.Top = top;
            rb.Text = "";
            panel.Controls.Add(rb);
        }
        
        public static void CheckBoxDynamic(Panel panel, int left, int top, int width, int height)
        {
            CheckBox cb = new CheckBox();
            cb.Checked = false;
            cb.Height = height;
            cb.Width = width;
            cb.Left = left;
            cb.Top = top;
            cb.Text = "";
            panel.Controls.Add(cb);
        }
    }
}
