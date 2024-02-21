namespace Frends.ManagementApi.Request.Definitions;

/// <summary>
/// Request header.
/// </summary>
public class Header
{
    /// <summary>
    /// Gets or sets name of header.
    /// </summary>
    /// <example>Authorization.</example>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets value of header.
    /// </summary>
    /// <example>Bearer AccessToken123.</example>
    public string Value { get; set; }
}