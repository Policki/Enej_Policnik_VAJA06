using System.IO;

namespace vaja6 {

    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

    class Igralec {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;

        public Igralec() { //Ustvari novega igralca z unikatnim ID-jem, praznim uporabniškim imenom in geslom. Poveča števec igralcev.
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        public int Id { //Vrne ID igralca
            get
            {
                return id;
            }
        }

        public string U_ime { //Dovoli prebrati in nastaviti uporabniško ime igralca. Pri nastavljanju odstrani morebitne presledke na začetku in koncu.
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

        public string U_geslo //Dovoli prebrati in nastaviti geslo igralca. Pri nastavljanju odstrani presledke na začetku in koncu.
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

        public static int StIg //Statistična lastnost, ki vrne trenutno vrednost števca ustvarjenih igralcev.
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
