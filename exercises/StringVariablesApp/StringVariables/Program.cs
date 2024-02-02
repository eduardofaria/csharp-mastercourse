


string firstName = string.Empty;
string lastName = string.Empty;

firstName = "Eduardo";
lastName = "Faria";
string filePath = @"C:\Documents\Visual Studio 2022\Projects\";

//Console.WriteLine(firstName + " " + lastName);
//Console.WriteLine($"{firstName} {lastName}");

//Console.WriteLine("{0} {1}, file folder: {2}", firstName, lastName, filePath);

Console.WriteLine($@"Olá {firstName}, seu arquivos estão em C:\users\{firstName}{lastName}\");