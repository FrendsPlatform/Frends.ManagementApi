namespace Frends.ManagementApi.Request.Definitions;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Input parameters.
/// </summary>
public class Input
{
    /// <summary>
    /// HTTP request method.
    /// </summary>
    /// <example>Methods.GET</example>
    [DefaultValue(Methods.GET)]
    public Methods Method { get; set; }

    /// <summary>
    /// Tenant URL.
    /// </summary>
    /// <example>https://tenant.frendsapp.com/</example>
    public string TenantUrl { get; set; }

    /// <summary>
    /// Versions of Management API.
    /// </summary>
    /// <example>v0.9</example>
    [DisplayFormat(DataFormatString = "Text")]
    [DefaultValue("v0.9")]
    public string ManagementApiVersion { get; set; }

    /// <summary>
    /// Path.
    /// </summary>
    /// <example>api-management/access/api-keys/{id}</example>
    public string Path { get; set; }

    /// <summary>
    /// Bearer token.
    /// </summary>
    /// <example>abcd123</example>
    [DisplayFormat(DataFormatString = "Text")]
    [PasswordPropertyText]
    public string Token { get; set; }
}