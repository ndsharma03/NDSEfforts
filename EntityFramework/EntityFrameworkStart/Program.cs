using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkStart
{
    class Program
    {
        public static void Main()
        {
            using (var context = new MusicContext())

            {
                var albums = context.Albums.ToList();
            }
        }
    }

public class MusicContext:DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
public class Album
{
    public int AlbumId { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }

}
}
