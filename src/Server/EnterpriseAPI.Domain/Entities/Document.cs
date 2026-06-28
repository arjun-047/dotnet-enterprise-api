namespace EnterpriseAPI.Domain.Entities;
using EnterpriseAPI.Domain.Common;

public class Document : BaseEntity{
    public string Title {get; set;}
    public string Content {get; set;}
    public Guid AuthorId {get; set;}
    public bool IsPublished {get; private set;}

    public void Publish(){
        if(string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Content)){
            throw new InvalidOperationException("Cannot publish a document without a title and content.");
        }
        else
            IsPublished = true;
    }

}

