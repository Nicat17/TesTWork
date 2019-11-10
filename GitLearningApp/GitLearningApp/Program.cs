namespace GitLearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread thread = new System.Threading
                .Thread(new System.Threading.ParameterizedThreadStart(delegate(object x) 
            {
                string currentDir = System.IO.Directory.GetCurrentDirectory();

                string fileName = "example.txt";

                string fullName = System.IO.Path.Combine(currentDir,fileName);

                if (!System.IO.File.Exists(fullName))
                {
                    System.IO.File.Create(fullName);
                }
                else
                    System.Console.WriteLine("Already has file");
            }));

            thread.Start();

            System.Console.ReadLine();
        }
    }
}
