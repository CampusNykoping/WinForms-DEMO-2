using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingData
{
    public partial class Form2 : Form
    {
        private string _title;
        private string _text;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string title, string text) : this()
        {
            _title = title;
            _text = text;

            this.Text = _title;
            label1.Text = _text;
        }
    }
}
