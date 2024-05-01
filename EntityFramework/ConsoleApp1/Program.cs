using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new MusicContext())
            {
                var albums=context.Albums.ToList();
            }
        }
    }

    public class MusicContext : System.Data.Entity.DbContext
    {
        //public MusicContext() : base("MusicStoreEntities")
        //{

        //}
        public  DbSet<Album> Albums { get; set; }
    }
    public class Album
    {
        public int AlbumId { get; set; }
        public String Title { get; set; }
        public double Price { get; set; }
    }
}
