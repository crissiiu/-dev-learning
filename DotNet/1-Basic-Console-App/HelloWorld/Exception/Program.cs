using System.Text;
namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            try
            {
                int n = 0;
                int x = 10 / n;
                Console.WriteLine(x);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Lỗi định dạng: " + ex.Message);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
