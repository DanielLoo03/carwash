using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace presentacion
{
    public static class Fuentes
    {
        private static PrivateFontCollection privateFonts = new PrivateFontCollection();

        static Fuentes()
        {
            cargarFuentes();
        }

        private static void cargarFuentes()
        {
            // Cargar familia de fuentes Inter
            byte[] datosFuenteInterFamily = Properties.Resources.Inter;
            IntPtr punteroFuenteInterFamily = Marshal.AllocCoTaskMem(datosFuenteInterFamily.Length);
            Marshal.Copy(datosFuenteInterFamily, 0, punteroFuenteInterFamily, datosFuenteInterFamily.Length);
            privateFonts.AddMemoryFont(punteroFuenteInterFamily, datosFuenteInterFamily.Length);
            Marshal.FreeCoTaskMem(punteroFuenteInterFamily);

            // Cargar fuente Nacelle-Regular
            byte[] datosFuenteNacelleRegular = Properties.Resources.Nacelle_Regular;
            IntPtr punteroFuenteNacelleRegular = Marshal.AllocCoTaskMem(datosFuenteNacelleRegular.Length);
            Marshal.Copy(datosFuenteNacelleRegular, 0, punteroFuenteNacelleRegular, datosFuenteNacelleRegular.Length);
            privateFonts.AddMemoryFont(punteroFuenteNacelleRegular, datosFuenteNacelleRegular.Length);
            Marshal.FreeCoTaskMem(punteroFuenteNacelleRegular);
        }

        public static Font obtenerFuente(float tamano, FontStyle estilo)
        {
            FontFamily fuente = null;

            // Buscar la fuente según el estilo
            foreach (FontFamily familia in privateFonts.Families)
            {
                if (estilo == FontStyle.Regular && familia.Name.Contains("Nacelle"))
                {
                    fuente = familia;
                    break;
                }
                else if (estilo == FontStyle.Bold && familia.Name.Contains("Inter"))
                {
                    fuente = familia;
                    break;
                }
            }

            // Si no se encuentra la fuente adecuada, usar la primera disponible
            if (fuente == null)
            {
                fuente = privateFonts.Families[0];  
            }

            return new Font(fuente, tamano, estilo);
        }
    }
}