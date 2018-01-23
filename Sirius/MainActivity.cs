using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;
using Com.Hitomi.Cmlibrary;
using Android.Graphics;

namespace Sirius
{
    [Activity(Label = "Sirius", MainLauncher = true, Theme = "@style/Theme.AppCompat")]
    public class MainActivity : AppCompatActivity, IOnMenuSelectedListener
    {
        String[] classesNome = { "Amigo", "Companheiro", "Pesquisador", "Pioneiro", "Excursionista", "Guia" };
        public void OnMenuSelected(int index)
        {
            Toast.MakeText(this, $"Você selecionou {classesNome[index]}", ToastLength.Short).Show();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var circleMenu = FindViewById<CircleMenu>(Resource.Id.circleMenu1);

            circleMenu.SetMainMenu(Color.LightGray, Resource.Drawable.ic_geral, Resource.Drawable.ic_fechar)
                                        .AddSubMenu(Color.ParseColor("#27408B"), Resource.Drawable.ic_amigo)
                                        .AddSubMenu(Color.ParseColor("#B22222"), Resource.Drawable.ic_companheiro)
                                        .AddSubMenu(Color.ParseColor("#2E8B57"), Resource.Drawable.ic_pesquisador)
                                        .AddSubMenu(Color.ParseColor("#696969"), Resource.Drawable.ic_pioneiro)
                                        .AddSubMenu(Color.ParseColor("#DA70D6"), Resource.Drawable.ic_excursionista)
                                        .AddSubMenu(Color.ParseColor("#FFD700"), Resource.Drawable.ic_guia)
                                        .SetOnMenuSelectedListener(this);
        }
    }
}

