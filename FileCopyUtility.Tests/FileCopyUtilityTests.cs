using System;
using System.IO;
using Xunit;

namespace FileCopyUtility.Tests
{
    public class FileCopyUtilityTests
    {
        [Fact]
        public void CopyDirectory_CopiesAllFilesAndSubdirectories()
        {
            // Arrange
            string sourceDirectory = Path.Combine(Path.GetTempPath(), "SourceFolder");
            string destinationDirectory = Path.Combine(Path.GetTempPath(), "DestinationFolder");

            // Create source directory and files
            Directory.CreateDirectory(sourceDirectory);
            File.WriteAllText(Path.Combine(sourceDirectory, "file1.txt"), "Content of file1");
            Directory.CreateDirectory(Path.Combine(sourceDirectory, "SubFolder"));
            File.WriteAllText(Path.Combine(sourceDirectory, "SubFolder", "file2.txt"), "Content of file2");

            // Act
            FileCopyUtility.CopyDirectory(sourceDirectory, destinationDirectory);

            // Assert
            Assert.True(Directory.Exists(destinationDirectory));
            Assert.True(File.Exists(Path.Combine(destinationDirectory, "file1.txt")));
            Assert.True(Directory.Exists(Path.Combine(destinationDirectory, "SubFolder")));
            Assert.True(File.Exists(Path.Combine(destinationDirectory, "SubFolder", "file2.txt")));

            // Clean up
            Directory.Delete(sourceDirectory, true);
            Directory.Delete(destinationDirectory, true);
        }
    }
}
