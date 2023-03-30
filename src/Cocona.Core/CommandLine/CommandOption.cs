using Cocona.Command;
using System.Diagnostics;

namespace Cocona.CommandLine
{
    [DebuggerDisplay("CommandOption: {Option.Name,nq}; Value={Value,nq}")]
    public readonly struct CommandOption
    {
        public ICommandOptionDescriptor Option { get; }

        public string? Value { get; }

        public int Position { get; }

        public CommandOption(ICommandOptionDescriptor option, string? value, int position)
        {
            Option = option ?? throw new ArgumentNullException(nameof(option));
            Value = value;
            Position = position;
        }

        public override string ToString()
        {
            return $"CommandOption: {Option.Name}; Value={Value}";
        }
    }
}
