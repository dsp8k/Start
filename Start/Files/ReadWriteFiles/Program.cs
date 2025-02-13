// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {
    File.WriteAllText(filename, "This is application programming. ");
}

// TODO 3: AppendAllText adds text to an existing file
File.AppendAllText(filename, "300lvl second semester. ");

// TODO 4: A FileStream can be opened and written to until closed
using (StreamWriter sw = File.AppendText(filename)) {
    sw.WriteLine("princewill");
    sw.WriteLine("Dike");
    sw.WriteLine("7682");
}
// TODO 2: ReadAllText reads all the content from a file
string content;
content = File.ReadAllText(filename);
Console.WriteLine(content);


