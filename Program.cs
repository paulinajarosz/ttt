
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wzorzecProjektowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt masło = new Produkt();
            masło.SetIDProdukt(4657458)
                .SetNazwa("Dobre masło")
                .SetNumerPartii(506190432)
                .SetDataProdukcji(25)
                .SetCena(3);

            Fabryka mleczarnia = new Fabryka();
            mleczarnia.AddProdukt(masło);

            Console.WriteLine(mleczarnia.GetListaProduktow().ElementAt(0).GetNazwa());
            Console.ReadKey();
        }
    }

    class Produkt
    {
        long IDProduktu;
        string nazwa;
        int numerPartii;
        int dataProdukcji;
        int cena;


        public Produkt()
        {
            IDProduktu = 0;
            nazwa = "";
            numerPartii = 0;
            dataProdukcji = 0;
            cena = 0;
        }

        public Produkt(long IdProduktu, string Nazwa, int NumerPartii, int DataProdukcji, int Cena)
        {
            IDProduktu = IdProduktu;
            nazwa = Nazwa;
            numerPartii = NumerPartii;
            dataProdukcji = DataProdukcji;
            cena = Cena;
        }

        //Gettery
        public long GetIDProduktu()
        {
            return IDProduktu;
        }

        public string GetNazwa()
        {
            return nazwa;
        }

        public int GetNumerPartiiu()
        {
            return numerPartii;
        }

        public int GetDataProdukcjik()
        {
            return dataProdukcji;
        }

        public int GetCena()
        {
            return cena;
        }

        //Settery
        public Produkt SetIDProdukt(long IdProduktu)
        {
            if (IdProduktu < 0)
                throw new System.ArgumentException("ID musi być większe od 0.");
            else
                IDProduktu = IdProduktu;
            return this;
        }

        public Produkt SetNazwa(string Nazwa)
        {
            if (Nazwa.Length < 5)
                throw new System.ArgumentException("Nazwa musi się składać z minimum 5 znaków.");
            else
                nazwa = Nazwa;
            return this;
        }

        public Produkt SetNumerPartii(int NumerPartii)
        {
            numerPartii = NumerPartii;
            return this;
        }

        public Produkt SetDataProdukcji(int DataProdukcji)
        {
            if (DataProdukcji < 2017) 
                throw new System.ArgumentException("Data produkcji musi być większa lub równa od 2016.");
            else
                dataProdukcji = DataProdukcji;
            return this;
        }

        public Produkt SetCena(int Cena)
        {
            if (Cena < 0)
                throw new System.ArgumentException("Cena nie może być mniejsza od 0 zł.");
            else
                cena = Cena;
            return this;
        }
    }

    class Fabryka
    {
        long IDFabryki;
        List<Produkt> listaProduktow;

        public Fabryka()
        {
            IDFabryki = 0;
            listaProduktow = new List<Produkt>();
        }

        public Fabryka(long IdFabryki, List<Produkt> ListaProduktow)
        {
            IDFabryki = IdFabryki;
            listaProduktow = ListaProduktow;
        }

        public long GetIDPracownik()
        {
            return IDFabryki;
        }

        public List<Produkt> GetListaProduktow()
        {
            return listaProduktow;
        }

        public Fabryka SetIDFabryki(long IdFabryka)
        {
            if (IdFabryka < 0)
                throw new System.ArgumentException("ID musi być większe od 0.");
            else
                IDFabryki = IdFabryka;
            return this;
        }

        public Fabryka SetListaProduktow(List<Produkt> ListaProduktow)
        {
            if (ListaProduktow != null)
                listaProduktow = ListaProduktow;
            else
                throw new System.ArgumentException("Lista produktów nie zawiera produktów.");
            return this;
        }
    

        public Fabryka AddProdukt(Produkt Produkt)
        {
            if (Produkt != null)
                listaProduktow.Add(Produkt);
            else
                throw new System.ArgumentException("Argument jest niepoprawny.");
            return this;
        
        }
    }
}
