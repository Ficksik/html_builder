using System.Text;

namespace HtmlBuilder;

public class HtmlBaseElement : IHtmlElement
{
    public string? Text;
    public string? Class;
    public string? Href;
    public string? Style;
    private string ClosingTag { get; set; }
    private string OpeningTag { get; set; }
    
    protected List<IHtmlElement> Elements;
    public HtmlBaseElement(string openingTag, string closingTag)
    {
        OpeningTag = openingTag;
        ClosingTag = closingTag;
        Elements = new List<IHtmlElement>();
    }
    public void Add(IHtmlElement element)
    {
        Elements.Add(element);
    }
    public override string ToString()
    {
        var strBuilder = new StringBuilder(); 
        if(!string.IsNullOrEmpty(OpeningTag))
        {
            OpeningTagInsert("href",Href);
            OpeningTagInsert("class",Class);
            OpeningTagInsert("style",Style);
       
            strBuilder.AppendLine(OpeningTag);
        }

        if (!string.IsNullOrEmpty(Text))
        {
            strBuilder.AppendLine(Text);
        }
        
        foreach (var element in Elements)
        {
            strBuilder.AppendLine(element.ToString());
        }
        
        if(!string.IsNullOrEmpty(ClosingTag)) 
            strBuilder.AppendLine(ClosingTag);
        
        return strBuilder.ToString();
    }
    
    private void OpeningTagInsert(string tag, string? value)
    {
        OpeningTag = OpeningTag.Insert(OpeningTag.Length - 1, $" {tag}=\"{value}\"");
    }
    
}