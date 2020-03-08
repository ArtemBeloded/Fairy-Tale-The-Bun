using TheBun.Containers;

namespace TheBun.Models.Main
{
    class MainCharacterCollection
    {
        public MyContainer<MainCharacter> mainCollection { get; set; }

        public MainCharacterCollection()
        {
            mainCollection = new MyContainer<MainCharacter>();
        }
    }
}
