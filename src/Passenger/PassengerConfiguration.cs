﻿using System;
using Passenger.Drivers;

namespace Passenger
{
    public class PassengerConfiguration
    {
        public DriverBindings Driver { get; set; }
        public string WebRoot { get; set; }

        public PageObject<TPageObjectType> StartTestAt<TPageObjectType>() where TPageObjectType : class
        {
            if (Driver == null)
            {
                throw new ArgumentException("Must configure a driver.");
            }

            return new PageObject<TPageObjectType>(Driver, WebRoot);
        }
    }
}
