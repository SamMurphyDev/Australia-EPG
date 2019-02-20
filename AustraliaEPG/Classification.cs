namespace AustraliaEPG
{
    /// <summary>
    /// Australian TV Classifications
    /// </summary>
    public enum Classification
    {
        G,
        PG,
        M,
        MA,
        R,
        X,
        OTHER
    }


    /// <summary>
    /// A string to ENUM selector as the API Endpoint may return NULL which throws a Exception
    /// </summary>
    public static class ClassificationSelector
    {
        public static Classification Selector(string value)
        {
            if (value == null)
                return Classification.OTHER;

            switch (value.ToUpper())
            {
                case "G":
                    return Classification.G;
                case "PG":
                    return Classification.PG;
                case "M":
                    return Classification.M;
                case "MA":
                    return Classification.MA;
                case "R":
                    return Classification.R;
                case "X":
                    return Classification.X;
                default:
                    return Classification.OTHER;
            }
        }
    }
}
