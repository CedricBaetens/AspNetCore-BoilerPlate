using System;
using Application.Interfaces;

namespace Api.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}