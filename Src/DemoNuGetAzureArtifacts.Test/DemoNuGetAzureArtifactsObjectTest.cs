using Xunit;

namespace DemoNuGetAzureArtifacts.Test
{
    public class DemoNuGetAzureArtifactsObjectTest
    {
        [Fact]
        public void Add_Test()
        {
            int result = DemoNuGetAzureArtifactsObject.Add(5, 2);
            Assert.Equal(7, result);
        }

        [Fact]
        public void AddExternal_Test()
        {
            int result = DemoNuGetAzureArtifactsObject.AddExternal(12, 5);
            Assert.Equal(17, result);
        }
    }
}
