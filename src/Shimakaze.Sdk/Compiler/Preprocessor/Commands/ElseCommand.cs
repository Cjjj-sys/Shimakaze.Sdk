using Microsoft.Extensions.Logging;

using Shimakaze.Sdk.Compiler.Preprocessor.Kernel;

namespace Shimakaze.Sdk.Compiler.Preprocessor.Commands;

/// <summary>
/// #else
/// </summary>
[PreprocessorCommand("else")]
public sealed class ElseCommand : PreprocessorCommand
{
    private readonly ILogger<ElseCommand> _logger;
    private readonly IConditionParser _conditionParser;
    /// <inheritdoc/>
    public ElseCommand(IPreprocessorVariables preprocessor, ILogger<ElseCommand> logger, IConditionParser conditionParser) : base(preprocessor)
    {
        _logger = logger;
        _conditionParser = conditionParser;
    }

    /// <inheritdoc/>
    public override Task ExecuteAsync(string[] args, CancellationToken cancellationToken)
    {
        var conditionStack = variable.ConditionStack;

        var lastStatus = conditionStack.Peek();

        lastStatus.Tag = "else";
        variable.WriteOutput = false;

        if (!lastStatus.IsMatched)
        {
            lastStatus.IsMatched = variable.WriteOutput = true;
        }

        return Task.CompletedTask;
    }
}
