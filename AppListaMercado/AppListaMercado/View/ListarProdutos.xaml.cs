using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppListaMercado.Model;
using AppListaMercado.View;
using AppListaMercado.Helper;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaMercado.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarProdutos : ContentPage
    {

        ObservableCollection<Produto> lista_produtos = new ObservableCollection<Produto>();

        public ListarProdutos()
        {
            InitializeComponent();

            // lst_produtos.ItemsSource = lista_produtos;
        }

        
        private void procurar_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string buscou = e.NewTextValue;

            System.Threading.Tasks.Task.Run(async () =>

            {
                List<Produto> temp = await App.Database.Search(buscou);

                /**
                 * Limpando a ObservableCollection antes de add os itens vindos da busca.
                 */

                // ListarProdutos.Clear();

                foreach (Produto item in temp)
                {
                    // ListarProdutos.Add(item);
                }

                // ref_carregando.IsRefreshing = false;
            });

        } 

        private void lst_produtos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }

        private void Somar_Clicked(object sender, EventArgs e)
        {

        }

        private void Novo_Clicked(object sender, EventArgs e)
        {

        }
    }
}