using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripDemo
{
    public partial class Form1 : Form
    {
        // global constants
        int[] SIZE = {10, 25, 40};
        Color[] COLOR = new Color[] {Color.Blue, Color.Green,
            Color.Red, Color.Yellow, Color.White, Color.Black};
        List<string> colorList = new List<string>{ "Blue", "Green", "Red",
            "Yellow", "White", "Black" };
        List<string> sizeList = new List<string>{ "Small", "Medium", "Large" };

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_OnSelectionIndexChange(object sender, EventArgs e)
        {
            refreshFont();
        }

        // refreshFont method updates the text with the new selected options
        private void refreshFont() // refreshFont method start
        {
            outputLabel.Font = new Font("Sans Serif", SIZE[toolStripComboBox2.SelectedIndex]);
            outputLabel.ForeColor = COLOR[toolStripComboBox1.SelectedIndex];
        } // refreshFont method end
    }
}
