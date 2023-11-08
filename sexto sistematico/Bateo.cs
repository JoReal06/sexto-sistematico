using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sexto_sistematico
{
    public class jugadores
    {


        private string H;
        private string AB;
        private string iglID;
        private string Birht;
        public jugadores(string h, string ab, string igl, string Birht)
        {
       this.H = h;
            this.AB = ab;
            this.iglID = igl;
            this.Birht = Birht;
        }

        public jugadores()
        {

        }


        public List<jugadores>  Liga(List<jugadores> lis)
        {
            var Liga_ameri = from jugadores in lis
                             where jugadores.iglID == "AL"
                             select jugadores;

            List<jugadores> list = new List<jugadores>();
            list = Liga_ameri.ToList();
            return list;
        }

        public List<jugadores> Pro(List<jugadores> lis)
        {


            var nacidos_en_dominicana = from jugadores in lis
                                        where jugadores.Birht == "D.R"
                                        select jugadores;


            var arriba_de = from jugadores in nacidos_en_dominicana
                            where (double.Parse(jugadores.H) / double.Parse(jugadores.AB)) > 0.300
                            select jugadores;


            List<jugadores> list = new List<jugadores>();
            list = arriba_de.ToList();
            return list;
        }



    }
}
