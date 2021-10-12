﻿using rest_api_udemy.Hypermedia;
using rest_api_udemy.Hypermedia.Abstract;
using System.Collections.Generic;

namespace rest_api_udemy.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
