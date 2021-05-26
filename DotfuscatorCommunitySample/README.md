Dotfuscator Community Sample
------------------------------------

This directory contains a simple C# program and a Dotfuscator configuration file
which demonstrates the features of Dotfuscator Community.

To build the sample project:

1. Open "DotfuscatorCommunitySample.sln" in Visual Studio.
2. Select the "Release" configuration.
3. Build the solution.
4. The built project will be located at "bin\Release\DotfuscatorCommunitySample.exe".

To run Dotfuscator Community on the built assembly:

1. Launch "PreEmptive Protection - Dotfuscator Community" from the Tools menu of Visual Studio.
2. From the Dotfuscator Community interface, select the "File" menu, then "Open...".
3. Open "dotfuscator_config.xml".
4. Build the Dotfuscator project by clicking "Build" (or selecting the "Build" menu, then "Build").
5. The obfuscated project will be located at "Dotfuscated\DotfuscatorCommunitySample.exe"

To view the internals of the built assembly and observe the renamed symbols:

1. Open the Developer Command Prompt (installed with Visual Studio).
2. Type "ildasm" and press Enter.
3. From the GUI that appears, select "File" -> "Open".
4. Open the obfuscated assembly ("Dotfuscated\DotfuscatorCommunitySample.exe").
5. Observe the disassembled tree structure.