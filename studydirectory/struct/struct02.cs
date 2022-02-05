using System;
using System.Collections.Generic;

class MainClass {
  struct Language{
    public string name;
    public string fileExtension;
    public string lastVersion;
    public bool objectOriented;

    public Language(string name, string fileExtension, string lastVersion, bool objectOriented){
      this.name = name;
      this.fileExtension = fileExtension;
      this.lastVersion = lastVersion;
      this.objectOriented = objectOriented;
    }

    public void ShowInformation(){
      Console.Write($"- - - - - - - - - - -\n{this.name}\n{this.fileExtension}\n{this.lastVersion}");
      if(this.objectOriented){
        Console.WriteLine("Object Oriented");
      }else{
        Console.WriteLine("");
      }
    }
  }

  public static void Main (string[] args) {
    List<Language> MyLanguageList = new List<Language>();
    MyLanguageList.Add(new Language("C#",".cs", "10.0", true));
    MyLanguageList.Add(new Language("Python",".py", "3.10.0", true));
    MyLanguageList.Add(new Language("C",".py", "C17", false));
    foreach(Language MyLanguage in MyLanguageList){
      MyLanguage.ShowInformation();
    }
  }
}
