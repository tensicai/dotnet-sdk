namespace TensicAI.Sdk;

/// <summary>
/// A configured client for the Tensic API.
/// </summary>
/// <remarks>
/// Early preview. The public surface is expected to change before 0.1.0,
/// and no HTTP transport is wired up yet.
/// </remarks>
public sealed class TensicClient
{
    private readonly string _apiKey;

    /// <summary>
    /// Creates a client for the given Tensic endpoint and API key.
    /// </summary>
    /// <param name="baseUrl">Base address of the Tensic API, for example <c>https://manager.tensic.ai</c>.</param>
    /// <param name="apiKey">API key used to authenticate requests.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="baseUrl"/> is null, empty or not an absolute URI.</exception>
    public TensicClient(string baseUrl, string apiKey)
    {
        if (string.IsNullOrWhiteSpace(baseUrl))
        {
            throw new ArgumentException("Base URL must be provided.", nameof(baseUrl));
        }

        if (!Uri.TryCreate(baseUrl, UriKind.Absolute, out var parsed))
        {
            throw new ArgumentException($"Base URL '{baseUrl}' is not an absolute URI.", nameof(baseUrl));
        }

        BaseUrl = parsed;
        _apiKey = apiKey ?? string.Empty;
    }

    /// <summary>
    /// The endpoint this client targets.
    /// </summary>
    public Uri BaseUrl { get; }

    /// <summary>
    /// Whether an API key was supplied.
    /// </summary>
    public bool HasCredentials => !string.IsNullOrWhiteSpace(_apiKey);
}
