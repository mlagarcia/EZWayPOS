using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Controller.CommonValidator
{
    public class CboValidator
    {
        public CboValidator()
        { //Void constructor
        }

        public void CboInit(System.Windows.Forms.ComboBox Cbo)
        {
            Cbo.DropDownHeight = Cbo.Font.Height * 5;
            Cbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            Cbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }
    }
}
