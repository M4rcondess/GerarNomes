using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarConsulta
{
    partial class Form1
    {
        /// <summary>
        /// Clean up any resources being used
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null ))

            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button button1;
        private DataGridView dataGridView1;
       

    }
}
