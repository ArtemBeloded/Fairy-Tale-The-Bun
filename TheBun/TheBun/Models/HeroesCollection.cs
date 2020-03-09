
using TheBun.Containers;

namespace TheBun.Models
{
    public class HeroesCollection<T>
    {
        public MyContainer<T> Collection { get; set; }

        public HeroesCollection()
        {
            Collection = new MyContainer<T>();
        }
    }
}
