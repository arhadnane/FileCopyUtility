using System;
using System.IO;

namespace FileCopyUtility
{
    public class FileCopyUtility
    {
        public static void CopyDirectory(string sourceDirectory, string destinationDirectory)
        {
            try
            {
                // Ensure the source directory exists
                if (Directory.Exists(sourceDirectory))
                {
                    // Create the destination directory if it doesn't exist
                    if (!Directory.Exists(destinationDirectory))
                    {
                        Directory.CreateDirectory(destinationDirectory);
                    }

                    // Get all files from the source directory
                    string[] files = Directory.GetFiles(sourceDirectory);
                    foreach (string file in files)
                    {
                        // Get the file name
                        string fileName = Path.GetFileName(file);
                        // Create the destination file path
                        string destFile = Path.Combine(destinationDirectory, fileName);
                        // Copy the file to the destination
                        File.Copy(file, destFile, true); // true overwrites the file if it already exists
                    }

                    // Get all subdirectories from the source directory
                    string[] directories = Directory.GetDirectories(sourceDirectory);
                    foreach (string directory in directories)
                    {
                        // Get the directory name
                        string directoryName = Path.GetFileName(directory);
                        // Create the destination directory path
                        string destDirectory = Path.Combine(destinationDirectory, directoryName);
                        // Recursively copy the subdirectory
                        CopyDirectory(directory, destDirectory);
                    }

                    Console.WriteLine("All files and subdirectories copied successfully.");
                }
                else
                {
                    Console.WriteLine("Source directory does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
