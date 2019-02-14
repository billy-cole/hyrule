using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonsterHunterListViews
{
	public partial class MonsterInfoPage : ContentPage
	{
		public MonsterInfoPage ()
		{
			InitializeComponent ();
		}

        public MonsterInfoPage(Monster monster)
        {
            InitializeComponent();
            BindingContext = monster;
        }
	}
}