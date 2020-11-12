using System;

class Faculty : Person {
  public string ID{get; set;}
  public string Title{get; set;} 
  public string Employer{get; set;}
  public DateTime DateOfEmployment{get; set;}
  public double YearlySalary{get; set;}
  public bool Tenured{get; set;}
  public Faculty() : base() {
    this.Title = "Instructor";
  }
  public Faculty(string fname, string lname) : base(fname, lname) {
    this.Title = "Instructor";
  }
  public bool GrantTenure() 
  {
    DateTime zeroTime = new DateTime(1, 1, 1);
    TimeSpan span = DateTime.Now - DateOfEmployment;
    int years = (zeroTime + span).Year - 1;
    Console.WriteLine(years);
    if (years >= 5) {
      Tenured = true;
      return(true);
    }
    else {
      Tenured = false;
      return(false);
    }
  }
  public bool Promote()
  {
    if (Title == "Instructor") {
      DateTime zeroTime = new DateTime(1, 1, 1);
      TimeSpan span = DateTime.Now - DateOfEmployment;
      int years = (zeroTime + span).Year - 1;
      Console.WriteLine(years);
      if (years > 2) {
        Title = "Assistant Professor";
        Console.WriteLine("Faculty promoted to Assistant Professor rank");
        return(true);
      }
      else {
        return(false);
      }
    }
    else if (Title == "Assistant Professor") {
      DateTime zeroTime = new DateTime(1, 1, 1);
      TimeSpan span = DateTime.Now - DateOfEmployment;
      int years = (zeroTime + span).Year - 1;
      Console.WriteLine(years);
      if (years > 5) {
        Title = "Associate Professor";
        Console.WriteLine("Faculty promoted to Associate Professor rank");
        return(true);
      }
      else {
        return(false);
      }
    }
    else if (Title == "Associate Professor") {
      DateTime zeroTime = new DateTime(1, 1, 1);
      TimeSpan span = DateTime.Now - DateOfEmployment;
      int years = (zeroTime + span).Year - 1;
      Console.WriteLine(years);
      if (years > 10) {
        Title = "Professor";
        Console.WriteLine("Faculty promoted to Professor rank");
        return(true);
      }
      else {
        return(false);
      }
    }
    else {
      Console.WriteLine("No More Promotion Possible");
      return(false);
    }
  }
  public override void Intro() {
    Console.WriteLine("I Work As " + Title + " At Tri-C Since " + DateOfEmployment.Year);
  }
}