namespace HtmlBuilder;

public class THeadElement : HtmlBaseElement
{
    public THeadElement(params string[] heads) : base("<thead>", "</thead>" )
    {
        var tr = new TrElement();
        foreach (var head in heads)
        {
            tr.Add(new ThElement()
            {
                Text = head
            }); 
        }
        this.Add(tr);
    }
}