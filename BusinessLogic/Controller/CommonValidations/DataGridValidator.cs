using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Controller
{
    public class DataGridValidator
    {
        private System.Windows.Forms.DataGridView data { get; set; }
        public DataGridValidator(System.Windows.Forms.DataGridView d)
        {
            this.data = d;
        }

        public void GridMarcasInit(int ColumnIndex, String Header, int Width)
        {
            data.Columns[ColumnIndex].HeaderText = Header;
            data.Columns[ColumnIndex].Width = Width;
        }
  }
}
