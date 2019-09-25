using System.Collections;
using System.Collections.Generic;


public class Question{

    private string quest;
    private string[] firstOptions;
    private string[] secondOptions;
    private int[] realAnswer;

    public Question(string quest, string[] firstOptions, string[] secondOptions, int[] realAnswer){
        this.quest = quest;
        this.firstOptions = firstOptions;
        this.secondOptions = secondOptions;
        this.realAnswer = realAnswer;
    }

    public string GetQuest()
    {
        return this.quest;
    }

    public void SetQuest(string quest)
    {
        this.quest = quest;
    }

    public string[] GetFirstOptions()
    {
        return this.firstOptions;
    }

    public void SetFirstOptions(string[] firstOptions)
    {
        this.firstOptions = firstOptions;
    }

    public string[] GetSecondOptions()
    {
        return this.secondOptions;
    }

    public void SetSecondOptions(string[] secondOptions)
    {
        this.secondOptions = secondOptions;
    }

    public int[] GetRealAnswer()
    {
        return this.realAnswer;
    }

    public void SetRealAnswer(int[] realAnswer)
    {
        this.realAnswer = realAnswer;
    }


    
    
}
