using System.Collections.ObjectModel;

namespace AIInvestingCompanies
{
    public class ArtificialIntelligenceData
    {
        public List<ArtificialIntelligenceModel> Data { get; set; }
        public ObservableCollection<Brush> CustomBrushes {  get; set; }

        public ArtificialIntelligenceData()
        {
            Data = new List<ArtificialIntelligenceModel>()
             {
                new ArtificialIntelligenceModel("2022",189.59),
                new ArtificialIntelligenceModel("2021",276.14),
                new ArtificialIntelligenceModel("2020",146.74),
                new ArtificialIntelligenceModel("2019",95.57),
                new ArtificialIntelligenceModel("2018",79.62),
                new ArtificialIntelligenceModel("2017",53.72),
                new ArtificialIntelligenceModel("2016",33.83),
                new ArtificialIntelligenceModel("2015",25.43),
                new ArtificialIntelligenceModel("2014",19.04),
                new ArtificialIntelligenceModel("2013",14.57),
            };

            CustomBrushes = new ObservableCollection<Brush>();
            foreach (var item in Data)
            {
                if (item.Value < 50)
                {
                    // Add the brush for values less than 50
                    CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#0DAA97")));
                }
                else if (item.Value > 50 && item.Value < 100)
                {
                    // Add a different brush for values between 50 to 100
                    CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#9455FC")));
                }
                else
                {
                    // Add the default brush for greater than 100
                    CustomBrushes.Add(new SolidColorBrush(Color.FromArgb("#EA8D03")));
                }
            }
        }
    }
}
