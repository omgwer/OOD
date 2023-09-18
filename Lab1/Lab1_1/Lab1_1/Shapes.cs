namespace Lab1_1
{
    public class Shapes
    {
        private readonly TextReader _textReader;
        private readonly TextWriter _textWriter;
        public bool IsRun { get; private set; }

        public Shapes(TextReader textReader, TextWriter textWriter)
        {
            _textReader = textReader;
            _textWriter = textWriter;
            IsRun = true;
        }
        
        public void HandleInput()
        {
            
        }
        
        private void Close()
        {
            IsRun = false;
        }
    }
}