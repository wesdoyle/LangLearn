using Bunit;
using LangLearn.Pages;
using Xunit;

namespace LangLearn.Test
{
    public class TestVocabComponent 
    {
        [Fact]
        public void Test_Index_Component_Renders() {
            using var ctx = new TestContext();
            var sut = ctx.RenderComponent<Index>();
            var expectedMarkup = "<h1>Welcome to LangLearn!</h1>";
            sut.MarkupMatches(expectedMarkup);
        }
    }
}
