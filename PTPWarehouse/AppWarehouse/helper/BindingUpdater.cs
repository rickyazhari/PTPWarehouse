using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace AppWarehouse.Helpers
{
    public static class BindingUpdater
    {
        public static void UpdateBinding(this TextBox textBox)
        {
            BindingExpression bindingExpression =
                    textBox.GetBindingExpression(TextBox.TextProperty);
            if (bindingExpression != null)
            {
                bindingExpression.UpdateSource();
            }
        }
    }
}
