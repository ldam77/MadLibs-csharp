namespace MadLibs.Models
{
  public class MadLibsVariable
    {
    private string person1;
    private string person2;
    private string animal;
    private string exclaimation;
    private string verb;
    private string noun;

    public string GetPerson1()
    {
      return person1;
    }
    public void SetPerson1(string newPerson1)
    {
      person1 = newPerson1;
    }
    public string GetPerson2()
    {
      return person2;
    }
    public void SetPerson2(string newPerson2)
    {
      person2 = newPerson2;
    }
    public string GetAnimal()
    {
      return animal;
    }
    public void SetAnimal(string newAnimal)
    {
      animal = newAnimal;
    }
    public string GetExclaimation()
    {
      return exclaimation;
    }
    public void SetExclaimation(string newExclaimation)
    {
      exclaimation = newExclaimation;
    }
    public string GetVerb()
    {
      return verb;
    }
    public void SetVerb(string newVerb)
    {
      verb = newVerb;
    }
    public string GetNoun()
    {
      return noun;
    }
    public void SetNoun(string newNoun)
    {
      noun = newNoun;
    }
  }
}
