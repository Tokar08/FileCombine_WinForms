using FileCombine.Renamer;

namespace FIleCombine.Renamer
{
    public class Renamer
    {
        private IStringGenerator generator;
        public List<FileInfo> Files { get; set; }
        public int AIStartValue { get; set; } = 0;
        public int AIStep { get; set; } = 1;

        public Renamer(IEnumerable<FileInfo> files, RenamerMode mode)     
        {
            Files = (List<FileInfo>)files;
            SetMode(mode);
        }
        public Renamer() { }

        public void SetMode(RenamerMode mode)
        {
            generator = mode switch
            {
                RenamerMode.UUID => new UuidGenerator(),
                RenamerMode.AUTOINCREMENT => new AutoincrementGenerator(AIStartValue, AIStep),
                RenamerMode.RANDOMNAME => new RandomNameGenerator(),



                _ => throw new InvalidOperationException(),
            };
        }

        public Report Rename(string prefix)
        {
            Report report = new Report();

            Files.ForEach(f =>
            {
                try
                {
                    string ext = f.Extension;

                    string randomChunk = generator.GetNext();

                    string newTitle = $"{prefix}{randomChunk}{ext}";

                    string path = Path.Combine(f.Directory.FullName, newTitle); 

                    f.MoveTo(path);

                    report.PushSuccess(f);
                }
                catch (Exception ex)
                {
                    report.PushError(f, ex);
                }
            });

            return report;
        }
    }




    //   public enum GenerateMethod
    //   {
    //       randomNumber = 1,
    //       randomName = 2,
    //       randomUUID = 3,
    //       randomMask = 4,
    //   }
    //   public class Renamer
    //   {

    //       NameGenerator generator = new NameGenerator();

    //       public void Rename(string oldPath, string NewPath, GenerateMethod Generation_option)
    //       {
    //           switch (Generation_option)
    //           {
    //               case GenerateMethod.randomName:
    //                   Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(oldPath, generator.GenerateName() + NewPath);
    //                   break;

    //               case GenerateMethod.randomNumber:
    //                   Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(oldPath, generator.GenerateNumber() + NewPath);
    //                   break;

    //               case GenerateMethod.randomUUID:
    //                   Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(oldPath, generator.GenerateUUID() + NewPath);
    //                   break;

    //           }

    //       }



    //   }

    ///* internal*/
    //   public class NameGenerator
    //   {
    //       private int Count { get; set; }

    //       public string GenerateNumber()
    //       {

    //           Count++;
    //           Console.WriteLine(Count);
    //           return Count.ToString();
    //       }
    //       public string GenerateName()
    //       {
    //           Console.WriteLine(Path.GetRandomFileName());
    //           return Path.GetRandomFileName();
    //       }
    //       public string GenerateUUID()
    //       {
    //           Guid guidCode = Guid.NewGuid();
    //           Console.WriteLine(guidCode);
    //           return guidCode.ToString();
    //       }

    //       public string GenerateMask()
    //       {
    //           string a = "a";
    //           return a;
    //       }

}


