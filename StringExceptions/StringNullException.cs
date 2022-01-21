namespace StringExceptions
{
    public class StringNullException : ArgumentNullException
    {
        public StringNullException()
        {
        }

        public StringNullException(string? paramName) : base(paramName)
        {
        }
    }
}