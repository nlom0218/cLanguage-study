using System;
using System.Reflection;

namespace HelloWord
{
  class ReflectionGrammer
  {
    class Important : System.Attribute
    {
      string message;

      public Important(string message) { this.message = message; }
    }
    class Monster
    {
      [Important("Very Important")]
      public int hp;
      protected int attack;
      private float spped;

      void Attact() { }
    }
    public void Reflection()
    {
      // Reflection : X-Ray
      Monster monster = new Monster();

      Type type = monster.GetType();

      var fields = type.GetFields(System.Reflection.BindingFlags.Public
        | System.Reflection.BindingFlags.NonPublic
        | System.Reflection.BindingFlags.Static
        | System.Reflection.BindingFlags.Instance
      );

      foreach (FieldInfo field in fields)
      {
        string access = "protected";
        if (field.IsPublic)
          access = "public";
        else if (field.IsPrivate)
          access = "private";

        var attributes = field.GetCustomAttributes();

        System.Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
      }
    }
  }
}