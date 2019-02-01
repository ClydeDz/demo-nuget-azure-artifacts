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
    }
}
