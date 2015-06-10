﻿namespace Passenger
{
    public class Redirects
    {
        public static TPageObjectType To<TPageObjectType>()
            where TPageObjectType : class, new()
        {
            return new TPageObjectType();
        }

        public static PageObject<TPageObjectType> ToPageObject<TPageObjectType>()
            where TPageObjectType : class
        {
            return new PageObject<TPageObjectType>();
        }
    }
}