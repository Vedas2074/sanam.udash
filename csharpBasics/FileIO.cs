using System.IO;
using System;



namespace FileDirectoryHandlin
{

    public class FileDirectoryHandling

    {
        public void LearnFileReading()
        {       // @"path" : this in the method of giving he path
            string fileContent = File.ReadAllText("Test.txt");
            Console.WriteLine(fileContent);
        }

        public void LearnFileWriting() => File.WriteAllText("a.txt", "my name is sanam");

        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("Test.txt");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;


            Console.WriteLine($"lenght: {x}");
            Console.WriteLine($"create time : {y}");
            Console.WriteLine($"directory name :{z}");
        }

        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText(@"ABC\sanam.txt","my name is sanam udash");
        }

        internal void LearnDirectoryInfo()
        {
            string folderPath = @"C:\Users\sanam\Desktop\.net\sanam.udash\csharpBasics";
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            var files =directory.GetFiles();

           Console.WriteLine($"the number of files in directory :{files.Length}");
        }


    }



}