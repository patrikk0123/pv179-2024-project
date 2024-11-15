using System.Globalization;

namespace Infrastructure.Helpers;

public static class IdGenerator
{
    public static string GenerateUniqueId()
    {
        // Get the current timestamp as a string in a culture-invariant format
        string timestamp = DateTime.UtcNow.ToString(
            "yyyyMMddHHmmssfff",
            CultureInfo.InvariantCulture
        );

        // Generate a random number and format it as a 4-digit string in a culture-invariant way
        var random = new Random();
        string randomPart = random.Next(1000, 9999).ToString("D4", CultureInfo.InvariantCulture); // Ensures 4 digits

        // Combine the timestamp and random part
        return timestamp + randomPart;
    }
}
