namespace Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dùng directory để list ra các mục
            var path = "C:\\";
            var directories = Directory.GetDirectories(path);

            //foreach(var d in directories)
            //{
            //    Console.WriteLine(d);
            //}

            var directoriesInfor = new DirectoryInfo(path);
            foreach(var d in directoriesInfor.GetDirectories())
            {
                Console.WriteLine($"{d.LastWriteTime.ToString("MM/dd/yyyy HH:mm")} <DIR> {d.Name}");
            }

            var files = directoriesInfor.GetFiles();
            foreach(var f in files)
            {
                Console.WriteLine($"{f.LastWriteTime.ToString("MM/dd/yyyy HH:mm")} {f.Length,15} {f.Name}");
            }
        }
    }
}
