namespace ACM.Common
{
    public static class ManejadorDeString
    {
        //public static string InsertarEspacios(string source) {
        //Extension Methods
        public static string InsertarEspacios(this string source) {
            string result = string.Empty;
            if (!string.IsNullOrWhiteSpace(source)) {
                foreach (char letter in source) {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
