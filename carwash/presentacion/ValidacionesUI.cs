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

        public Boolean EvalSoloNums(string[] valores)
        {
            for (int i = 0; i < valores.Length; i++) {

                if (!float.TryParse(valores[i], out _))
                {

                    //No pudo realizar un parse de string a float correctamente (algún valor no se traduce a un float)
                    return false;

                }
            
            }
            //Pasó todas las pruebas (nunca marcó "error")
            return true;

        }

        public Boolean EvalCharsColor(string colorCarro)
        {
            // Solo letras (incluyendo acentos y ñ) y espacios
            return Regex.IsMatch(colorCarro, "[^a-zA-ZáéíóúüñÁÉÍÓÚÜÑ\\s]");
        }

        // Valida que porcentaje esté entre 0 y 100
        public Boolean EvalPorDistribucion(int por)
        {
            if (por < 0 || por > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean EvalCamposObligatoriosVenta(float precio, float gan, float corresp, string nomCompleto, int numEmp)
        {
            // Verificar que los valores numéricos sean mayores que cero y campos de texto no estén vacíos
            if (precio <= 0.0f ||
                gan <= 0.0f ||
                corresp <= 0.0f ||
                string.IsNullOrWhiteSpace(nomCompleto) ||
                numEmp <= 0)
            {
                return true; // Algún campo obligatorio no cumple
            }
            return false; // Todos los campos obligatorios están presentes y válidos
        }

        public Boolean EvalMontos(float monto)
        {

            if (monto <= 0) {

                return true;

            }
            return false;

        }

    }
}
