namespace Photoroom.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PhotoroomClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PHOTOROOM_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PHOTOROOM_API_KEY environment variable is not found.");

        var client = new PhotoroomClient(apiKey);
        
        return client;
    }
}
