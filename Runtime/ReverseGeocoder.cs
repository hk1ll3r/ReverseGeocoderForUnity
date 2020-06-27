using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wibci.CountryReverseGeocode;
using Wibci.CountryReverseGeocode.Data;
using Wibci.CountryReverseGeocode.Models;

public class ReverseGeocoder : MonoBehaviour
{
    [SerializeField] TextAsset _statesJson;
    [SerializeField] TextAsset _countriesJson;

    private CountryReverseGeocodeService _geocoderService;

    private void Awake()
    {
        var statesDataProvider = new JsonDataProvider(_statesJson.text);
        var countriesDataProvider = new JsonDataProvider(_countriesJson.text);
        _geocoderService = new CountryReverseGeocodeService(countriesDataProvider, statesDataProvider);
    }

    public string ReverseGeocodeCountry(float lon, float lat)
    {
        if (_geocoderService == null) return null;
        return _geocoderService.FindCountry(new GeoLocation() { Longitude = lon, Latitude = lat })?.Name;
    }

    public string ReverseGeocodeUSAState(float lon, float lat)
    {
        if (_geocoderService == null) return null;
        return _geocoderService.FindUSAState(new GeoLocation() { Longitude = lon, Latitude = lat })?.Name;
    }
}
