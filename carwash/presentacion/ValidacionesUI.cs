using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using negocios;

namespace presentacion
{
    internal class ValidacionesUI
    {
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        public Boolean EvalTxtVacios(TextBox[] textBoxesEvaluar)
        {
            foreach (TextBox txt in textBoxesEvaluar)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    return true;
                }
            }//fin foreach
            return false;
        }

        //Parámetro límite: La máxima cantidad de caracteres que puede tener un campo
        public Boolean EvalTxtChars(TextBox[] textBoxesEvaluar, int limite) {

            foreach (TextBox txt in textBoxesEvaluar) {

                if (txt.Text.Length > limite) {

                    return true;

                }

            }// fin foreach
            return false;
        
        }

        public Boolean EvalCodigoPostal(string codigoPostal) {

            if (codigoPostal.Length != 5)
            {

                return true;

            }
            else {

                return false;

            }
        
        }

        public Boolean EvalTxtCharsEspecial(TextBox[] textBoxes) {

            foreach (TextBox textBox in textBoxes) {

                //El segundo parámetro es una expresión regular que considera todos los caracteres que no sean letras
                if (Regex.IsMatch(textBox.Text, @"[^a-zA-ZáéíóúüñÁÉÍÓÚÜÑ\s]"))
                {

                    return true;

                }

            }
            return false;
        
        }

        public Boolean EvalNumEmpleado(int numEmpleado) {

            DataTable numsEmpleado = logicaNegocios.GetNumsEmpleado();
            foreach (DataRow numActual in numsEmpleado.Rows) {

                if ((int)numActual["numEmpleado"] == numEmpleado) {

                    return true;
                
                }

            }// fin foreach
            return false;
        
        }

        public Boolean EvalMayorEdad(DateTime fechaNacimiento) {

            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            //Valida si el empleado ya cumplió años durante el año actual
            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            if (edad < 18)
            {

                return true;

            }
            else {

                return false;

            }

        }

    }
}
