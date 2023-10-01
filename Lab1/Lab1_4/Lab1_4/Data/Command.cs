namespace Lab1_4.Data
{
    public class Command
    {
        public CommandType CommandType { get; }
        public IReadOnlyList<string>? Arguments { get; }

        public Command( string command )
        {
            IReadOnlyList<string> commandArguments = ParseAndValidateCommand( command );
            CommandType = ParseCommandArgument( commandArguments[ 0 ] );
            if ( CommandType is CommandType.List or CommandType.DrawPicture )
            {
                if ( commandArguments.Count > 1 )
                {
                    throw new ArgumentException( $"This command {CommandType.ToString()} has not arguments!" );
                }
            }
            else
            {
                ParseAndValidateCommandWithArguments( commandArguments );
            }
        }

        private void ParseAndValidateCommandWithArguments( IReadOnlyList<string> commandArguments )
        {
            
        }

        private static IReadOnlyList<string> ParseAndValidateCommand( string command )
        {
            IReadOnlyList<string> arguments = command.Split( ' ' );
            if ( arguments.Count == 0 )
            {
                throw new ArgumentException( "The number of arguments cannot be zero" );
            }

            return arguments;
        }

        private static CommandType ParseCommandArgument( string command )
        {
            return command switch
            {
                "AddShape" => CommandType.AddShape,
                "MoveShape" => CommandType.MoveShape,
                "DeleteShape" => CommandType.DeleteShape,
                "MovePicture" => CommandType.MovePicture,
                "List" => CommandType.List,
                "ChangeColor" => CommandType.ChangeColor,
                "ChangeShape" => CommandType.ChangeShape,
                "DrawShape" => CommandType.DrawShape,
                "DrawPicture" => CommandType.DrawPicture,
                "CloneShape" => CommandType.CloneShape,
                _ => throw new ArgumentException( $"{command} is not valid value for command !" )
            };
        }
    }
}