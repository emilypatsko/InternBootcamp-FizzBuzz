# Running the FizzBuzz application

The program can be run by using the 'Run' button in your IDE, or by running `dotnet run` from your terminal. By default, this will apply all the rules (Fizz, Buzz, Bang, Bong, Fezz, and Reverse) and print from 1 to 100.

You can specify the maximum number to print up to, and the rules you want to apply, by running from the command line and specifying arguments:

`dotnet run -- 250 fizz buzz bang`

The rules you can specify are: "fizz", "buzz", "bang", "bong", "fezz", "reverse".

You can specify the max number without specifying which rules to apply (they will all be applied).
You *must* specify the max number if you want to specify particular rules to apply.

For example,

`dotnet run -- 250` is valid and will print up to 250, and apply all the rules.
`dotnet run -- fezz buzz` is not valid and will not run correctly.
