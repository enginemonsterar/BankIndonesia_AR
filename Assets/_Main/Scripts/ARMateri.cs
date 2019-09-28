using System.Collections;
using System.Collections.Generic;


public class ARMateri
{
    private string title;
    private string description;

    public ARMateri(string title, string description){
        this.title = title;
        this.description = description;
    }

    public string GetTitle(){
        return this.title;
    }

    public string GetDescription(){
        return this.description;
    }
}
