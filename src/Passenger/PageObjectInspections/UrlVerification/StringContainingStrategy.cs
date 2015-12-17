﻿using Passenger.PageObjectInspections.UrlDiscovery;

namespace Passenger.PageObjectInspections.UrlVerification
{
    public class StringContainingStrategy : IVerifyUrls
    {
        public bool UrlMatches(string url, DiscoveredUrl expectation)
        {
            return url.Contains(expectation.Url.PathAndQuery);
        }
    }
}
