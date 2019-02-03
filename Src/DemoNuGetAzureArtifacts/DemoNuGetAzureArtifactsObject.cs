using DemoNugetByClydeDSouza;

namespace DemoNuGetAzureArtifacts
{
    public class DemoNuGetAzureArtifactsObject
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int AddExternal(int c, int d)
        {
            return DemoOne.Add(c, d);
        }

        internal static int AddInternal(int e, int f)
        {
            return e + f;
        }
    }
}
