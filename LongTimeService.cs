﻿namespace HelloApp
{
    public class LongTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToLongTimeString();
    }
}
