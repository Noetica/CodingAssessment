namespace CodingAssessment
{
    internal class Program
    {
        const string ShapesFile = @"<Triangle>,1,2,3
<Rectangle>,4,2
<Square>,3
<Rectangle>,4,3
<Circle>,2
<End>";
        static void Main(string[] args)
        {
            using (StringReader sr = new StringReader(ShapesFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
