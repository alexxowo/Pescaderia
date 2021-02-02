using System;

namespace Pescaderia.Internal
{
    public static class directories
    {
        // Carpeta Raiz de los datos
        public static string PrincipalAppData {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Pescaderia Lolymar"; }
        }

        public static string productsFolder
        {
            get { return PrincipalAppData + @"\database\productos"; }
        }

        public static string comprasFolder
        {
            get { return PrincipalAppData + @"\database\compras\"; }
        }

        public static string productsFile
        {
            get { return PrincipalAppData + @"\database\productos\productos.json"; }
        }

        public static string comprasFile
        {
            get { return PrincipalAppData + @"\database\compras\compras.json"; }
        }
    }
}
