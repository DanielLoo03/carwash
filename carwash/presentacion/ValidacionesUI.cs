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

                if (!decimal.TryParse(valores[i], out _))
                {

                    //No pudo realizar un parse de string a decimal correctamente (algún valor no se traduce a un decimal)
                    return true;

                }
            
            }
            //Pasó todas las pruebas (nunca marcó "error")
            return false;

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

        public Boolean EvalCamposObligatoriosVenta(decimal precio, decimal gan, decimal corresp, string nomCompleto, int numEmp)
        {
            // Verificar que los valores numéricos sean mayores que cero y campos de texto no estén vacíos
            // Se escribe una m después del valor 0.00 para indicar que es un tipo decimal, no float ni double. 
            if (precio <= 0.00m ||
                gan <= 0.00m ||
                corresp <= 0.00m ||
                string.IsNullOrWhiteSpace(nomCompleto) ||
                numEmp <= 0)
            {
                return true; // Algún campo obligatorio no cumple
            }
            return false; // Todos los campos obligatorios están presentes y válidos
        }


        public Boolean EvalMontos(decimal monto)
        {

            if (monto <= 0) {

                return true;

            }
            return false;

        }

        //Evalua si algun campo esta vacio
        // campos = Arreglo de objetos (TextBox, Combobx, otros)
        public bool EvalCamposVacios(object[] campos)
        {
            foreach (var campo in campos)
            {
                if (campo == null) return true;

                string valor = null;

                if (campo is TextBox txt)
                    valor = txt.Text;
                else if (campo is ComboBox cbx)
                    valor = cbx.Text;
                else
                    valor = campo.ToString();

                if (string.IsNullOrWhiteSpace(valor))
                    return true; // Campo vacío o solo espacios
            }

            return false; // Todos los campos están llenos
        }

        // Evalua si algun campo supera el limite de caracteres
        // campos = Arreglo de objetos (TextBox, Combobx, otros)
        // limite = cantidad maxima de caracteres permitidos
        public bool EvalCampoLimite(object[] campos, int limite)
        {
            foreach (var campo in campos)
            {
                if (campo == null) continue;

                string valor = null;

                if (campo is TextBox txt)
                    valor = txt.Text;
                else if (campo is ComboBox cbx)
                    valor = cbx.Text;
                else
                    valor = campo.ToString();

                if (valor.Length > limite)
                    return true; // Supera el límite
            }

            return false; // Todos los campos están dentro del límite
        }

        // Evalua si alguno de los campos tiene caracteres especiales no permitidos
        // campos = Arreglo de objetos (TextBox, Combobx, otros)
        // regexNopermitidos = Rregex con caracteres no permitidos
        public bool EvalCamposCharEsp(object[] campos, string regexNoPermitidos)
        {
            Regex regex = new Regex(regexNoPermitidos);

            foreach (var campo in campos)
            {
                string valor = null;

                if (campo == null) continue;

                if (campo is TextBox txt)
                    valor = txt.Text;
                else if (campo is ComboBox cbx)
                    valor = cbx.Text;
                else
                    valor = campo.ToString();

                if (regex.IsMatch(valor))
                    return true;
            }

            return false;
        }
    }
}
