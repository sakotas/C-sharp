using static System.Console;

string path = "G:/GEEK/C#/лекция1/Lecture1";
DirectoryInfo di = new DirectoryInfo(path);

WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    WriteLine(fi[i].Name);
}
WriteLine("rekurs search started");
CatalogInfo(path);


void CatalogInfo(string path, string ident = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for(int i=0; i< catalogs.Length; i++)
    {
        WriteLine($"{ident}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, ident + " ");
    }

    FileInfo[] files = catalog.GetFiles();
    for(int i=0; i< files.Length; i++)
    {
        WriteLine($"{ident}{files[i].Name}");
    }

}