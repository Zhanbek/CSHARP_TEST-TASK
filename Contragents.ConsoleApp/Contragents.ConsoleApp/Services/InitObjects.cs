using Contragents.ConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace Contragents.ConsoleApp.Services
{
    public class InitObjects {
        // Создадим список физ. лиц
        static Person Ismagulov = new Person("670301100200", "Астана, улица Букейханова, 67", "Кокшетау, улица Пушкина, 12", DateTime.Now,
                                        "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                        "Bazarhan", "Ismagulov", "Gadletovich", "M", new DateTime(1967, 3, 1));
        static Person Ismagulova = new Person("640101123435", "Астана, улица Мандельштама, 167", "Кызылорда, улица Гоголя, 54", DateTime.Now,
                                        "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                        "Balzhan", "Ismagulova", "Gadletovna", "F", new DateTime(1964, 1, 1));
        static Person Bokebayeva = new Person("740201177777", "Астана, улица Менделеева, 168", "Кызылорда, улица Гегеля, 54", DateTime.Now,
                                        "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                        "Karlygash", "Bokebayeva", "Ganievna", "F", new DateTime(1974, 2, 1));
        static Person Avenisyan = new Person("840201155555", "Астана, улица Чуковского, 369", "Жамбыл, улица Жумабаева, 74", DateTime.Now,
                                        "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                        "Karen", "Samvelovich", "Avenisyan", "M", new DateTime(1984, 2, 1));
        static Person Tengebayev = new Person("940201144444", "Астана, улица Чайковского, 369", "Алматы, улица Абая, 84", DateTime.Now,
                                        "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                        "Mels", "Serikovich", "Tengebayev", "M", new DateTime(1984, 2, 1));
        static Person Erikova = new Person("840201111111", "Астана, улица Кастеева, 149", "Кызылорда, улица Магомаева, 174", DateTime.Now,
                                        "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                        "ArdakC", "Maratovna", "Erikova", "F", new DateTime(1984, 2, 1));
       
        // Создадим списки директоров для юр. лиц
        static Person Auezov = new Person("640201144444", "Астана, улица Шевченко, 149", "Алматы, улица М. Озтюрка, 14", DateTime.Now,
                                "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                "Argyn", "Magzhanovich", "Auezov", "M", new DateTime(1964, 2, 1));

        static Person Dzhakishev = new Person("610201144444", "Астана, улица Шевченко, 200", "Алматы, улица Желтоксан, 34", DateTime.Now,
                        "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                        "Muhtar", "Erkinovich", "Dzhakishev", "M", new DateTime(1961, 12, 11));


        // Создадим списки контактов для юр. лиц
        static Person Baryshnikov = new Person("640201133333", "Астана, улица Мохнаткина, 155", "Алматы, улица Т.Озала, 214", DateTime.Now,
                                "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                "Aleksey", "Baryshnikov", "Makarovich", "M", new DateTime(1954, 2, 5));

        static Person Vasilevskaya = new Person("840201145333", "Астана, проспект Независимости, 555", "Алматы, улица Курмангазы, 453", DateTime.Now,
                                "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                "Marta", "Vasilevskaya", "Vsevolodovna", "F", new DateTime(1976, 9, 9));

        static Person Makarova = new Person("840201145567", "Астана, проспект Сахарова, 45", "Алматы, улица Кабанбай батыра, 114", DateTime.Now,
                        "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                        "Mariya", "Makarova", "Vyacheslavovna", "F", new DateTime(1986, 8, 12));

        static Person Rozhdestvenskaya = new Person("700412145333", "Астана, улица Пушкина, 27", "Алматы, улица Богенбай батыра, 23", DateTime.Now,
                "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                "Marfa", "Rozhdestvenskaya", "Vasilievna", "F", new DateTime(1970, 4, 12));

        static Person Bastrykyan = new Person("800221145333", "Астана, улица К. Цеткин, 43", "Алматы, улица Кобланды батыра, 123", DateTime.Now,
                                              "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                              "Peter", "Bastrykyan", "Makarovich", "M", new DateTime(1980, 2, 21));

        static Person Patrushev = new Person("500312145333", "Астана, улица Жамбыла, 38", "Алматы, улица Наурызбай батыра, 123", DateTime.Now,
                                              "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                              "Fedor", "Patrushev", "Platonovich", "M", new DateTime(1950, 3, 12));

        static Person Petrov = new Person("751121345333", "Астана, улица Каримова, 54", "Алматы, улица Шукшина, 43", DateTime.Now,
                                      "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                      "Vasiliy", "Petrov", "Alekseevich", "M", new DateTime(1975, 11, 21));

        static Person Boshyrov = new Person("781011245333", "Астана, улица Жамбыла, 89", "Алматы, ул. Саина, 123", DateTime.Now,
                                              "Sarsenov Zhanbek Bolganbayevich", DateTime.Now, "Sarsenov Zhanbek Bolganbayevich",
                                              "Alexey", "Boshyrov", "Alexeevich", "M", new DateTime(1978, 10, 12));

        public List<Contragent> personsList = new List<Contragent>()
        {
            Ismagulov, Ismagulova, Bokebayeva, Avenisyan, Tengebayev, Erikova,
            Auezov, Dzhakishev,
            Baryshnikov, Vasilevskaya, Makarova, Rozhdestvenskaya, Bastrykyan, Patrushev, Petrov, Boshyrov
        };


        public static List<Person> firstContactsList = new List<Person>()
        {
            Bastrykyan, Patrushev, Petrov, Boshyrov
        };

        public static List<Person> secondContactsList = new List<Person>()
        {
            Vasilevskaya, Bastrykyan, Patrushev, Petrov, Boshyrov
        };

        public static List<Person> thirdContactsList = new List<Person>()
        {
            Vasilevskaya, Boshyrov
        };

        public static List<Person> fourthContactsList = new List<Person>()
        {
            Vasilevskaya, Boshyrov, Baryshnikov
        };

        public static List<Person> fifthContactsList = new List<Person>()
        {
            Vasilevskaya, Boshyrov, Baryshnikov, Auezov
        };

        public static List<Person> sixthContactsList = new List<Person>()
        {
            Vasilevskaya, Boshyrov, Baryshnikov, Auezov, Makarova,
            Bastrykyan, Patrushev, Petrov
        };

        public static Company KazakstanTemirZholy = new Company("123456789012", "Астана, улица Строителей 12, офис 123", "Астана, улица Букейханова, 100, офис 450",
                                                DateTime.Now, "AISAdmin", DateTime.Now, "AISAdmin", "KazakhstanTemirZholy", Auezov, 
                                                new DateTime(1993, 3, 1, 7, 0, 0), firstContactsList);

        public static Company KazAtomProm = new Company("123456755555", "Астана, улица Строителей 56, офис 111", "Кызылорда, улица Букейханова, 130, офис 20",
                                                        DateTime.Now, "AISAdmin", DateTime.Now, "AISAdmin", "KazAtomProm", Dzhakishev,
                                                        new DateTime(1993, 3, 1, 17, 0, 0), fourthContactsList);

        public static Company KazAvtoZhol = new Company("123123123123", "Астана, улица Циолковского 126, офис 111", "Кызылорда, улица Чайковского, 30, офис 150",
                                                DateTime.Now, "AISAdmin", DateTime.Now, "AISAdmin", "KazAvtoZholy", Rozhdestvenskaya,
                                                new DateTime(1992, 5, 4, 12, 0, 0), thirdContactsList);

        public static Company Kazakhtelecom = new Company("123123123456", "Астана, улица Кунаева 154, офис 111", "Жамбыл, улица Мандельштама, 12, офис 15",
                                        DateTime.Now, "AISAdmin", DateTime.Now, "AISAdmin", "KazakhTeleCom", Bastrykyan,
                                        new DateTime(1994, 3, 1, 14, 0, 0), fifthContactsList);

        public static Company KazPost = new Company("123123123765", "Астана, улица Марата, офис 32", "Жамбыл, улица Есенина, 76, офис 35",
                                DateTime.Now, "AISAdmin", DateTime.Now, "AISAdmin", "KazPost", Makarova,
                                new DateTime(1992, 6, 21, 15, 0, 0), sixthContactsList);

        public static Company Kcell = new Company("543123123765", "Алматы, улица Озала Т., офис 32", "Кокшетау, улица Гагарина, 36, офис 43",
                        DateTime.Now, "AISAdmin", DateTime.Now, "AISAdmin", "KCell", Petrov,
                        new DateTime(1993, 9, 23, 16, 0, 0), secondContactsList);

        public static Company Tele2 = new Company("556123123765", "Алматы, улица Гоголя., офис 654", "Павлодар, улица Алматинская, 43, офис 23",
                        DateTime.Now, "AISAdmin", DateTime.Now, "AISAdmin", "Tele2", Boshyrov,
                        new DateTime(1993, 9, 23, 16, 0, 0), thirdContactsList);

        public static Company Beeline = new Company("777123123765", "Алматы, улица Пушкина, офис 12", "Петропавловсе, улица Столичная, 123, офис 32",
                DateTime.Now, "AISAdmin", DateTime.Now, "AISAdmin", "Beeline", Vasilevskaya,
                new DateTime(1993, 9, 23, 16, 0, 0), sixthContactsList);

        public List<Contragent> companiesList = new List<Contragent>()
        {
            KazakstanTemirZholy, KazAtomProm, KazAvtoZhol, Kazakhtelecom, KazPost, Kcell, Tele2, Beeline
        };
    }
}
