using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion
{
    internal class ValidacionesUI
    {

        public Boolean evalCamposVacios(TextBox[] textBoxesEvaluar)
        {
            foreach (TextBox textBox in textBoxesEvaluar)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
