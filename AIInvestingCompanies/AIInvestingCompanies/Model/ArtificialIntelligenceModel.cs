namespace AIInvestingCompanies
{
    public class ArtificialIntelligenceModel
    {
        public string Year { get; set; }
        public double Value { get; set; }

        public ArtificialIntelligenceModel(string year, double value)
        {
            Year = year;
            Value = value;
        }
    }
}
