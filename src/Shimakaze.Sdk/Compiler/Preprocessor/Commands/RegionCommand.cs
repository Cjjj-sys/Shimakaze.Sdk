using Microsoft.Extensions.Logging;

using Shimakaze.Sdk.Compiler.Preprocessor.Kernel;

namespace Shimakaze.Sdk.Compiler.Preprocessor.Commands;

/// <summary>
/// #region _________
/// </summary>
[PreprocessorCommand("region")]
public sealed class RegionCommand : PreprocessorCommand
{
    private readonly ILogger<RegionCommand> _logger;
    /// <inheritdoc/>
    public RegionCommand(IPreprocessorVariables variable, ILogger<RegionCommand> logger) : base(variable)
    {
        _logger = logger;
    }
    /// <inheritdoc/>

    public override Task ExecuteAsync(string[] args, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
