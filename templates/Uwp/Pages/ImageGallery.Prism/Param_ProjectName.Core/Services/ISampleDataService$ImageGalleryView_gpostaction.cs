﻿//{**
// This code block adds the method `GetChartSampleData()` to the SampleDataService of your project.
//**}
    public interface ISampleDataService
    {
//^^
//{[{

        void Initialize(string localResourcesPath);

        Task<ObservableCollection<SampleImage>> GetGallerySampleDataAsync();
//}]}
    }
}