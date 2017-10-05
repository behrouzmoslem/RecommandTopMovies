using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using DomainClass;

namespace DataLayer
{
    public class ContextList : DbContext
    {
        static List<Person> _personList = new List<Person>();
        public ContextList() : base("OfferMovie")
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<UserMovie> UserMovieList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }





        public class MyCustomInitializer : DropCreateDatabaseIfModelChanges<ContextList>
        {
            protected override void Seed(ContextList context)
            {

                context.Movies.Add(new Movie { Id = 1, LatinName = "The Shawshank Redemption 1994", PersianName = "رستگاری در شائوشنگ 1994", Rate = 9.2, FirstDirector = TranslateToDirector("Frank", "Darabont", 1), Stars = new List<Star>() { TranslateToStar("Tim", "Robbins", 1), TranslateToStar("Morgan", "Freeman", 1) } });
                context.Movies.Add(new Movie { Id = 2, LatinName = "The Godfather 1972", PersianName = "پدرخوانده 1972", Rate = 9.2, FirstDirector = TranslateToDirector("Francis", " Ford Coppola", 1), Stars = new List<Star>() { TranslateToStar("Marlon", "Brando", 1), TranslateToStar("Al", "Pacino", 1), TranslateToStar("James", "Caan", 1) } });
                context.Movies.Add(new Movie { Id = 3, LatinName = "The Godfather: Part II 1974", PersianName = "پدرخوانده 2 1974", Rate = 9, FirstDirector = TranslateToDirector("Francis", " Ford Coppola", 1), Stars = new List<Star>() { TranslateToStar("Al", "Pacino", 1), TranslateToStar("Robert", " De Niro", 1), TranslateToStar("Robert", "Duvall", 1) } });
                //context.Movies.Add(new Movie { Id = 4, LatinName = "The Dark Knight 2008", PersianName = " 2008 شوالیه تاریکی", Rate = 8.9 });
                //context.Movies.Add(new Movie { Id = 5, LatinName = "Pulp Fiction 1994", PersianName = "داستان عامه پسند 1994", Rate = 8.9 });
                //context.Movies.Add(new Movie { Id = 6, LatinName = "The Good, the Bad and the Ugly 1966", PersianName = "خوب، بد، زشت 1966", Rate = 8.9 });
                //context.Movies.Add(new Movie { Id = 7, LatinName = "Schindler's List 1993", PersianName = " فهرست شیندلر 1993", Rate = 8.9 });
                //context.Movies.Add(new Movie { Id = 8, LatinName = "12 Angry Men 1957", PersianName = " دوازده مرد خشمگین 1957", Rate = 8.9 });
                //context.Movies.Add(new Movie { Id = 9, LatinName = "The Lord of the Rings: The Return of the King 2003", PersianName = " ارباب حلقه ها: بازگشت سلطان 2003", Rate = 8.9 });
                //context.Movies.Add(new Movie { Id = 10, LatinName = "Fight Club 1999", PersianName = "باشگاه مشت زنی 1999", Rate = 8.8 });
                //context.Movies.Add(new Movie { Id = 11, LatinName = "The Lord of the Rings: The Fellowship of the Ring 2001", PersianName = " ارباب حلقه ها: یاران حلقه 2001", Rate = 8.8 });
                //context.Movies.Add(new Movie { Id = 12, LatinName = "Star Wars: Episode V The Empire Strikes Back 1980", PersianName = " جنگ ستارگان: امپراتوری حمله را پاسخ می دهد 1980", Rate = 8.8 });
                //context.Movies.Add(new Movie { Id = 13, LatinName = "Inception 2010", PersianName = " تلقین 2010", Rate = 8.7 });
                //context.Movies.Add(new Movie { Id = 14, LatinName = "Forrest Gump 1994", PersianName = " فارست گامپ 1994", Rate = 8.7 });
                //context.Movies.Add(new Movie { Id = 15, LatinName = "One Flew Over the Cuckoo's Nest 1975", PersianName = " دیوانه ای از قفس پرید 1975", Rate = 8.7 });
                //context.Movies.Add(new Movie { Id = 16, LatinName = "Goodfellas 1990", PersianName = " رفقای خوب 1990", Rate = 8.7 });
                //context.Movies.Add(new Movie { Id = 17, LatinName = "The Lord of the Rings: The Two Towers 2002", PersianName = " ارباب حلقه ها: دو برج 2002", Rate = 8.7 });
                //context.Movies.Add(new Movie { Id = 18, LatinName = "Star Wars: Episode IV A New Hope 1977", PersianName = " جنگ ستارگان: امید تازه 1977", Rate = 8.7 });
                //context.Movies.Add(new Movie { Id = 19, LatinName = "The Matrix 1999", PersianName = "ماتریکس 1999", Rate = 8.7 });
                //context.Movies.Add(new Movie { Id = 20, LatinName = "Seven Samurai 1954", PersianName = " هفت سامورایی 1954", Rate = 8.7 });
                //context.Movies.Add(new Movie { Id = 21, LatinName = "City of God 2002", PersianName = " شهر خدا 2002", Rate = 8.7 });
                //context.Movies.Add(new Movie { Id = 22, LatinName = "Se7en 1995", PersianName = " هفت 1995", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 23, LatinName = "The Usual Suspects 1995", PersianName = " مظنونین همیشگی 1995", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 24, LatinName = "The Silence of the Lambs 1991", PersianName = " سکوت بره ها 1991", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 25, LatinName = "Once Upon a Time in the West 1968", PersianName = " روزی روزگاری در غرب 1968", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 26, LatinName = "It's a Wonderful Life 1946", PersianName = " چه زندگی شگفت انگیزی 1946", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 27, LatinName = "Léon: The Professional 1994", PersianName = " لئون: حرفه ای 1994", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 28, LatinName = "Casablanca 1942", PersianName = " کازابلانکا 1942", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 29, LatinName = "Life Is Beautiful 1997", PersianName = " زندگی زیباست 1997", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 30, LatinName = "Raiders of the Lost Ark 1981", PersianName = " مهاجمین صندوقچه گمشده 1981", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 31, LatinName = "Rear Window 1954", PersianName = " پنجره پشتی 1954", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 32, LatinName = "Psycho 1960", PersianName = " روانی 1960", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 33, LatinName = "American History X 1998", PersianName = " تاریخ مجهول آمریکا 1998", Rate = 8.6 });
                //context.Movies.Add(new Movie { Id = 34, LatinName = "City Lights 1931", PersianName = " روشنایی های شهر 1931", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 35, LatinName = "Saving Private Ryan 1998", PersianName = " نجات سرباز رایان 1998", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 36, LatinName = "Spirited Away 2001", PersianName = " شهر ارواح 2001", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 37, LatinName = "The Intouchables 2011", PersianName = " طرد شدگان 2011", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 38, LatinName = "Memento 2000", PersianName = " یادگاری 2000", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 39, LatinName = "Terminator 2: Judgment Day 1991", PersianName = " ترمیناتور 2: روز داوری 1991", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 40, LatinName = "Modern Times 1936", PersianName = " عصر جدید 1936", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 41, LatinName = "Sunset Blvd. 1950", PersianName = " سانست بولوار 1950", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 42, LatinName = "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb 1964", PersianName = " دکتر استرنج لاو 1964", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 43, LatinName = "Apocalypse Now 1979", PersianName = " اینک آخرالزمان 1979", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 44, LatinName = "The Pianist 2002", PersianName = " پیانیست 2002", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 45, LatinName = "The Green Mile 1999", PersianName = " مسیر سبز 1999", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 46, LatinName = "The Departed 2006", PersianName = " مردگان 2006", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 47, LatinName = "Gladiator 2000", PersianName = " گلادیاتور 2000", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 48, LatinName = "Back to the Future 1985", PersianName = " بازگشت به آینده 1985", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 49, LatinName = "The Dark Knight Rises 2012", PersianName = " شوالیه تاریکی بر می خیزد 2012", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 50, LatinName = "Alien 1979", PersianName = " بیگانه 1979", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 51, LatinName = "Django Unchained 2012", PersianName = " جانگوی رها از بند 2012", Rate = 8.5 });
                //context.Movies.Add(new Movie { Id = 52, LatinName = "The Lives of Others 2006", PersianName = " زندگی دیگران 2006", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 53, LatinName = "The Prestige 2006", PersianName = " پرستیژ 2006", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 54, LatinName = "The Great Dictator 1940", PersianName = " دیکتاتور بزرگ 1940", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 55, LatinName = "The Shining 1980", PersianName = " درخشش 1980", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 56, LatinName = "Cinema Paradiso 1988", PersianName = " سینما پارادیزو 1988", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 57, LatinName = "Paths of Glory 1957", PersianName = " راه های افتخار 1957", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 58, LatinName = "American Beauty 1999", PersianName = " زیبای آمریکایی 1999", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 59, LatinName = "The Lion King 1994", PersianName = " شیر شاه 1994", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 60, LatinName = "WALL·E 2008", PersianName = "وال ای 2008", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 61, LatinName = "North by Northwest 1959", PersianName = " شمال از شمال غربی 1959", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 62, LatinName = "Amelie 2001", PersianName = " آملی 2001", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 63, LatinName = "Citizen Kane 1941", PersianName = "همشهری کین 1941", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 64, LatinName = "Aliens 1986", PersianName = " بیگانگان 1986", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 65, LatinName = "Toy Story 3 2010", PersianName = " داستان اسباب بازی 3 2010", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 66, LatinName = "Vertigo 1958", PersianName = " سرگیجه 1958", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 67, LatinName = "M 1931", PersianName = " ام 1931", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 68, LatinName = "Das Boot 1981", PersianName = " زیردریایی 1981", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 69, LatinName = "Taxi Driver 1976", PersianName = " راننده تاکسی 1976", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 70, LatinName = "A Clockwork Orange 1971", PersianName = " پرتقال کوکی 1971", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 71, LatinName = "Double Indemnity 1944", PersianName = " غرامت مضاعف 1944", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 72, LatinName = "Oldboy 2003", PersianName = " رفیق قدیمی 2003", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 73, LatinName = "To Kill a Mockingbird 1962", PersianName = " کشتن مرغ مقلد 1962", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 74, LatinName = "Princess Mononoke 1997", PersianName = " پرنسس مونونوکه 1997", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 75, LatinName = "Reservoir Dogs 1992", PersianName = " سگ های انباری 1992", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 76, LatinName = "Requiem for a Dream 2000", PersianName = " مرثیه ای بر یک رویا 2000", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 77, LatinName = "Once Upon a Time in America 1984", PersianName = " روزی روزگاری در آمریکا 1984", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 78, LatinName = "Star Wars: Episode VI Return of the Jedi 1983", PersianName = " جنگ ستارگان: بازگشت جدای 1983", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 79, LatinName = "Braveheart 1995", PersianName = " شجاع دل 1995", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 80, LatinName = "Lawrence of Arabia 1962", PersianName = " لورنس عربستان 1962", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 81, LatinName = "Grave of the Fireflies 1988", PersianName = " مدفن کرم های شب تاب 1988", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 82, LatinName = "Eternal Sunshine of the Spotless Mind 2004", PersianName = " درخشش ابدی یک ذهن پاک 2004", Rate = 8.4 });
                //context.Movies.Add(new Movie { Id = 83, LatinName = "Witness for the Prosecution 1957", PersianName = " شاهدی برای تعقیب 1957", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 84, LatinName = "Full Metal Jacket 1987", PersianName = " غلاف تمام فلزی 1987", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 85, LatinName = "Singin' in the Rain 1952", PersianName = " آواز در باران 1952", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 86, LatinName = "The Sting 1973", PersianName = " نیش 1973", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 87, LatinName = "Bicycle Thieves 1948", PersianName = " دزد دوچرخه 1948", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 88, LatinName = "The Wolf of Wall Street 2013", PersianName = " گرگ وال استریت 2013", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 89, LatinName = "Monty Python and the Holy Grail 1975", PersianName = " مانتی پیتون و جام مقدس 1975", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 90, LatinName = "Amadeus 1984", PersianName = " آمادئوس 1984", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 91, LatinName = "All About Eve 1950", PersianName = " همه چیز درباره ایو 1950", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 92, LatinName = "Rashomon 1950", PersianName = " راشومون 1950", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 93, LatinName = "The Treasure of the Sierra Madre 1948", PersianName = " گنج های سیرا مادره 1948", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 94, LatinName = "Snatch. 2000", PersianName = " قاپ زنی 2000", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 95, LatinName = "L.A. Confidential 1997", PersianName = " محرمانه لس انجلس 1997", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 96, LatinName = "The Apartment 1960", PersianName = " آپارتمان 1960", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 97, LatinName = "Some Like It Hot 1959", PersianName = " بعضی ها داغشو دوست دارند 1959", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 98, LatinName = "The Third Man 1949", PersianName = " مرد سوم 1949", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 99, LatinName = "For a Few Dollars More 1965", PersianName = " به خاطر چند دلار بیشتر 1965", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 100, LatinName = "A Separation 2011", PersianName = " جدایی نادر از سیمین 2011", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 101, LatinName = "Inglourious Basterds 2009", PersianName = " حرامزاده های لعنتی 2009", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 102, LatinName = "Batman Begins 2005", PersianName = " بتمن آغاز می کند 2005", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 103, LatinName = "Yojimbo 1961", PersianName = " یوجیمبو 1961", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 104, LatinName = "The Kid 1921", PersianName = " پسر بچه 1921", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 105, LatinName = "2001: A Space Odyssey 1968", PersianName = " دو هزار و یک: یک ادیسه فضایی 1968", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 106, LatinName = "Unforgiven 1992", PersianName = " نابخشوده 1992", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 107, LatinName = "Metropolis 1927", PersianName = " متروپلیس 1927", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 108, LatinName = "Raging Bull 1980", PersianName = " گاو خشمگین 1980", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 109, LatinName = "Chinatown 1974", PersianName = " محله چینی ها 1974", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 110, LatinName = "Toy Story 1995", PersianName = " داستان اسباب بازی 1995", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 111, LatinName = "Scarface 1983", PersianName = " صورت زخمی 1983", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 112, LatinName = "Up 2009", PersianName = " بالا 2009", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 113, LatinName = "Die Hard 1988", PersianName = " جان سخت 1988", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 114, LatinName = "Downfall 2004", PersianName = " سقوط 2004", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 115, LatinName = "Mr. Smith Goes to Washington 1939", PersianName = " آقای اسمیت به واشنگتن می رود 1939", Rate = 8.3 });
                //context.Movies.Add(new Movie { Id = 116, LatinName = "The Great Escape 1963", PersianName = "فرار بزرگ 1963", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 117, LatinName = "Pan's Labyrinth 2006", PersianName = " هزار توی پن 2006", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 118, LatinName = "On the Waterfront 1954", PersianName = " در بار انداز 1954", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 119, LatinName = "Like Stars on Earth 2007", PersianName = " ستاره های روی زمین 2007", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 120, LatinName = "The Bridge on the River Kwai 1957", PersianName = " پل رودخانه کوای 1957", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 121, LatinName = "Heat 1995", PersianName = " مخمصه 1995", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 122, LatinName = "The Seventh Seal 1957", PersianName = " مهر هفتم 1957", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 123, LatinName = "Wild Strawberries 1957", PersianName = " توت فرنگی های وحشی 1957", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 124, LatinName = "The Elephant Man 1980", PersianName = " مرد فیل نما 1980", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 125, LatinName = "The General 1926", PersianName = " ژنرال 1926", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 126, LatinName = "Ran 1985", PersianName = " آشوب 1985", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 127, LatinName = "12 Years a Slave 12 2013", PersianName = "سال بردگی 2013", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 128, LatinName = "The Gold Rush 1925", PersianName = " جویندگان طلا 1925", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 129, LatinName = "Blade Runner 1982", PersianName = "بلید رانر 1982", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 130, LatinName = "My Neighbor Totoro 1988", PersianName = " همسایه ی من توتورو 1988", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 131, LatinName = "Lock, Stock and Two Smoking Barrels 1998", PersianName = " ضامن، قنداق و دو لوله تفنگ شلیک شده 1998", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 132, LatinName = "Gran Torino 2008", PersianName = "گرن تورینو 2008", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 133, LatinName = "Rebecca 1940", PersianName = " ربکا 1940", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 134, LatinName = "The Big Lebowski 1998", PersianName = " لبافسکی بزرگ 1998", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 135, LatinName = "The Secret in Their Eyes 2009", PersianName = " راز چشمهایشان 2009", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 136, LatinName = "It Happened One Night 1934", PersianName = " در یک شب اتفاق افتاد 1934", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 137, LatinName = "Rush 2013", PersianName = " شتاب 2013", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 138, LatinName = "Warrior 2011", PersianName = " مبارز 2011", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 139, LatinName = "Casino 1995", PersianName = " کازینو 1995", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 140, LatinName = "Her 2013", PersianName = " او 2013", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 141, LatinName = "Cool Hand Luke 1967", PersianName = " لوک خوش دست 1967", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 142, LatinName = "V for Vendetta 2005", PersianName = " ک مثل کین خواهی 2005", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 143, LatinName = "The Deer Hunter 1978", PersianName = " شکارچی گوزن 1978", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 144, LatinName = "The Maltese Falcon 1941", PersianName = " شاهین مالت 1941", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 145, LatinName = "Fargo 1996", PersianName = " فارگو 1996", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 146, LatinName = "Gone with the Wind 1939", PersianName = " بربادرفته 1939", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 147, LatinName = "Trainspotting 1996", PersianName = " قطاربازی 1996", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 148, LatinName = "Into the Wild 2007", PersianName = " به‌سوی طبیعت وحشی 2007", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 149, LatinName = "Howl's Moving Castle 2004", PersianName = " قلعه متحرک هاول 2004", Rate = 8.2 });
                //context.Movies.Add(new Movie { Id = 150, LatinName = "How to Train Your Dragon 2010", PersianName = " چگونه اژدهای خود را تربیت 2010", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 151, LatinName = "The Grand Budapest Hotel 2014", PersianName = " هتل بزرگ بوداپست 2014", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 152, LatinName = "Hotel Rwanda 2004", PersianName = " هتل رواندا 2004", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 153, LatinName = "Judgment at Nuremberg 1961", PersianName = " دادگاه نورنبرگ 1961", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 154, LatinName = "The Sixth Sense 1999", PersianName = " حس ششم 1999", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 155, LatinName = "Butch Cassidy and the Sundance Kid 1969", PersianName = " بوچ کسیدی و ساندنس کید 1969", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 156, LatinName = "The Thing 1982", PersianName = " موجود 1982", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 157, LatinName = "Annie Hall 1977", PersianName = " آنی هال 1977", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 158, LatinName = "Dial M for Murder 1954", PersianName = " ام را به نشانه مرگ بگیر 1954", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 159, LatinName = "Platoon 1986", PersianName = " جوخه 1986", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 160, LatinName = "A Beautiful Mind 2001", PersianName = " یک ذهن زیبا 2001", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 161, LatinName = "Kill Bill: Vol. 1 2003", PersianName = " بیل را بکش : قسمت اول 2003", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 162, LatinName = "No Country for Old Men 2007", PersianName = " جایی برای پیرمردها نیست 2007", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 163, LatinName = "Sin City 2005", PersianName = " شهر گناه 2005", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 164, LatinName = "Touch of Evil 1958", PersianName = " نشانی از شر 1958", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 165, LatinName = "Mary and Max 2009", PersianName = " مری و مکس 2009", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 166, LatinName = "Finding Nemo 2003", PersianName = " در جستجوی نمو 2003", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 167, LatinName = "Life of Brian 1979", PersianName = " زندگی برایان 1979", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 168, LatinName = "The Princess Bride 1987", PersianName = " عروس شاهزاده 1987", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 169, LatinName = "Amores Perros 2000", PersianName = " عشق سگی 2000", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 170, LatinName = "The Wizard of Oz 1939", PersianName = " جادوگر شهر از 1939", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 171, LatinName = "The Avengers 2012", PersianName = " انتقام جویان 2012", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 172, LatinName = "Stand by Me 1986", PersianName = " کنار من بمان 1986", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 173, LatinName = "The Lego Movie 2014", PersianName = " فیلم لگو 2014", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 174, LatinName = "Ben Hur 1959", PersianName = " بن هور 1959", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 175, LatinName = "The Grapes of Wrath 1940", PersianName = " 1940", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 176, LatinName = "The Best Years of Our Lives 1946", PersianName = " بهترین سالهای زندگی ما 1946", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 177, LatinName = "There Will Be Blood 2007", PersianName = " خون به پا خواهد شد 2007", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 178, LatinName = "Incendies 2010", PersianName = " سوختگان 2010", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 179, LatinName = "Million Dollar Baby 2004", PersianName = " دختر میلیون دلاری 2004", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 180, LatinName = "The 400 Blows 1959", PersianName = " چهارصد ضربه 1959", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 181, LatinName = "8½ 1963", PersianName = " هشت و نیم 1963", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 182, LatinName = "Gravity 2013", PersianName = " جاذبه 2013", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 183, LatinName = "Donnie Darko 2001", PersianName = " دانی دارکو 2001", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 184, LatinName = "Strangers on a Train 1951", PersianName = " بیگانگان در قطار 1951", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 185, LatinName = "The Bourne Ultimatum 2007", PersianName = " اولتیماتوم بورن 2007", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 186, LatinName = "In the Name of the Father 1993", PersianName = " به نام پدر 1993", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 187, LatinName = "High Noon 1952", PersianName = " نیمروز 1952", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 188, LatinName = "Gandhi 1982", PersianName = " گاندی 1982", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 189, LatinName = "Persona 1966", PersianName = " پرسونا 1966", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 190, LatinName = "Notorious 1946", PersianName = " بدنام 1946", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 191, LatinName = "The King's Speech 2010", PersianName = " سخنرانی پادشاه 2010", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 192, LatinName = "Infernal Affairs 2002", PersianName = " اعمال شیطانی 2002", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 193, LatinName = "Jaws 1975", PersianName = " آرواره ها 1975", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 194, LatinName = "Nausicaä of the Valley of the Wind 1984", PersianName = " نائوسیکا از دره ی باد 1984", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 195, LatinName = "Twelve Monkeys 1995", PersianName = " دوازده میمون 1995", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 196, LatinName = "Fanny and Alexander 1982", PersianName = " فانی و الکساندر 1982", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 197, LatinName = "La Strada 1954", PersianName = " جاده 1954", Rate = 8.1 });
                //context.Movies.Add(new Movie { Id = 198, LatinName = "The Terminator 1984", PersianName = " نابودگر 1984", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 199, LatinName = "The Night of the Hunter 1955", PersianName = " شب شکارچی 1955", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 200, LatinName = "Ip Man 2008", PersianName = " ایپ من 2008", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 201, LatinName = "Who's Afraid of Virginia Woolf? 1966", PersianName = "? چه کسی از ویرجینیا وولف می ترسد 1966", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 202, LatinName = "Stalker 1979", PersianName = "Stalker استاکر 1979", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 203, LatinName = "The Big Sleep 1946", PersianName = " خواب بزرگ 1946", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 204, LatinName = "Groundhog Day 1993", PersianName = " روز گراندهاگ 1993", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 205, LatinName = "Dog Day Afternoon 1975", PersianName = " بعد از ظهر سگی 1975", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 206, LatinName = "The Battle of Algiers 1966", PersianName = " نبرد الجزایر 1966", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 207, LatinName = "Rocky 1976", PersianName = " راکی 1976", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 208, LatinName = "Harry Potter and the Deathly Hallows: Part 2 2011", PersianName = " هری پاتر و یادگاران مرگ قسمت دوم 2011", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 209, LatinName = "La Haine 1995", PersianName = " نفرت 1995", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 210, LatinName = "Barry Lyndon 1975", PersianName = " بری لیندون 1975", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 211, LatinName = "Pirates of the Caribbean: The Curse of the Black Pearl 2003", PersianName = " دزدان دریایی کارائیب : نفرین مروارید سیاه 2003", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 212, LatinName = "Before Sunrise 1995", PersianName = " پیش از نیمه شب 1995", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 213, LatinName = "Shutter Island 2010", PersianName = " جزیره شاتر 2010", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 214, LatinName = "The Graduate 1967", PersianName = " فارغ التحصیل 1967", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 215, LatinName = "The Celebration 1998", PersianName = " جشن 1998", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 216, LatinName = "The Hustler 1961", PersianName = " بیلیارد باز 1961", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 217, LatinName = "Monsters, Inc. 2001", PersianName = " شرکت هیولاها 2001", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 218, LatinName = "Castle in the Sky 1986", PersianName = " قلعه ای در آسمان 1986", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 219, LatinName = "Memories of Murder 2003", PersianName = " خاطرات یک قتل 2003", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 220, LatinName = "Roman Holiday 1953", PersianName = " تعطیلات رومی 1953", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 221, LatinName = "Stalag 17 17 1953", PersianName = " بازداشتگاه شماره 17 1953", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 222, LatinName = "The Hobbit: The Desolation of Smaug 2013", PersianName = " هابیت ویرانی اسماگ 2013", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 223, LatinName = "In the Mood for Love 2000", PersianName = " در حال و هوای عشق 2000", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 224, LatinName = "The Help 2011", PersianName = " یاری 2011", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 225, LatinName = "A Fistful of Dollars 1964", PersianName = " به خاطر یه مشت دلار 1964", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 226, LatinName = "Slumdog Millionaire 2008", PersianName = " میلیونر زاغه نشین 2008", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 227, LatinName = "The Killing 1956", PersianName = " کشتن 1956", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 228, LatinName = "Rope 1948", PersianName = " طناب 1948", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 229, LatinName = "Black Swan 2010", PersianName = " قوی سیاه 2010", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 230, LatinName = "The Truman Show 1998", PersianName = " نمایش ترومن 1998", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 231, LatinName = "Three Colors: Red 1994", PersianName = " سه رنگ : قرمز 1994", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 232, LatinName = "The Diving Bell and the Butterfly 2007", PersianName = " زنگ شیرجه و پروانه 2007", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 233, LatinName = "La Dolce Vita 1960", PersianName = " زندگی شیرین 1960", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 234, LatinName = "Beauty and the Beast 1991", PersianName = " دیو و دلبر 1991", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 235, LatinName = "Star Trek 2009", PersianName = " سفرهای ستاره ای 2009", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 236, LatinName = "Prisoners 2013", PersianName = " زندانیان 2013", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 237, LatinName = "Spring, Summer, Fall, Winter … and Spring 2003", PersianName = " بهار تابستان .... 2003", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 238, LatinName = "Sleuth 1972", PersianName = " کارآگاه 1972", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 239, LatinName = "A Streetcar Named Desire 1951", PersianName = " تراموایی به نام هوس 1951", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 240, LatinName = "The Manchurian Candidate 1962", PersianName = " کاندیدای منچوری 1962", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 241, LatinName = "The Wild Bunch 1969", PersianName = " این گروه خشن 1969", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 242, LatinName = "Papiillon 1973", PersianName = " پاپیون 1973", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 243, LatinName = "Harvey 1950", PersianName = " هاروی 1950", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 244, LatinName = "Arsenic and Old Lace 1944", PersianName = " آرسنیک و تور کهنه 1944", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 245, LatinName = "The Man Who Shot Liberty Valance 1962", PersianName = " چه کسی لیبرتی والانس را کشت 1962", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 246, LatinName = "Ratatoullie 2007", PersianName = " راتاتویی 2007", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 247, LatinName = "Rain Man 1988", PersianName = " مرد بارانی 1988", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 248, LatinName = "Mystic River 2003", PersianName = " رودخانه مرموز 2003", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 249, LatinName = "Rosmary Baby 1968", PersianName = " بچه رزمری 1968", Rate = 8 });
                //context.Movies.Add(new Movie { Id = 250, LatinName = "Exorcist 1973", PersianName = " جن گیر 1973", Rate = 8 });
                //context.Database.ExecuteSqlCommand("CREATE NONCLUSTERED INDEX [NonClusteredLatinIndex] ON [Top].[Movie]" +
                //                                   "   (  [LatinName] ASC,  [Id] ASC, [PersianName] ASC, [Rate] ASC" +
                //                                   " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]"
                //                                   );

                base.Seed(context);

            }
            private static Director TranslateToDirector(string fn, string ln, int genderId)
            {
                return new Director() { Person = TranslateToPerson(fn, ln, genderId) };
            }

            private static Star TranslateToStar(string fn, string ln, int genderId)
            {
                return new Star() { Person = TranslateToPerson(fn, ln, genderId) };
            }

            private static Person TranslateToPerson(string fn, string ln, int genderId)
            {
                var oldRegisterPerson = _personList.FirstOrDefault(x => x.FirstName == fn && x.LastName == ln);
                if (oldRegisterPerson == null )
                {
                    var person = new Person() { FirstName = fn, LastName = ln, Gender = TranslateToGender(genderId) };
                    _personList.Add(person);
                    return person;
                }

                return null;


            }



            private static Gender TranslateToGender(int id)
            {
                return new Gender() { Id = id, Title = GetGenderType(id) };
            }

            private static string GetGenderType(int id)
            {
                if (id == (int)GenderType.Male)
                    return GenderType.Male.ToString();
                else if (id == (int)GenderType.Female)
                {
                    return GenderType.Female.ToString();
                }
                else
                {
                    return GenderType.NotRegister.ToString();
                }
            }


        }

    }
}