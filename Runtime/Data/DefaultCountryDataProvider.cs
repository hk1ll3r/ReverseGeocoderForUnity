using System.Collections.Generic;
using Wibci.CountryReverseGeocode.Models;

namespace Wibci.CountryReverseGeocode.Data
{
    public class DefaultCountryDataProvider : IReverseGeocodeDataProvider
    {
        List<AreaData> _data = new List<AreaData>();

        public List<AreaData> Data
        {
            get
            {
                return _data;
            }
        }
    }
}
