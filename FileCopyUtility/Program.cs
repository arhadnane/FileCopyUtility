using System;

namespace FileCopyUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"D:\SourceFolder";
            string destinationDirectory = @"D:\DestinationFolder";

            FileCopyUtility.CopyDirectory(sourceDirectory, destinationDirectory);
        }
    }
}
