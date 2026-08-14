# First Steps in C# — Visual Studio Console Exercises

Two very small C# console applications, written while first learning the
language in Visual Studio. Kept as a record of a starting point, not as a
project.

Prompts and output strings are in Italian.

## The programs

### `1_Basic C.sharp/` — the basics

The first program: declare a `string` and an `int`, print with
`Console.WriteLine`, read a line back with `Console.ReadLine`, then a `while`
loop with a compound `if` condition (`x > 20 && x < 60`) that prints only the
even numbers inside a window, while counting up to 100. `Console.ReadKey()`
holds the window open — the standard reflex when running a console app from
inside Visual Studio.

### `2_Fattoriale di un Numero INPUT.cs` — factorial from user input

Asks for a number and computes its factorial with an accumulating `for` loop,
then prints it with a formatted string (`"Il fattoriale di {0} e: {1}"`).

A loose `.cs` file rather than a project: its `namespace` is `ConsoleApp1`, so
it is the `Program.cs` that was written inside the `ConsoleApp1/` solution and
then saved off to one side. The `ConsoleApp1/` solution committed here has had
its `Main` emptied out — the code that was in it is this file.

## Repository layout

```
1_Basic C.sharp/                    Visual Studio solution (.sln) + project
  1_Basic C.sharp/Program.cs        the source
2_Fattoriale di un Numero INPUT.cs  loose source file, factorial exercise
ConsoleApp1/                        Visual Studio solution, Main now empty
```

Both solutions are committed with their build output and IDE state
(`bin/`, `obj/`, `.vs/`, `.suo`, `.pdb`, `.exe`) — there is no `.gitignore`.
Only the `.cs` files are worth reading.

## Building

Open either `.sln` in Visual Studio and press F5. They target the .NET
Framework and were written against the Visual Studio project templates of the
time, so on a modern toolchain it is quicker to create a new console project
and paste the source in:

```bash
dotnet new console -o factorial
# paste the body of Main from 2_Fattoriale di un Numero INPUT.cs
dotnet run --project factorial
```

## Related repositories

- [`highschool-programming-archive`](https://github.com/alessiomartini/highschool-programming-archive)
  — the Python and web programming from the same period.
- [`intro-to-c-programming-unimib`](https://github.com/alessiomartini/intro-to-c-programming-unimib)
  — the university C course that came after.
