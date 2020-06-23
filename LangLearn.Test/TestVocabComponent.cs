using Bunit;
using LangLearn.Pages;
using Xunit;

namespace LangLearn.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Vocab_Component_Renders() {
            using var ctx = new TestContext();
            var sut = ctx.RenderComponent<Index>();
            var expectedMarkup = "<h1>Welcome to LangLearn!</h1>";
            sut.MarkupMatches(expectedMarkup);
        }
    }
}
