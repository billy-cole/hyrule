using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MonsterHunterListViews
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Monster> MonsterList {get; set; }

        public MainPage()
        {
            InitializeComponent();

            PopulateMonsterList();
        }

        private void PopulateMonsterList()
        {
            MonsterList = new ObservableCollection<Monster>()
            {
                new Monster()
                {
                    MonsterName = "Rathalos",
                    MonsterType = "Flying Wyvern",
                    MonsterImageSource = ImageSource.FromFile("Rathalos.png"),
                    MonsterNameColor = Color.Red,
                    MonsterUrl = "http://monsterhunter.wikia.com/wiki/Rathalos",
                    MonsterDescription = 
                    "Rathalos are large, bipedal wyverns with a spiny," +
                    " armored hide covering their body. They are highly territorial monsters who are aggressive" +
                    " towards intruders, and will attempt to kill any monster who may pose a threat to their land"
                },

                new Monster()
                {
                    MonsterName = "Nergigante",
                    MonsterType = "Elder Dragon",
                    MonsterImageSource = ImageSource.FromFile("Nergigante.png"),
                    MonsterNameColor = Color.Orange,
                    MonsterUrl = "http://monsterhunter.wikia.com/wiki/Nergigante",
                    MonsterDescription = "Nergigante is a dragon covered in spikes that regrow if they are broken off." +
                    "These spikes are often launched from Nergigante's body when it attacks its enemies." +
                    "Nergigante is an extremely aggresive monster that will continue to fight, even if it means harming its own body." +
                    "It will attack anything without hesitation."
                },

                new Monster()
                {
                    MonsterName = "Odogaron",
                    MonsterType = "Fanged Wyvern",
                    MonsterImageSource = ImageSource.FromFile("Odogaron.png"),
                    MonsterNameColor = Color.Red,
                    MonsterUrl = "http://monsterhunter.wikia.com/wiki/Odogaron",
                    MonsterDescription = "Odogaron resembles a gruesome feral dog covered in red scales and bony protrusions." +
                    "It's most destinctive feature, is its double row of claws, which are used to inflict deep wounds in its prey." +
                    "Despite its large size, the Odogaron is very agile, and is able to rush down opponents before delivering bites with its powerful jaw."


                },

                new Monster()
                {
                    MonsterName = "Deviljho",
                    MonsterType = "Brute Wyvern",
                    MonsterImageSource = ImageSource.FromFile("Deviljho.png"),
                    MonsterNameColor = Color.DarkOliveGreen,
                    MonsterUrl = "http://monsterhunter.wikia.com/wiki/Deviljho",
                    MonsterDescription = "The Deviljho is a bipedal brute wyvern characterized by its green coloration and muscular body." +
                    "Due to its powerful set of jaws, the Deviljho can deliver bone-crunching bites to any prey or foe." +
                    "In addition, its powerful hind legs allow it to run at high speeds, and leap incredibly large distances."
                },

                new Monster()
                {
                    MonsterName = "Kirin",
                    MonsterType = "Elder Dragon",
                    MonsterImageSource = "Kirin.png",
                    MonsterNameColor = Color.LightSkyBlue,
                    MonsterUrl = "http://monsterhunter.wikia.com/wiki/Kirin",
                    MonsterDescription = "The Kirin is a dragon that resembles a unicorn covered in scales. Its majestic white mane are" +
                    " often crackling with static electricity. The Kirin is a passive and peaceful creature, but if tempted, " +
                    "it can attack with a barrage of powerful lightning, and posseses extreme agility."
                },

                new Monster()
                {
                    MonsterName = "Lunastra",
                    MonsterType = "Elder Dragon",
                    MonsterImageSource = ImageSource.FromFile("Lunastra.png"),
                    MonsterNameColor = Color.SteelBlue,
                    MonsterUrl = "http://monsterhunter.wikia.com/wiki/Lunastra",
                    MonsterDescription = "Lunastra is a dragon with the features of a lioness. The Lunastra can produce a highly flammable" +
                    " powder that is spread by flapping her wings. After gnashing her teeth to create a spark, the powder explodes, allowing her to" +
                    " attack her foes at a varying amount of distances."
                },

                new Monster()
                {
                    MonsterName = "Pukei Pukei",
                    MonsterType = "Bird Wyvern",
                    MonsterImageSource = ImageSource.FromFile("PukeiPukei.png"),
                    MonsterNameColor = Color.BlueViolet,
                    MonsterUrl = "http://monsterhunter.wikia.com/wiki/Pukei-Pukei",
                    MonsterDescription = "The Pukei Pukei is a bird wyvern that closely resembles a chameleon with frog eyes." +
                    "Pukei Pukei are known for storing food with in their mouth and tail before combining it with poison." +
                    "This allows the Pukei Pukei to spew poisonous goo against potention predators."
                }
            };

            MonsterListView.ItemsSource = MonsterList;
        }

        private void Handle_DeleteItem(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var monsterToDelete = (Monster)menuItem.CommandParameter;
            MonsterList.Remove(monsterToDelete);

        }

        private void Handle_ShowMonsterInfo(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var monsterToShow = (Monster)menuItem.CommandParameter;
            Navigation.PushAsync(new MonsterInfoPage(monsterToShow));
        }

        private void Handle_Refreshing(object sender, EventArgs e)
        {
            PopulateMonsterList();
            MonsterListView.IsRefreshing = false;
        }
    }
}
