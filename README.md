# .NET Framework ToolKit Exploration

This repo was inspired during a recent interview experience of mine. While I have several years of professional .NET coding experience, I was both rusty during the interview, and have not always been exposed to some of the built in, pretty excellent tools that make the .NET Framework useful.

This repo is a collection of console applications meant to be read deeply, followed by run, so that you can see the tools in action. Each console app contains a collection of tools entirely built and supported by the .NET framework. The hope for anyone reading this is that you will take a look and realize how many outstanding tools are available within .NET just fully out of the box.

For the sake of expedience in creating this repo, as well as in not cluttering up with needless documentation, the majority of documentation will be present within each console application in the form of contents.

## LINQ

[Official docs on learn.microsoft.com](https://learn.microsoft.com/en-us/dotnet/csharp/linq/)

LINQ is Microsoft's in-line query engine. It allows you to use dot-notation to run pre-built queries on collections. These queries save you a ton of work if you understand how they work and how to use them. Some queries will use lambda functions in order to perform comparison operations and similar, allowing you to query, select, filter, or arrange the items in a collection without having to run that operation yourself.

[LINQ Project](/src/LINQ/LINQ.cs)