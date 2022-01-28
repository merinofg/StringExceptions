namespace StringExceptions
{
    /// <summary>
    /// Represent a string checker against common undesired values
    /// as <c>null</c>, <c>empty strings</c>, or <c>whitespaces strings</c>.
    /// </summary>
    public static class StringExceptionsChecker
    {
        private const string _empty = "";

        /// <summary>
        /// Throws <see cref="StringNullException"/>, <see cref="StringNullException"/> or
        /// <see cref="StringNullException"/> when the argument match one of the exceptions criteria.
        /// </summary>
        /// <param name="s">The reference string to validate.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="s"/> corresponds. Can be omitted.</param>
        /// <exception cref="StringNullException"><paramref name="s"/> is <c>null</c>.</exception>
        /// <exception cref="StringEmptyException"><paramref name="s"/> is an empty string.</exception>
        /// <exception cref="StringWhiteSpaceException"><paramref name="s"/> is only whitespaces.</exception>
        public static void ThrowIfFails(string? s, string? paramName = default)
        {
            switch (s)
            {
                case null when paramName == null:
                   throw new StringNullException();
                case null:
                    throw new StringNullException(paramName);

                case _empty when paramName == null:
                    throw new StringEmptyException();
                case _empty:
                    throw new StringEmptyException(paramName);
            }

            bool isWhiteSpace = s.All(char.IsWhiteSpace);
            switch (isWhiteSpace)
            {
                case true when paramName == null:
                    throw new StringWhiteSpaceException();
                case true:
                    throw new StringWhiteSpaceException(paramName);
            }
        }
    }
}