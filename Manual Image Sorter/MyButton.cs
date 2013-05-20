using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manual_Image_Sorter
{
    public partial class MyButton : Button
    {
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control:
                    return true;
                case Keys.Right:
                    return true;
                case Keys.Left:
                    return true;
                case Keys.Alt:
                    return true;
                default:
                    return base.IsInputKey(keyData);
            }
            if (keyData == Keys.Right)
            {
                return true;
            }
            else
            {
                return base.IsInputKey(keyData);
            }
        }
    }
}
