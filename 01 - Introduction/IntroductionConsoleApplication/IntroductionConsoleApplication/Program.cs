using System;

namespace IntroductionConsoleApplication {
  class Program {
    static void Main() {

      WriteMessage("Hello World!");
      WriteMessage("Press any key to exit.");

      Console.ReadKey();
    }

    private static void WriteMessage(string message) {
      Console.WriteLine(message);
    }

  }
}
