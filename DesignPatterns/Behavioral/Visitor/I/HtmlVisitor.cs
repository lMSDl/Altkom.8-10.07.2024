namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Visitor.I
{
    internal class HtmlVisitor : IVisitor
    {
        public string Visit(PlainText element)
        {
            return element.Text;
        }

        public string Visit(Hyperlink element)
        {
            return $"<a href={element.Link}>{element.Text}</a>";
        }

        public string Visit(BoldText element)
        {
            return $"<b>{element.Text}</b>";
        }
    }
}
