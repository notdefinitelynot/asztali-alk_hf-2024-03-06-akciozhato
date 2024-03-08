using Termekek;

class Program
{
    static List<Termek> list = new List<Termek>();

    public static void bevasarolok(string filePath)
    {
        string[] sorok;
        try
        {
            sorok = File.ReadAllLines(filePath);

            foreach (var sor in sorok)
            {
                var zoldsegek = sor.Split(";");
                if (zoldsegek[0] == "salata")
                {
                    
                        var zoldseg = new Salata(Convert.ToInt32(zoldsegek[1]),Convert.ToInt32(zoldsegek[2]));
                        list.Add(zoldseg);

                }
                else
                {
                    var zoldseg = new RohadtParadicsom(Convert.ToInt32(zoldsegek[1]), Convert.ToDouble(zoldsegek[2]));
                    list.Add(zoldseg);
                }
            }


        }
        catch (Exception ex)
        {
            Console.WriteLine("Hiba a file beolvasásánál!");
            Console.WriteLine(ex);
        }

    }

    public static void mivanakosaramban(string filePath)
    {
            using (StreamWriter writer = new StreamWriter(filePath))
            for (int i = 0; i < list.Count; i++)
            {
                
                writer.WriteLine(list[i].ToString());

            }
    }

    static void Main(string[] args)
    {

        bevasarolok(@"C:\Users\ndoba\source\repos\Termekek\zoldsegek.txt");
        mivanakosaramban(@"C:\Users\ndoba\source\repos\Termekek\kosar.txt");
        
    }
}
