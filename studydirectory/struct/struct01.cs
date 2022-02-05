using System;
using System.Collections.Generic;

class MainClass {
  struct Movie{
    public string title;
    public string director;
    public int releaseyear;
    public double budget;

    public Movie(string title, string director, int releaseyear, double budget){  //constructor
      this.title = title;
      this.director = director;
      this.releaseyear = releaseyear;
      this.budget = budget;
    }
    public void ShowInformation(){
      Console.WriteLine($"==================\nTitle: {this.title}\nDirector: {this.director}\nRelease Year: {this.releaseyear}\nBudget: {this.budget}\n==================");
    }
  }

  public static void Main (string[] args) {
    List<Movie> MyMovieList = new List<Movie>();
    MyMovieList.Add(new Movie("Movie A","A-Director", 2000, 1234.1234));
    MyMovieList.Add(new Movie("Movie B","B-Director", 2001, 1234.1234));
    MyMovieList.Add(new Movie("Movie C","C-Director", 2002, 1234.1234));
    MyMovieList.Add(new Movie("Movie D","D-Director", 2003, 1234.1234));
    MyMovieList.Add(new Movie("Movie E","E-Director", 2004, 1234.1234));
    foreach(Movie MyMovie in MyMovieList){
      MyMovie.ShowInformation();
    }
  }
}
