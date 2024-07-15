internal class Program
{    
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Chuong trinh tinh tong cua 2 so");
        int so1, so2, tong, hieu, tich;
        Console.WriteLine("nhập số 1 ");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhập số 2 ");
        so2 = Convert.ToInt32(Console.ReadLine());        
        tong = so1 + so2;
        Console.WriteLine("tong cua 2 so la " + tong);

        Console.WriteLine("nhập số 1 ");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhập số 2 ");
        so2 = Convert.ToInt32(Console.ReadLine());
        hieu = so1 - so2;
        Console.WriteLine("hieu cua 2 so la " + hieu);

        Console.WriteLine("nhập số 1 ");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhập số 2 ");
        so2 = Convert.ToInt32(Console.ReadLine());
        tich = so1 * so2;
        Console.WriteLine("hieu cua 2 so la " + tich);

        double thuong;
        try
        {
            thuong = so1 / so2;
            Console.WriteLine("thuong cua 2 so {so1} va {so2} la {thuong}"); 
        }
        catch
        {
            Console.WriteLine("khong the chia cho 0");
        }
    }
}