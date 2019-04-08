using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocFilter
{
    public partial class FVocFilter : Form
    {
        public FVocFilter()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tBText.Text = "";
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            //приводит к нормальному виду (в строке только буквы и пробелы)
            tBText.Text=Normalize.GetLettersAndSpaces(tBText.Text);
            //поиск точных совпадений
            //поиск нечтоных совпадений
            //поиск "разбитых" нежелательных слов
        }
    }
}
