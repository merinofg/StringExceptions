# StringExceptions
Simplifies the string checks for common cases as **null**,
**empty** or **whitespaces**, throwing custom exceptions on
those cases.

Inspired on the recent new way in .NET 6 of checking argument null exceptions,
this will check for null, empty string and white spaces string
and throw it corresponding exception.

## Installation

Via [NuGet](https://www.nuget.org/packages/StringExceptions/)

```shell
Install-Package StringExceptions -Version 1.1.0
```

## Usage

```c#
using StringExceptions;

StringExceptionsChecker.ThrowIfFails(myString);
// or
StringExceptionsChecker.ThrowIfFails(myString, nameof(myString));
```

## Exceptions

Three exception classes are declared:

- **StringEmptyException**: Throws when string is empty.
- **StringNullException**: Throws when string is null. (Inherited from _ArgumentNullException_).
- **StringWhiteSpaceException**: Throws when string is ony formed by whitespaces.
