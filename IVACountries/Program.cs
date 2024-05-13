using System.Linq.Expressions;

namespace IVACountries
{
    internal class Program
    {
        // QUE CONSTE NO SE SI ERA ASI QUE QUERIA LOS DATOS - TRATE DE RESPETAR LA ISO DE LOS PAISES
        public static List<Country> Countries = new List<Country>()
            {
                new Country("Hungary","HU",0.27M),
                new Country("Croatia","HR",0.25M),
                new Country("Denmark","DK",0.25M),
                new Country("Norway","NO",0.25M),
                new Country("Sweden","SE",0.25M),
                new Country("Finland","FI",0.24M),
                new Country("Iceland","IS",0.24M),
                new Country("Romania","RO",0.24M),
                new Country("Greece","GR",0.23M),
                new Country("Ireland","IE",0.23M),
                new Country("Poland","PL",0.23M),
                new Country("Portugal","PT",0.23M),
                new Country("Italy","IT",0.22M),
                new Country("Uruguay","UY",0.22M),
                new Country("EU","EU",0.216M),
                new Country("Argentina","AR",0.21M),
                new Country("Belgium","BE",0.21M),
                new Country("Netherlands","NL",0.21M),
                new Country("Spain","ES",0.21M),
                new Country("France","FR",0.2M),
                new Country("Morocco","MA",0.2M),
                new Country("United Kingdom","GB",0.2M),
                new Country("Chile","CL",0.19M),
                new Country("Germany","DE",0.19M),
                new Country("Brazil","BR",0.17M),
                new Country("Peru","PE",0.18M),
                new Country("Republica Dominicana","DO",0.18M),
                new Country("Russia","RU",0.18M),
                new Country("China","CN",0.17M),
                new Country("Mexico","MX",0.16M),
                new Country("Colombia","CO",0.16M),
                new Country("Honduras","HN",0.15M),
                new Country("Nicaragua","NI",0.15M),
                new Country("India","IN",0.15M),
                new Country("South Africa","ZA",0.14M),
                new Country("Bolivia","BO",0.13M),
                new Country("Costa Rica","CR",0.13M),
                new Country("El Salvador","SV",0.13M),
                new Country("Ecuador","EC",0.12M),
                new Country("Guatemala","GT",0.12M),
                new Country("Venezuela","VE",0.12M),
                new Country("Puerto Rico","PR",0.115M),
                new Country("Australia","AU",0.1M),
                new Country("South Korea","KR",0.1M),
                new Country("Paraguay","PY",0.1M),
                new Country("Japan","JP",0.08M),
                new Country("Switzerland","CH",0.08M),
                new Country("Panama","PA",0.07M),
                new Country("Canada","CA",0.05M),
                new Country("USA","US",0.117M)
            };
        

        public static bool FindCountry(string countryCode, out Country? countryCallback)
        {
            countryCallback = Countries.Find(x => x.CountryCode.ToLower() == countryCode.ToLower()) ?? null;
            if (countryCallback == null)
            {
                return false;
            }
            return true;
        } 

        static void Main()
        {
            Console.Write("Ingresa el codigo del pais: ");
            string countryCode = Console.ReadLine() ?? "";
            Console.Write("Ingresa el monto: ");
            if (!decimal.TryParse(Console.ReadLine() ?? "0", out decimal mount))
            {
                Console.WriteLine("Error en conversion");
            }
            
            Console.Clear();

            if (FindCountry(countryCode, out Country? countrySelected))
            {
                Console.WriteLine($"Pais seleccionado: {countrySelected?.CountryName} \nCodigo del pais: {countrySelected?.CountryCode}");
                Console.WriteLine($"IVA%: {countrySelected?.IVA * 100}% \nPrecio Final: {(countrySelected?.IVA * mount) + mount}");
                Console.WriteLine($"IVA: {countrySelected?.IVA * mount}");
            }
            else
            {
                Console.WriteLine("Pais no encontrado");
            }
        }

    }

    public class Country
    {
        
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public decimal IVA {  get; set; }

        public Country(string _countryName, string _countryCode, decimal _iva)
        {
            CountryName = _countryName;
            CountryCode= _countryCode;
            IVA= _iva;
        }
    }
}
