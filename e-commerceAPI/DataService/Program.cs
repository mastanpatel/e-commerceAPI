using System;

namespace DataService
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonParser jparser = new JsonParser();

            DB db = new DB();
            //jparser.loadFile();
            db.AddProduct(jparser.loadFile());
        }
    }
}
