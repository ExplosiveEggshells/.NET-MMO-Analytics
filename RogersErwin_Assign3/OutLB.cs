using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersErwin_Assign3
{
    class OutLB
    {
        private ListBox listBox;

        public OutLB (ref ListBox listBox)
        {
            this.listBox = listBox;
        }

        public void AddString(string entry) 
        {
            OutBox.Items.Add(entry);
        }

        public void Clear()
        {
            OutBox.Items.Clear();
        }

        public ListBox OutBox { get { return listBox;} }
    }
}
