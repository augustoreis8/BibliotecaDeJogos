using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDejogos.Classes
{
    internal class Game
    {
        //ATRIBUTOS
        String titulo;
        int ano;
        String genero;
        String empresa;
        int metacritic;

        //CONSTRUTORES
        public Jogo(String titulo, int ano, String genero,
                    String empresa, int metacritic)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.empresa = empresa;
            this.metacritic = metacritic;
        }

        public Jogo(String titulo, int ano, String genero,
                    String empresa)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.empresa = empresa;
        }

        //METODOS DE ACESSO
        //GETTER - RETORNA VALOR DO ATRIBUTO
        public String getTitulo()
        {
            return this.titulo;
        }
        public int getAno()
        {
            return this.ano;
        }
        public String getGenero()
        {
            return this.genero;
        }
        public String getEmpresa()
        {
            return this.empresa;
        }
        public int getMetacritic()
        {
            return this.metacritic;
        }


        //SETTER - MODIFICA VALOR DO ATRIBUTO
        public String setTitulo()
        {
            return this.titulo;
        }
        public int setAno()
        {
            return this.ano;
        }
        public String setGenero()
        {
            return this.genero;
        }
        public String setEmpresa()
        {
            return this.empresa;
        }
        public int setMetacritic()
        {
            return this.metacritic;
        }
    }
}
