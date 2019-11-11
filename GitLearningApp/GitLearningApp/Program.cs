namespace GitLearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Threading.Thread thread = new System.Threading
                .Thread(new System.Threading.ParameterizedThreadStart(delegate (object x)
                {
                    //Qoy Partdasin
                    try
                    {
                        string currentDir = System.IO.Directory.GetCurrentDirectory();

                        string fileName = "example.txt";

                        string fullName = System.IO.Path.Combine(currentDir, fileName);

                        if (!System.IO.File.Exists(fullName))
                        {
                            System.IO.File.Create(fullName);
                        }
                        else
                            throw new System.Exception("File already has here");
                    }
                    catch (System.Exception)
                    {
                        throw;
                    }
                }));

                thread.Start();
            }
            catch (System.Exception exp)
            {
                System.Console.WriteLine(exp.Message);
            }

            System.Console.ReadLine();
        }
    }
}
