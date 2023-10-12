using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        public int IdArticulo { get; set; }
        public string CodArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public string Marcas { get; set; }
        public string Categoria { get; set; }
        public float Precio { get; set; }
        public string imagenUrl { get; set; }
    }

    public class ArticulosNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            lista.Add(new Articulos());
            lista.Add(new Articulos());
            lista.Add(new Articulos());
            lista.Add(new Articulos());
            lista.Add(new Articulos());

            lista[0].IdArticulo = 1;
            lista[0].CodArticulo = "S01";
            lista[0].NombreArticulo = "Galaxy S10";
            lista[0].DescripcionArticulo = "Una canoa cara";
            lista[0].Marcas = "Samsung";
            lista[0].Categoria = "Celulares";
            lista[0].Precio = 69999;
            lista[0].imagenUrl = "https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542";

            lista[1].IdArticulo = 2;
            lista[1].CodArticulo = "M03";
            lista[1].NombreArticulo = "Moto G Play 7ma Gen";
            lista[1].DescripcionArticulo = "Ya siete de estos?";
            lista[1].Marcas = "Motorola";
            lista[1].Categoria = "Celulares";
            lista[1].Precio = 15699;
            lista[1].imagenUrl = "https://www.motorola.cl/arquivos/moto-g7-play-img-product.png?v=636862863804700000";

            lista[2].IdArticulo = 3;
            lista[2].CodArticulo = "S99";
            lista[2].NombreArticulo = "Play 4";
            lista[2].DescripcionArticulo = "Ya no se cuantas versiones hay";
            lista[2].Marcas = "Sony";
            lista[2].Categoria = "Media";
            lista[2].Precio = 35000;
            lista[2].imagenUrl = "https://www.euronics.cz/image/product/800x800/532620.jpg";

            lista[3].IdArticulo = 4;
            lista[3].CodArticulo = "S56";
            lista[3].NombreArticulo = "Bravia 55";
            lista[3].DescripcionArticulo = "Alta tele";
            lista[3].Marcas = "Sony";
            lista[3].Categoria = "Televisores";
            lista[3].Precio = 49500;
            lista[3].imagenUrl = "https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450";

            return lista;
        }
    }
}
