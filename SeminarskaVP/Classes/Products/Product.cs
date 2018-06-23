using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Products
{
    [Serializable]
    public abstract class Product            //  bazna klasa od koja ke se izvedat uslugi, nedelivi produkti i izmereni produkti
    {
        public int Id { get; }             //  id ili bar kod na produktot
        public string Name { get; set; }        //  ime na produktot
        public decimal Price { get; set; }      //  cena na eden produkt
        public decimal Discount { get; set; }   //  popust
        public string Description { get; set; } //  dopolnitelen opis ili komentar za produktot


        //public abstract bool CheckPurchase(decimal amount);         //  metoda koja proveruva dali na zaliha ima dovolno za da moze da is izvrsi kupuvanjeto na toj produkt

        public abstract bool AddAmount(string amount);

        public abstract object ToDataRow ();

        public bool CheckId(int id) {   //  metoda koja proveruva dali se raboti za ist produkt
            return Id == id;
        }

        public Product(int id,string name,decimal price) {
            Id = id;
            Name = name;
            Price = price;
            Discount = 0;
        }   //  kraj konstruktor za produkt

    }
}
