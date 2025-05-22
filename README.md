# BarbezDotEu.Diagnostics

This project is a .NET library targeting **.NET Standard 2.0**.  
It is designed to provide diagnostics-related functionality that can be used across different .NET implementations, including .NET Framework 4.8 and .NET Core.

## Target Framework

- .NET Standard 2.0

## Usage

Add a reference to this library in your .NET project to utilize its diagnostics features.

## ProcessRunner

The `BarbezDotEu.Diagnostics.ProcessRunner` class provides static methods to run external processes or open URIs.

- `Start(string fileNameOrUrlOrCommand)`:  
  Opens the specified file, URL, or command using the default process starter.

- `RunExternalProcess(string appPath, string args, bool awaitFinish = false)`:  
  Runs an external process with the given application path and arguments.  
  Optionally waits for the process to finish if `awaitFinish` is set to `true`.

### RunExternalProcess Method

`void RunExternalProcess(string appPath, string args, bool awaitFinish = false)`

- **appPath**: The path to the executable or application to run.
- **args**: The command-line arguments to pass to the process.
- **awaitFinish**: If `true`, the method waits for the process to exit before returning; if `false`, it returns immediately after starting the process.

This method uses `ProcessStartInfo` with `UseShellExecute` set to `false` to start the process. It is useful for launching external tools or scripts from your application.

## License

[MIT](LICENSE)