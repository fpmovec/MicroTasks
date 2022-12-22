
using Composite_Iterator_Visitor.Composite;
using Directory = Composite_Iterator_Visitor.Composite.Directory;
using File = Composite_Iterator_Visitor.Composite.File;
try
{
    Component fileSystem = new Directory("File System");

    Component diskD = new Directory("D://");

    Component secretFolder = new Directory("Secret Folder");
    Component passwordsTxt = new File("passwords.txt");
    secretFolder.Add(passwordsTxt);
    diskD.Add(secretFolder);

    Component photosFolder = new Directory("Folder with files");
    Component iPhotoPng = new File("AntonSemenchenko.png");
    Component youPhotoPng = new File("patterns.png");
    photosFolder.Add(iPhotoPng);
    photosFolder.Add(youPhotoPng);
    diskD.Add(photosFolder);

    fileSystem.Add(diskD);
    fileSystem.PrintNodes();
    youPhotoPng.Add(iPhotoPng);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("Cannot add node in file!");
}