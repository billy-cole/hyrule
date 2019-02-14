using Xamarin.Forms;

namespace MonsterHunterListViews
{
    public class Monster
    {
        public string      MonsterName        { get; set; }
        public string      MonsterUrl         { get; set; }
        public string      MonsterType        { get; set; }
        public string      MonsterDescription { get; set; }
        public Color       MonsterNameColor   { get; set; }
        public ImageSource MonsterImageSource { get; set; }
    }
}
