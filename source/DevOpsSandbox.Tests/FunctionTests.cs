using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace DevOpsSandbox.Tests;

public class FunctionTests
{
    [Test]
    public async Task CheckFunctionReturnsAnOkObject()
    {
        var context = new DefaultHttpContext();

        var result = await DevOpsTestFunction.Run(context.Request, Substitute.For<ILogger>());

        Assert.That(result, Is.InstanceOf<OkObjectResult>());
    }
}