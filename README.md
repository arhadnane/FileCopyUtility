# FileCopyUtility

FileCopyUtility is a C# console application that allows you to copy all the contents of a source folder to a destination folder, including subfolders and their files.

## Features

- Copies all files from a source folder to a destination folder.
- Recursively copies subfolders and their contents.
- Overwrites existing files in the destination folder.

## Prerequisites

- .NET 9.0
- Visual Studio 2022

## Installation

1. Clone the repository: `git clone https://github.com/your-username/FileCopyUtility.git`
2. Open the project in Visual Studio 2022.

## Usage

1. Modify the `Program.cs` file to specify the paths of the source and destination folders:
   - `string sourceDirectory = @"C:\SourceFolder";`
   - `string destinationDirectory = @"C:\DestinationFolder";`
   - `FileCopyUtility.CopyDirectory(sourceDirectory, destinationDirectory);`

2. Run the application.

## Tests

This project uses `xUnit` for unit testing. To run the tests:

1. Open the Test Explorer in Visual Studio.
2. Click on **Run All** to execute all tests.

The test file `FileCopyUtilityTests.cs` contains a unit test to verify that the `CopyDirectory` method correctly copies all files and subfolders.

## Contribution

Contributions are welcome! Please submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License: https://opensource.org/license/mit
  
