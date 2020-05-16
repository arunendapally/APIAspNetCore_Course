using CityInfo.API.Models;
using System.Collections.Generic;

namespace CityInfo.API.Controllers
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Hyderabad",
                    Description = "My city",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Charminar",
                            Description = "It is an old monument"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Buddha Satute",
                            Description = "Satute in center of the hussain sagar"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Delhi",
                    Description = "Capital of India",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Red fort",
                            Description = "Historic fort"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Qutub Minar",
                            Description = "Victory tower"
                        }
                    }
                }
            };
        }
    }
}