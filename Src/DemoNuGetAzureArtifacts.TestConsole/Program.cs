using System;

namespace DemoNuGetAzureArtifacts.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DemoNuGetAzureArtifactsObject.Add(5, 6));
            Console.WriteLine(DemoNuGetAzureArtifactsObject.AddExternal(7, 3));
            Console.WriteLine("** END **");
            Console.Read();
        }
    }
}
