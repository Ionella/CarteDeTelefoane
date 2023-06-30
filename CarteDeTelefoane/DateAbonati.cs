using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteDeTelefoane
{
    public class DateAbonati
    {
        private enum CodTara {_373}
      
        enum Raion
        {
            Chisinau,
            Cimislia,
            Edinet,
            Hincesti,
            Leova
        }
        private enum CodRaion { _022, _0241,_0246,_0269,_0263}

        enum Sate
        {
            Codru,
            Cricova,
            Ghidighici,
            Hulboaca,
            Vatra,

            Albina,
            Codreni,
            Fetita,
            GuraGalbenei,
            Munteni,

            Fetesti,
            Goleni,
            Onesti,
            Ruseni,
            Volodeni,

            Bozieni,
            Caracui,
            FundulGalbenei,
            Pascani,
            Sofia,

            Iargara,
            Sarateni,
            Troian,
            Victoria,
            Vozneseni
        }
        struct abonat
        {
            public string nume;
            public string prenume;
            public CodTara codtara;
            public Raion raion;
            public CodRaion codraion;
            public Sate sat;
            public string numartelefon;

            public void AfisareAbonati()
            {
                Console.WriteLine(nume + " " + prenume + " " + 
                    codtara + " " + raion + " " + codraion + 
                    " " + sat + " " + numartelefon);
            }
        }
        public static void Informatii ()
        {
            var persoana1 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Codru,
                numartelefon = "51-3-15"
            };
            persoana1.AfisareAbonati();

            var persoana2 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Codru,
                numartelefon = "51-3-15"
            };
            persoana2.AfisareAbonati();

            var persoana3 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Codru,
                numartelefon = "51-3-15"
            };
            persoana3.AfisareAbonati();

            var persoana4 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Cricova,
                numartelefon = "51-3-15"
            };
            persoana4.AfisareAbonati();

            var persoana5 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Cricova,
                numartelefon = "51-3-15"
            };
            persoana5.AfisareAbonati();

            var persoana6 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Cricova,
                numartelefon = "51-3-15"
            };
            persoana6.AfisareAbonati();

            var persoana7 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Ghidighici,
                numartelefon = "51-3-15"
            };
            persoana7.AfisareAbonati();

            var persoana8 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Ghidighici,
                numartelefon = "51-3-15"
            };
            persoana8.AfisareAbonati();

            var persoana9 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Ghidighici,
                numartelefon = "51-3-15"
            };
            persoana9.AfisareAbonati();

            var persoana10 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Hulboaca,
                numartelefon = "51-3-15"
            };
            persoana10.AfisareAbonati();

            var persoana11 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Hulboaca,
                numartelefon = "51-3-15"
            };
            persoana11.AfisareAbonati();

            var persoana12 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Hulboaca,
                numartelefon = "51-3-15"
            };
            persoana12.AfisareAbonati();

            var persoana13 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Vatra,
                numartelefon = "51-3-15"
            };
            persoana13.AfisareAbonati();

            var persoana14 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Vatra,
                numartelefon = "51-3-15"
            };
            persoana14.AfisareAbonati();

            var persoana15 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Chisinau,
                codraion = CodRaion._022,
                sat = Sate.Vatra,
                numartelefon = "51-3-15"
            };
            persoana15.AfisareAbonati();

            var persoana16 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Albina,
                numartelefon = "51-3-15"
            };
            persoana16.AfisareAbonati();

            var persoana17 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Albina,
                numartelefon = "51-3-15"
            };
            persoana17.AfisareAbonati();

            var persoana18 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Albina,
                numartelefon = "51-3-15"
            };
            persoana18.AfisareAbonati();

            var persoana19 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Codreni,
                numartelefon = "51-3-15"
            };
            persoana19.AfisareAbonati();

            var persoana20 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Codreni,
                numartelefon = "51-3-15"
            };
            persoana20.AfisareAbonati();

            var persoana21 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Codreni,
                numartelefon = "51-3-15"
            };
            persoana21.AfisareAbonati();

            var persoana22 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Fetita,
                numartelefon = "51-3-15"
            };
            persoana22.AfisareAbonati();

            var persoana23 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Fetita,
                numartelefon = "51-3-15"
            };
            persoana23.AfisareAbonati();

            var persoana24 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Fetita,
                numartelefon = "51-3-15"
            };
            persoana24.AfisareAbonati();

            var persoana25 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.GuraGalbenei,
                numartelefon = "51-3-15"
            };
            persoana25.AfisareAbonati();

            var persoana26 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.GuraGalbenei,
                numartelefon = "51-3-15"
            };
            persoana26.AfisareAbonati();

            var persoana27 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.GuraGalbenei,
                numartelefon = "51-3-15"
            };
            persoana27.AfisareAbonati();

            var persoana28 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Munteni,
                numartelefon = "51-3-15"
            };
            persoana28.AfisareAbonati();

            var persoana29 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Munteni,
                numartelefon = "51-3-15"
            };
            persoana29.AfisareAbonati();

            var persoana30 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Cimislia,
                codraion = CodRaion._0241,
                sat = Sate.Munteni,
                numartelefon = "51-3-15"
            };
            persoana30.AfisareAbonati();


            var persoana31 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Fetesti,
                numartelefon = "51-3-15"
            };
            persoana31.AfisareAbonati();

            var persoana32 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Fetesti,
                numartelefon = "51-3-15"
            };
            persoana32.AfisareAbonati();

            var persoana33 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Fetesti,
                numartelefon = "51-3-15"
            };
            persoana33.AfisareAbonati();

            var persoana34 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Goleni,
                numartelefon = "51-3-15"
            };
            persoana34.AfisareAbonati();

            var persoana35 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Goleni,
                numartelefon = "51-3-15"
            };
            persoana35.AfisareAbonati();

            var persoana36 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Goleni,
                numartelefon = "51-3-15"
            };
            persoana36.AfisareAbonati();

            var persoana37 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Onesti,
                numartelefon = "51-3-15"
            };
            persoana37.AfisareAbonati();

            var persoana38 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Onesti,
                numartelefon = "51-3-15"
            };
            persoana38.AfisareAbonati();

            var persoana39 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Onesti,
                numartelefon = "51-3-15"
            };
            persoana39.AfisareAbonati();

            var persoana40 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Ruseni,
                numartelefon = "51-3-15"
            };
            persoana40.AfisareAbonati();

            var persoana41 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Ruseni,
                numartelefon = "51-3-15"
            };
            persoana41.AfisareAbonati();

            var persoana42 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Ruseni,
                numartelefon = "51-3-15"
            };
            persoana42.AfisareAbonati();

            var persoana43 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Volodeni,
                numartelefon = "51-3-15"
            };
            persoana43.AfisareAbonati();

            var persoana44 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Volodeni,
                numartelefon = "51-3-15"
            };
            persoana44.AfisareAbonati();

            var persoana45 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Edinet,
                codraion = CodRaion._0246,
                sat = Sate.Volodeni,
                numartelefon = "51-3-15"
            };
            persoana45.AfisareAbonati();

            var persoana46 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Bozieni,
                numartelefon = "51-3-15"
            };
            persoana46.AfisareAbonati();

            var persoana47 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Bozieni,
                numartelefon = "51-3-15"
            };
            persoana47.AfisareAbonati();

            var persoana48 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Bozieni,
                numartelefon = "51-3-15"
            };
            persoana48.AfisareAbonati();

            var persoana49 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Caracui,
                numartelefon = "51-3-15"
            };
            persoana49.AfisareAbonati();

            var persoana50 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Caracui,
                numartelefon = "51-3-15"
            };
            persoana50.AfisareAbonati();

            var persoana51 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Caracui,
                numartelefon = "51-3-15"
            };
            persoana51.AfisareAbonati();

            var persoana52 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.FundulGalbenei,
                numartelefon = "51-3-15"
            };
            persoana52.AfisareAbonati();

            var persoana53 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.FundulGalbenei,
                numartelefon = "51-3-15"
            };
            persoana53.AfisareAbonati();

            var persoana54 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.FundulGalbenei,
                numartelefon = "51-3-15"
            };
            persoana54.AfisareAbonati();

            var persoana55 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Pascani,
                numartelefon = "51-3-15"
            };
            persoana55.AfisareAbonati();

            var persoana56 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Pascani,
                numartelefon = "51-3-15"
            };
            persoana56.AfisareAbonati();

            var persoana57 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Pascani,
                numartelefon = "51-3-15"
            };
            persoana57.AfisareAbonati();

            var persoana58 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Sofia,
                numartelefon = "51-3-15"
            };
            persoana58.AfisareAbonati();

            var persoana59 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0269,
                sat = Sate.Sofia,
                numartelefon = "51-3-15"
            };
            persoana59.AfisareAbonati();

            var persoana60 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Sofia,
                numartelefon = "51-3-15"
            };
            persoana60.AfisareAbonati();

            var persoana61 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Iargara,
                numartelefon = "51-3-15"
            };
            persoana61.AfisareAbonati();

            var persoana62 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Iargara,
                numartelefon = "51-3-15"
            };
            persoana62.AfisareAbonati();

            var persoana63 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Iargara,
                numartelefon = "51-3-15"
            };
            persoana63.AfisareAbonati();

            var persoana64 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Sarateni,
                numartelefon = "51-3-15"
            };
            persoana64.AfisareAbonati();

            var persoana65 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Sarateni,
                numartelefon = "51-3-15"
            };
            persoana65.AfisareAbonati();

            var persoana66 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Sarateni,
                numartelefon = "51-3-15"
            };
            persoana66.AfisareAbonati();

            var persoana67 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Troian,
                numartelefon = "51-3-15"
            };
            persoana67.AfisareAbonati();

            var persoana68 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Troian,
                numartelefon = "51-3-15"
            };
            persoana68.AfisareAbonati();

            var persoana69 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Troian,
                numartelefon = "51-3-15"
            };
            persoana69.AfisareAbonati();

            var persoana70 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Victoria,
                numartelefon = "51-3-15"
            };
            persoana70.AfisareAbonati();

            var persoana71 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Victoria,
                numartelefon = "51-3-15"
            };
            persoana71.AfisareAbonati();

            var persoana72 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Victoria,
                numartelefon = "51-3-15"
            };
            persoana72.AfisareAbonati();

            var persoana73 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Vozneseni,
                numartelefon = "51-3-15"
            };
            persoana73.AfisareAbonati();

            var persoana74 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Vozneseni,
                numartelefon = "51-3-15"
            };
            persoana74.AfisareAbonati();

            var persoana75 = new abonat
            {
                nume = " Gutu",
                prenume = "Ionela",
                codtara = CodTara._373,
                raion = Raion.Hincesti,
                codraion = CodRaion._0263,
                sat = Sate.Vozneseni,
                numartelefon = "51-3-15"
            };
            persoana75.AfisareAbonati();
        }
    }
}
