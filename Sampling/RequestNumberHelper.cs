using Bogus;

namespace Sampling;

public static class RequestNumberHelper
{
    public static string RandomPassword() => new Faker().Random.AlphaNumeric(11).ToUpper();
}