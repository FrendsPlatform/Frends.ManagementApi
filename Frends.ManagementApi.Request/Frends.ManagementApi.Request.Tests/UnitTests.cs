namespace Frends.ManagementApi.Request.Tests;

using Frends.ManagementApi.Request.Definitions;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

[TestFixture]
internal class UnitTests
{
    /// <summary>
    /// These cannot be tested in Github. Set your own tenant and token and test locally.
    /// </summary>
    private readonly string tenantUrl = "https://tenant.frendsapp.com/";
    private readonly string token = "token";
    private Input input = new ();
    private Options options = new ();

    [SetUp]
    public void SetUp()
    {
        this.input = new Input
        {
            TenantUrl = this.tenantUrl,
            Token = this.token,
            ManagementApiVersion = "v0.9",
            Path = @"environment-variables",
            Method = Methods.GET,
        };

        this.options = new Options
        {
            ThrowExceptionOnError = true,
        };
    }

    [Ignore("Cannot be tested in Github")]
    [Test]
    public async Task Test_Get()
    {
        var ret = await ManagementApi.Request(this.input, this.options, default);
        Assert.That(ret.Success is true);
        Assert.That(ret.ErrorMessage is null);
        Assert.That(ret.Data != null);
    }

    [Ignore("Cannot be tested in Github")]
    [Test]
    public void Test_Invalid_Token_Throw()
    {
        this.input.Token = "foo";
        Assert.ThrowsAsync<Exception>(async () => await ManagementApi.Request(this.input, this.options, default));
    }

    [Ignore("Cannot be tested in Github")]
    [Test]
    public async Task Test_Invalid_Token_Return()
    {
        this.input.Token = "foo";
        this.options.ThrowExceptionOnError = false;
        var ret = await ManagementApi.Request(this.input, this.options, default);
        Assert.That(ret.Success is false);
        Assert.That(ret.Data is null);
        Assert.That(ret.ErrorMessage != null);
    }
}