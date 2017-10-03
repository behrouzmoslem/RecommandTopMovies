using System.Data.Entity;
using DomainClass;

namespace DataLayer
{
    public class ContextList  : DbContext
    {
        public ContextList():base("RecommendTopMovies")
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMovie> UserMovieList { get; set; }



        public class MyCustomInitializer : DropCreateDatabaseIfModelChanges<ContextList>
        {
            protected override void Seed(ContextList context)
            {
               
                context.Movies.Add(new Movie { Id = 1, LatinName = "The Shawshank Redemption (رستگاری در شائوشنگ) - 1994", PersianName = "The Shawshank Redemption (رستگاری در شائوشنگ) - 1994", Rate = 9.2 });
                context.Movies.Add(new Movie { Id = 2, LatinName = "The Godfather (پدرخوانده) - 1972", PersianName = "The Godfather (پدرخوانده) - 1972", Rate = 9.2 });
                context.Movies.Add(new Movie { Id = 3, LatinName = "The Godfather: Part II (پدرخوانده 2) - 1974", PersianName = "The Godfather: Part II (پدرخوانده 2) - 1974", Rate = 9 });
                context.Movies.Add(new Movie { Id = 4, LatinName = "The Dark Knight (شوالیه تاریکی) - 2008", PersianName = "The Dark Knight (شوالیه تاریکی) - 2008", Rate = 8.9 });
                context.Movies.Add(new Movie { Id = 5, LatinName = "Pulp Fiction (داستان عامه پسند) - 1994", PersianName = "Pulp Fiction (داستان عامه پسند) - 1994", Rate = 8.9 });
                context.Movies.Add(new Movie { Id = 6, LatinName = "The Good, the Bad and the Ugly (خوب، بد، زشت) - 1966", PersianName = "The Good, the Bad and the Ugly (خوب، بد، زشت) - 1966", Rate = 8.9 });
                context.Movies.Add(new Movie { Id = 7, LatinName = "Schindler's List (فهرست شیندلر) - 1993", PersianName = "Schindler's List (فهرست شیندلر) - 1993", Rate = 8.9 });
                context.Movies.Add(new Movie { Id = 8, LatinName = "12 Angry Men (دوازده مرد خشمگین) - 1957", PersianName = "12 Angry Men (دوازده مرد خشمگین) - 1957", Rate = 8.9 });
                context.Movies.Add(new Movie { Id = 9, LatinName = "The Lord of the Rings: The Return of the King (ارباب حلقه ها: بازگشت سلطان) - 2003", PersianName = "The Lord of the Rings: The Return of the King (ارباب حلقه ها: بازگشت سلطان) - 2003", Rate = 8.9 });
                context.Movies.Add(new Movie { Id = 10, LatinName = "Fight Club (باشگاه مشت زنی) - 1999", PersianName = "Fight Club (باشگاه مشت زنی) - 1999", Rate = 8.8 });
                context.Movies.Add(new Movie { Id = 11, LatinName = "The Lord of the Rings: The Fellowship of the Ring (ارباب حلقه ها: یاران حلقه) - 2001", PersianName = "The Lord of the Rings: The Fellowship of the Ring (ارباب حلقه ها: یاران حلقه) - 2001", Rate = 8.8 });
                context.Movies.Add(new Movie { Id = 12, LatinName = "Star Wars: Episode V - The Empire Strikes Back (جنگ ستارگان: امپراتوری حمله را پاسخ می دهد) - 1980", PersianName = "Star Wars: Episode V - The Empire Strikes Back (جنگ ستارگان: امپراتوری حمله را پاسخ می دهد) - 1980", Rate = 8.8 });
                context.Movies.Add(new Movie { Id = 13, LatinName = "Inception (تلقین) - 2010", PersianName = "Inception (تلقین) - 2010", Rate = 8.7 });
                context.Movies.Add(new Movie { Id = 14, LatinName = "Forrest Gump (فارست گامپ) - 1994", PersianName = "Forrest Gump (فارست گامپ) - 1994", Rate = 8.7 });
                context.Movies.Add(new Movie { Id = 15, LatinName = "One Flew Over the Cuckoo's Nest (دیوانه ای از قفس پرید) - 1975", PersianName = "One Flew Over the Cuckoo's Nest (دیوانه ای از قفس پرید) - 1975", Rate = 8.7 });
                context.Movies.Add(new Movie { Id = 16, LatinName = "Goodfellas (رفقای خوب) - 1990", PersianName = "Goodfellas (رفقای خوب) - 1990", Rate = 8.7 });
                context.Movies.Add(new Movie { Id = 17, LatinName = "The Lord of the Rings: The Two Towers (ارباب حلقه ها: دو برج) - 2002", PersianName = "The Lord of the Rings: The Two Towers (ارباب حلقه ها: دو برج) - 2002", Rate = 8.7 });
                context.Movies.Add(new Movie { Id = 18, LatinName = "Star Wars: Episode IV - A New Hope (جنگ ستارگان: امید تازه) - 1977", PersianName = "Star Wars: Episode IV - A New Hope (جنگ ستارگان: امید تازه) - 1977", Rate = 8.7 });
                context.Movies.Add(new Movie { Id = 19, LatinName = "The Matrix (ماتریکس) - 1999", PersianName = "The Matrix (ماتریکس) - 1999", Rate = 8.7 });
                context.Movies.Add(new Movie { Id = 20, LatinName = "Seven Samurai (هفت سامورایی) - 1954", PersianName = "Seven Samurai (هفت سامورایی) - 1954", Rate = 8.7 });
                context.Movies.Add(new Movie { Id = 21, LatinName = "City of God (شهر خدا) - 2002", PersianName = "City of God (شهر خدا) - 2002", Rate = 8.7 });
                context.Movies.Add(new Movie { Id = 22, LatinName = "Se7en (هفت) - 1995", PersianName = "Se7en (هفت) - 1995", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 23, LatinName = "The Usual Suspects (مظنونین همیشگی) - 1995", PersianName = "The Usual Suspects (مظنونین همیشگی) - 1995", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 24, LatinName = "The Silence of the Lambs (سکوت بره ها) - 1991", PersianName = "The Silence of the Lambs (سکوت بره ها) - 1991", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 25, LatinName = "Once Upon a Time in the West (روزی روزگاری در غرب) - 1968", PersianName = "Once Upon a Time in the West (روزی روزگاری در غرب) - 1968", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 26, LatinName = "It's a Wonderful Life (چه زندگی شگفت انگیزی) - 1946", PersianName = "It's a Wonderful Life (چه زندگی شگفت انگیزی) - 1946", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 27, LatinName = "Léon: The Professional (لئون: حرفه ای) - 1994", PersianName = "Léon: The Professional (لئون: حرفه ای) - 1994", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 28, LatinName = "Casablanca (کازابلانکا) - 1942", PersianName = "Casablanca (کازابلانکا) - 1942", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 29, LatinName = "Life Is Beautiful (زندگی زیباست) - 1997", PersianName = "Life Is Beautiful (زندگی زیباست) - 1997", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 30, LatinName = "Raiders of the Lost Ark (مهاجمین صندوقچه گمشده) - 1981", PersianName = "Raiders of the Lost Ark (مهاجمین صندوقچه گمشده) - 1981", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 31, LatinName = "Rear Window (پنجره پشتی) - 1954", PersianName = "Rear Window (پنجره پشتی) - 1954", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 32, LatinName = "Psycho (روانی) - 1960", PersianName = "Psycho (روانی) - 1960", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 33, LatinName = "American History X (تاریخ مجهول آمریکا) - 1998", PersianName = "American History X (تاریخ مجهول آمریکا) - 1998", Rate = 8.6 });
                context.Movies.Add(new Movie { Id = 34, LatinName = "City Lights (روشنایی های شهر) - 1931", PersianName = "City Lights (روشنایی های شهر) - 1931", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 35, LatinName = "Saving Private Ryan (نجات سرباز رایان) - 1998", PersianName = "Saving Private Ryan (نجات سرباز رایان) - 1998", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 36, LatinName = "Spirited Away (شهر ارواح) - 2001", PersianName = "Spirited Away (شهر ارواح) - 2001", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 37, LatinName = "The Intouchables (طرد شدگان) - 2011", PersianName = "The Intouchables (طرد شدگان) - 2011", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 38, LatinName = "Memento (یادگاری) - 2000", PersianName = "Memento (یادگاری) - 2000", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 39, LatinName = "Terminator 2: Judgment Day (ترمیناتور 2: روز داوری) - 1991", PersianName = "Terminator 2: Judgment Day (ترمیناتور 2: روز داوری) - 1991", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 40, LatinName = "Modern Times (عصر جدید) - 1936", PersianName = "Modern Times (عصر جدید) - 1936", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 41, LatinName = "Sunset Blvd. (سانست بولوار) - 1950", PersianName = "Sunset Blvd. (سانست بولوار) - 1950", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 42, LatinName = "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb (دکتر استرنج لاو) - 1964", PersianName = "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb (دکتر استرنج لاو) - 1964", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 43, LatinName = "Apocalypse Now (اینک آخرالزمان) - 1979", PersianName = "Apocalypse Now (اینک آخرالزمان) - 1979", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 44, LatinName = "The Pianist (پیانیست) - 2002", PersianName = "The Pianist (پیانیست) - 2002", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 45, LatinName = "The Green Mile (مسیر سبز) - 1999", PersianName = "The Green Mile (مسیر سبز) - 1999", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 46, LatinName = "The Departed (مردگان) - 2006", PersianName = "The Departed (مردگان) - 2006", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 47, LatinName = "Gladiator (گلادیاتور) - 2000", PersianName = "Gladiator (گلادیاتور) - 2000", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 48, LatinName = "Back to the Future (بازگشت به آینده) - 1985", PersianName = "Back to the Future (بازگشت به آینده) - 1985", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 49, LatinName = "The Dark Knight Rises (شوالیه تاریکی بر می خیزد) - 2012", PersianName = "The Dark Knight Rises (شوالیه تاریکی بر می خیزد) - 2012", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 50, LatinName = "Alien (بیگانه) - 1979", PersianName = "Alien (بیگانه) - 1979", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 51, LatinName = "Django Unchained (جانگوی رها از بند) - 2012", PersianName = "Django Unchained (جانگوی رها از بند) - 2012", Rate = 8.5 });
                context.Movies.Add(new Movie { Id = 52, LatinName = "The Lives of Others (زندگی دیگران) - 2006", PersianName = "The Lives of Others (زندگی دیگران) - 2006", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 53, LatinName = "The Prestige (پرستیژ) - 2006", PersianName = "The Prestige (پرستیژ) - 2006", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 54, LatinName = "The Great Dictator (دیکتاتور بزرگ) - 1940", PersianName = "The Great Dictator (دیکتاتور بزرگ) - 1940", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 55, LatinName = "The Shining (درخشش) - 1980", PersianName = "The Shining (درخشش) - 1980", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 56, LatinName = "Cinema Paradiso (سینما پارادیزو) - 1988", PersianName = "Cinema Paradiso (سینما پارادیزو) - 1988", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 57, LatinName = "Paths of Glory (راه های افتخار) - 1957", PersianName = "Paths of Glory (راه های افتخار) - 1957", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 58, LatinName = "American Beauty (زیبای آمریکایی) - 1999", PersianName = "American Beauty (زیبای آمریکایی) - 1999", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 59, LatinName = "The Lion King (شیر شاه) - 1994", PersianName = "The Lion King (شیر شاه) - 1994", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 60, LatinName = "WALL·E (وال ای) - 2008", PersianName = "WALL·E (وال ای) - 2008", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 61, LatinName = "North by Northwest (شمال از شمال غربی) - 1959", PersianName = "North by Northwest (شمال از شمال غربی) - 1959", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 62, LatinName = "Amélie (آملی) - 2001", PersianName = "Amélie (آملی) - 2001", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 63, LatinName = "Citizen Kane (همشهری کین) - 1941", PersianName = "Citizen Kane (همشهری کین) - 1941", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 64, LatinName = "Aliens (بیگانگان) - 1986", PersianName = "Aliens (بیگانگان) - 1986", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 65, LatinName = "Toy Story 3 (داستان اسباب بازی 3) - 2010", PersianName = "Toy Story 3 (داستان اسباب بازی 3) - 2010", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 66, LatinName = "Vertigo (سرگیجه) - 1958", PersianName = "Vertigo (سرگیجه) - 1958", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 67, LatinName = "M (ام) - 1931", PersianName = "M (ام) - 1931", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 68, LatinName = "Das Boot (زیردریایی) - 1981", PersianName = "Das Boot (زیردریایی) - 1981", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 69, LatinName = "Taxi Driver (راننده تاکسی) - 1976", PersianName = "Taxi Driver (راننده تاکسی) - 1976", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 70, LatinName = "A Clockwork Orange (پرتقال کوکی) - 1971", PersianName = "A Clockwork Orange (پرتقال کوکی) - 1971", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 71, LatinName = "Double Indemnity (غرامت مضاعف) - 1944", PersianName = "Double Indemnity (غرامت مضاعف) - 1944", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 72, LatinName = "Oldboy (رفیق قدیمی) - 2003", PersianName = "Oldboy (رفیق قدیمی) - 2003", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 73, LatinName = "To Kill a Mockingbird (کشتن مرغ مقلد) - 1962", PersianName = "To Kill a Mockingbird (کشتن مرغ مقلد) - 1962", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 74, LatinName = "Princess Mononoke (پرنسس مونونوکه) - 1997", PersianName = "Princess Mononoke (پرنسس مونونوکه) - 1997", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 75, LatinName = "Reservoir Dogs (سگ های انباری) - 1992", PersianName = "Reservoir Dogs (سگ های انباری) - 1992", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 76, LatinName = "Requiem for a Dream (مرثیه ای بر یک رویا) - 2000", PersianName = "Requiem for a Dream (مرثیه ای بر یک رویا) - 2000", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 77, LatinName = "Once Upon a Time in America (روزی روزگاری در آمریکا) - 1984", PersianName = "Once Upon a Time in America (روزی روزگاری در آمریکا) - 1984", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 78, LatinName = "Star Wars: Episode VI - Return of the Jedi (جنگ ستارگان: بازگشت جدای) - 1983", PersianName = "Star Wars: Episode VI - Return of the Jedi (جنگ ستارگان: بازگشت جدای) - 1983", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 79, LatinName = "Braveheart (شجاع دل) - 1995", PersianName = "Braveheart (شجاع دل) - 1995", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 80, LatinName = "Lawrence of Arabia (لورنس عربستان) - 1962", PersianName = "Lawrence of Arabia (لورنس عربستان) - 1962", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 81, LatinName = "Grave of the Fireflies (مدفن کرم های شب تاب) - 1988", PersianName = "Grave of the Fireflies (مدفن کرم های شب تاب) - 1988", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 82, LatinName = "Eternal Sunshine of the Spotless Mind (درخشش ابدی یک ذهن پاک) - 2004", PersianName = "Eternal Sunshine of the Spotless Mind (درخشش ابدی یک ذهن پاک) - 2004", Rate = 8.4 });
                context.Movies.Add(new Movie { Id = 83, LatinName = "Witness for the Prosecution (شاهدی برای تعقیب) - 1957", PersianName = "Witness for the Prosecution (شاهدی برای تعقیب) - 1957", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 84, LatinName = "Full Metal Jacket (غلاف تمام فلزی) - 1987", PersianName = "Full Metal Jacket (غلاف تمام فلزی) - 1987", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 85, LatinName = "Singin' in the Rain (آواز در باران) - 1952", PersianName = "Singin' in the Rain (آواز در باران) - 1952", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 86, LatinName = "The Sting (نیش) - 1973", PersianName = "The Sting (نیش) - 1973", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 87, LatinName = "Bicycle Thieves (دزد دوچرخه) - 1948", PersianName = "Bicycle Thieves (دزد دوچرخه) - 1948", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 88, LatinName = "The Wolf of Wall Street (گرگ وال استریت) - 2013", PersianName = "The Wolf of Wall Street (گرگ وال استریت) - 2013", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 89, LatinName = "Monty Python and the Holy Grail (مانتی پیتون و جام مقدس) - 1975", PersianName = "Monty Python and the Holy Grail (مانتی پیتون و جام مقدس) - 1975", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 90, LatinName = "Amadeus (آمادئوس) - 1984", PersianName = "Amadeus (آمادئوس) - 1984", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 91, LatinName = "All About Eve (همه چیز درباره ایو) - 1950", PersianName = "All About Eve (همه چیز درباره ایو) - 1950", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 92, LatinName = "Rashomon (راشومون) - 1950", PersianName = "Rashomon (راشومون) - 1950", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 93, LatinName = "The Treasure of the Sierra Madre (گنج های سیرا مادره) - 1948", PersianName = "The Treasure of the Sierra Madre (گنج های سیرا مادره) - 1948", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 94, LatinName = "Snatch. (قاپ زنی) - 2000", PersianName = "Snatch. (قاپ زنی) - 2000", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 95, LatinName = "L.A. Confidential (محرمانه لس انجلس) - 1997", PersianName = "L.A. Confidential (محرمانه لس انجلس) - 1997", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 96, LatinName = "The Apartment (آپارتمان) - 1960", PersianName = "The Apartment (آپارتمان) - 1960", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 97, LatinName = "Some Like It Hot (بعضی ها داغشو دوست دارند) - 1959", PersianName = "Some Like It Hot (بعضی ها داغشو دوست دارند) - 1959", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 98, LatinName = "The Third Man (مرد سوم) - 1949", PersianName = "The Third Man (مرد سوم) - 1949", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 99, LatinName = "For a Few Dollars More (به خاطر چند دلار بیشتر) - 1965", PersianName = "For a Few Dollars More (به خاطر چند دلار بیشتر) - 1965", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 100, LatinName = "A Separation (جدایی نادر از سیمین) - 2011", PersianName = "A Separation (جدایی نادر از سیمین) - 2011", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 101, LatinName = "Inglourious Basterds (حرامزاده های لعنتی) - 2009", PersianName = "Inglourious Basterds (حرامزاده های لعنتی) - 2009", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 102, LatinName = "Batman Begins (بتمن آغاز می کند) - 2005", PersianName = "Batman Begins (بتمن آغاز می کند) - 2005", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 103, LatinName = "Yojimbo (یوجیمبو) - 1961", PersianName = "Yojimbo (یوجیمبو) - 1961", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 104, LatinName = "The Kid (پسر بچه) - 1921", PersianName = "The Kid (پسر بچه) - 1921", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 105, LatinName = "2001: A Space Odyssey (دو هزار و یک: یک ادیسه فضایی) - 1968", PersianName = "2001: A Space Odyssey (دو هزار و یک: یک ادیسه فضایی) - 1968", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 106, LatinName = "Unforgiven (نابخشوده) - 1992", PersianName = "Unforgiven (نابخشوده) - 1992", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 107, LatinName = "Metropolis (متروپلیس) - 1927", PersianName = "Metropolis (متروپلیس) - 1927", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 108, LatinName = "Raging Bull (گاو خشمگین) - 1980", PersianName = "Raging Bull (گاو خشمگین) - 1980", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 109, LatinName = "Chinatown (محله چینی ها) - 1974", PersianName = "Chinatown (محله چینی ها) - 1974", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 110, LatinName = "Toy Story (داستان اسباب بازی) - 1995", PersianName = "Toy Story (داستان اسباب بازی) - 1995", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 111, LatinName = "Scarface (صورت زخمی) - 1983", PersianName = "Scarface (صورت زخمی) - 1983", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 112, LatinName = "Up (بالا) - 2009", PersianName = "Up (بالا) - 2009", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 113, LatinName = "Die Hard (جان سخت) - 1988", PersianName = "Die Hard (جان سخت) - 1988", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 114, LatinName = "Downfall (سقوط) - 2004", PersianName = "Downfall (سقوط) - 2004", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 115, LatinName = "Mr. Smith Goes to Washington (آقای اسمیت به واشنگتن می رود) - 1939", PersianName = "Mr. Smith Goes to Washington (آقای اسمیت به واشنگتن می رود) - 1939", Rate = 8.3 });
                context.Movies.Add(new Movie { Id = 116, LatinName = "The Great Escape (فرار بزرگ) - 1963", PersianName = "The Great Escape (فرار بزرگ) - 1963", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 117, LatinName = "Pan's Labyrinth (هزار توی پن) - 2006", PersianName = "Pan's Labyrinth (هزار توی پن) - 2006", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 118, LatinName = "On the Waterfront (در بار انداز) - 1954", PersianName = "On the Waterfront (در بار انداز) - 1954", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 119, LatinName = "Like Stars on Earth (ستاره های روی زمین) - 2007", PersianName = "Like Stars on Earth (ستاره های روی زمین) - 2007", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 120, LatinName = "The Bridge on the River Kwai (پل رودخانه کوای) - 1957", PersianName = "The Bridge on the River Kwai (پل رودخانه کوای) - 1957", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 121, LatinName = "Heat (مخمصه) - 1995", PersianName = "Heat (مخمصه) - 1995", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 122, LatinName = "The Seventh Seal (مهر هفتم) - 1957", PersianName = "The Seventh Seal (مهر هفتم) - 1957", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 123, LatinName = "Wild Strawberries (توت فرنگی های وحشی) - 1957", PersianName = "Wild Strawberries (توت فرنگی های وحشی) - 1957", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 124, LatinName = "The Elephant Man (مرد فیل نما) - 1980", PersianName = "The Elephant Man (مرد فیل نما) - 1980", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 125, LatinName = "The General (ژنرال) - 1926", PersianName = "The General (ژنرال) - 1926", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 126, LatinName = "Ran (آشوب) - 1985", PersianName = "Ran (آشوب) - 1985", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 127, LatinName = "12 Years a Slave (12 سال بردگی) - 2013", PersianName = "12 Years a Slave (12 سال بردگی) - 2013", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 128, LatinName = "The Gold Rush (جویندگان طلا) - 1925", PersianName = "The Gold Rush (جویندگان طلا) - 1925", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 129, LatinName = "Blade Runner (بلید رانر) - 1982", PersianName = "Blade Runner (بلید رانر) - 1982", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 130, LatinName = "My Neighbor Totoro (همسایه ی من توتورو) - 1988", PersianName = "My Neighbor Totoro (همسایه ی من توتورو) - 1988", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 131, LatinName = "Lock, Stock and Two Smoking Barrels (ضامن، قنداق و دو لوله تفنگ شلیک شده) - 1998", PersianName = "Lock, Stock and Two Smoking Barrels (ضامن، قنداق و دو لوله تفنگ شلیک شده) - 1998", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 132, LatinName = "Gran Torino (گرن تورینو) - 2008", PersianName = "Gran Torino (گرن تورینو) - 2008", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 133, LatinName = "Rebecca (ربکا) - 1940", PersianName = "Rebecca (ربکا) - 1940", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 134, LatinName = "The Big Lebowski (لبافسکی بزرگ) - 1998", PersianName = "The Big Lebowski (لبافسکی بزرگ) - 1998", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 135, LatinName = "The Secret in Their Eyes (راز چشمهایشان) - 2009", PersianName = "The Secret in Their Eyes (راز چشمهایشان) - 2009", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 136, LatinName = "It Happened One Night (در یک شب اتفاق افتاد) - 1934", PersianName = "It Happened One Night (در یک شب اتفاق افتاد) - 1934", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 137, LatinName = "Rush (شتاب) - 2013", PersianName = "Rush (شتاب) - 2013", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 138, LatinName = "Warrior (مبارز) - 2011", PersianName = "Warrior (مبارز) - 2011", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 139, LatinName = "Casino (کازینو) - 1995", PersianName = "Casino (کازینو) - 1995", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 140, LatinName = "Her (او) - 2013", PersianName = "Her (او) - 2013", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 141, LatinName = "Cool Hand Luke (لوک خوش دست) - 1967", PersianName = "Cool Hand Luke (لوک خوش دست) - 1967", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 142, LatinName = "V for Vendetta (ک مثل کین خواهی) - 2005", PersianName = "V for Vendetta (ک مثل کین خواهی) - 2005", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 143, LatinName = "The Deer Hunter (شکارچی گوزن) - 1978", PersianName = "The Deer Hunter (شکارچی گوزن) - 1978", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 144, LatinName = "The Maltese Falcon (شاهین مالت) - 1941", PersianName = "The Maltese Falcon (شاهین مالت) - 1941", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 145, LatinName = "Fargo (فارگو) - 1996", PersianName = "Fargo (فارگو) - 1996", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 146, LatinName = "Gone with the Wind (بربادرفته) - 1939", PersianName = "Gone with the Wind (بربادرفته) - 1939", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 147, LatinName = "Trainspotting (قطاربازی) - 1996", PersianName = "Trainspotting (قطاربازی) - 1996", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 148, LatinName = "Into the Wild (به‌سوی طبیعت وحشی) - 2007", PersianName = "Into the Wild (به‌سوی طبیعت وحشی) - 2007", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 149, LatinName = "Howl's Moving Castle (قلعه متحرک هاول) - 2004", PersianName = "Howl's Moving Castle (قلعه متحرک هاول) - 2004", Rate = 8.2 });
                context.Movies.Add(new Movie { Id = 150, LatinName = "How to Train Your Dragon (چگونه اژدهای خود را تربیت) - 2010", PersianName = "How to Train Your Dragon (چگونه اژدهای خود را تربیت) - 2010", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 151, LatinName = "The Grand Budapest Hotel (هتل بزرگ بوداپست) - 2014", PersianName = "The Grand Budapest Hotel (هتل بزرگ بوداپست) - 2014", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 152, LatinName = "Hotel Rwanda (هتل رواندا) - 2004", PersianName = "Hotel Rwanda (هتل رواندا) - 2004", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 153, LatinName = "Judgment at Nuremberg (دادگاه نورنبرگ) - 1961", PersianName = "Judgment at Nuremberg (دادگاه نورنبرگ) - 1961", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 154, LatinName = "The Sixth Sense (حس ششم) - 1999", PersianName = "The Sixth Sense (حس ششم) - 1999", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 155, LatinName = "Butch Cassidy and the Sundance Kid (بوچ کسیدی و ساندنس کید) - 1969", PersianName = "Butch Cassidy and the Sundance Kid (بوچ کسیدی و ساندنس کید) - 1969", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 156, LatinName = "The Thing (موجود) - 1982", PersianName = "The Thing (موجود) - 1982", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 157, LatinName = "Annie Hall (آنی هال) - 1977", PersianName = "Annie Hall (آنی هال) - 1977", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 158, LatinName = "Dial M for Murder (ام را به نشانه مرگ بگیر) - 1954", PersianName = "Dial M for Murder (ام را به نشانه مرگ بگیر) - 1954", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 159, LatinName = "Platoon (جوخه) - 1986", PersianName = "Platoon (جوخه) - 1986", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 160, LatinName = "A Beautiful Mind (یک ذهن زیبا) - 2001", PersianName = "A Beautiful Mind (یک ذهن زیبا) - 2001", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 161, LatinName = "Kill Bill: Vol. 1 (بیل را بکش : قسمت اول) - 2003", PersianName = "Kill Bill: Vol. 1 (بیل را بکش : قسمت اول) - 2003", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 162, LatinName = "No Country for Old Men (جایی برای پیرمردها نیست) - 2007", PersianName = "No Country for Old Men (جایی برای پیرمردها نیست) - 2007", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 163, LatinName = "Sin City (شهر گناه) - 2005", PersianName = "Sin City (شهر گناه) - 2005", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 164, LatinName = "Touch of Evil (نشانی از شر) - 1958", PersianName = "Touch of Evil (نشانی از شر) - 1958", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 165, LatinName = "Mary and Max (مری و مکس) - 2009", PersianName = "Mary and Max (مری و مکس) - 2009", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 166, LatinName = "Finding Nemo (در جستجوی نمو) - 2003", PersianName = "Finding Nemo (در جستجوی نمو) - 2003", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 167, LatinName = "Life of Brian (زندگی برایان) - 1979", PersianName = "Life of Brian (زندگی برایان) - 1979", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 168, LatinName = "The Princess Bride (عروس شاهزاده) - 1987", PersianName = "The Princess Bride (عروس شاهزاده) - 1987", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 169, LatinName = "Amores Perros (عشق سگی) - 2000", PersianName = "Amores Perros (عشق سگی) - 2000", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 170, LatinName = "The Wizard of Oz (جادوگر شهر از) - 1939", PersianName = "The Wizard of Oz (جادوگر شهر از) - 1939", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 171, LatinName = "The Avengers (انتقام جویان) - 2012", PersianName = "The Avengers (انتقام جویان) - 2012", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 172, LatinName = "Stand by Me (کنار من بمان) - 1986", PersianName = "Stand by Me (کنار من بمان) - 1986", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 173, LatinName = "The Lego Movie (فیلم لگو) - 2014", PersianName = "The Lego Movie (فیلم لگو) - 2014", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 174, LatinName = "Ben-Hur (بن هور) - 1959", PersianName = "Ben-Hur (بن هور) - 1959", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 175, LatinName = "The Grapes of Wrath () - 1940", PersianName = "The Grapes of Wrath () - 1940", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 176, LatinName = "The Best Years of Our Lives (بهترین سالهای زندگی ما) - 1946", PersianName = "The Best Years of Our Lives (بهترین سالهای زندگی ما) - 1946", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 177, LatinName = "There Will Be Blood (خون به پا خواهد شد) - 2007", PersianName = "There Will Be Blood (خون به پا خواهد شد) - 2007", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 178, LatinName = "Incendies (سوختگان) - 2010", PersianName = "Incendies (سوختگان) - 2010", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 179, LatinName = "Million Dollar Baby (دختر میلیون دلاری) - 2004", PersianName = "Million Dollar Baby (دختر میلیون دلاری) - 2004", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 180, LatinName = "The 400 Blows (چهارصد ضربه) - 1959", PersianName = "The 400 Blows (چهارصد ضربه) - 1959", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 181, LatinName = "8½ (هشت و نیم) - 1963", PersianName = "8½ (هشت و نیم) - 1963", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 182, LatinName = "Gravity (جاذبه) - 2013", PersianName = "Gravity (جاذبه) - 2013", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 183, LatinName = "Donnie Darko (دانی دارکو) - 2001", PersianName = "Donnie Darko (دانی دارکو) - 2001", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 184, LatinName = "Strangers on a Train (بیگانگان در قطار) - 1951", PersianName = "Strangers on a Train (بیگانگان در قطار) - 1951", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 185, LatinName = "The Bourne Ultimatum (اولتیماتوم بورن) - 2007", PersianName = "The Bourne Ultimatum (اولتیماتوم بورن) - 2007", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 186, LatinName = "In the Name of the Father (به نام پدر) - 1993", PersianName = "In the Name of the Father (به نام پدر) - 1993", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 187, LatinName = "High Noon (نیمروز) - 1952", PersianName = "High Noon (نیمروز) - 1952", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 188, LatinName = "Gandhi (گاندی) - 1982", PersianName = "Gandhi (گاندی) - 1982", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 189, LatinName = "Persona (پرسونا) - 1966", PersianName = "Persona (پرسونا) - 1966", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 190, LatinName = "Notorious (بدنام) - 1946", PersianName = "Notorious (بدنام) - 1946", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 191, LatinName = "The King's Speech (سخنرانی پادشاه) - 2010", PersianName = "The King's Speech (سخنرانی پادشاه) - 2010", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 192, LatinName = "Infernal Affairs (اعمال شیطانی) - 2002", PersianName = "Infernal Affairs (اعمال شیطانی) - 2002", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 193, LatinName = "Jaws (آرواره ها) - 1975", PersianName = "Jaws (آرواره ها) - 1975", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 194, LatinName = "Nausicaä of the Valley of the Wind (نائوسیکا از دره ی باد) - 1984", PersianName = "Nausicaä of the Valley of the Wind (نائوسیکا از دره ی باد) - 1984", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 195, LatinName = "Twelve Monkeys (دوازده میمون) - 1995", PersianName = "Twelve Monkeys (دوازده میمون) - 1995", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 196, LatinName = "Fanny and Alexander (فانی و الکساندر) - 1982", PersianName = "Fanny and Alexander (فانی و الکساندر) - 1982", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 197, LatinName = "La Strada (جاده) - 1954", PersianName = "La Strada (جاده) - 1954", Rate = 8.1 });
                context.Movies.Add(new Movie { Id = 198, LatinName = "The Terminator (نابودگر) - 1984", PersianName = "The Terminator (نابودگر) - 1984", Rate = 8 });
                context.Movies.Add(new Movie { Id = 199, LatinName = "The Night of the Hunter (شب شکارچی) - 1955", PersianName = "The Night of the Hunter (شب شکارچی) - 1955", Rate = 8 });
                context.Movies.Add(new Movie { Id = 200, LatinName = "Ip Man (ایپ من) - 2008", PersianName = "Ip Man (ایپ من) - 2008", Rate = 8 });
                context.Movies.Add(new Movie { Id = 201, LatinName = "Who's Afraid of Virginia Woolf? (چه کسی از ویرجینیا وولف می ترسد) - 1966", PersianName = "Who's Afraid of Virginia Woolf? (چه کسی از ویرجینیا وولف می ترسد) - 1966", Rate = 8 });
                context.Movies.Add(new Movie { Id = 202, LatinName = "Stalker (استاکر) - 1979", PersianName = "Stalker (استاکر) - 1979", Rate = 8 });
                context.Movies.Add(new Movie { Id = 203, LatinName = "The Big Sleep (خواب بزرگ) - 1946", PersianName = "The Big Sleep (خواب بزرگ) - 1946", Rate = 8 });
                context.Movies.Add(new Movie { Id = 204, LatinName = "Groundhog Day (روز گراندهاگ) - 1993", PersianName = "Groundhog Day (روز گراندهاگ) - 1993", Rate = 8 });
                context.Movies.Add(new Movie { Id = 205, LatinName = "Dog Day Afternoon (بعد از ظهر سگی) - 1975", PersianName = "Dog Day Afternoon (بعد از ظهر سگی) - 1975", Rate = 8 });
                context.Movies.Add(new Movie { Id = 206, LatinName = "The Battle of Algiers (نبرد الجزایر) - 1966", PersianName = "The Battle of Algiers (نبرد الجزایر) - 1966", Rate = 8 });
                context.Movies.Add(new Movie { Id = 207, LatinName = "Rocky (راکی) - 1976", PersianName = "Rocky (راکی) - 1976", Rate = 8 });
                context.Movies.Add(new Movie { Id = 208, LatinName = "Harry Potter and the Deathly Hallows: Part 2 (هری پاتر و یادگاران مرگ قسمت دوم ) - 2011", PersianName = "Harry Potter and the Deathly Hallows: Part 2 (هری پاتر و یادگاران مرگ قسمت دوم ) - 2011", Rate = 8 });
                context.Movies.Add(new Movie { Id = 209, LatinName = "La Haine (نفرت) - 1995", PersianName = "La Haine (نفرت) - 1995", Rate = 8 });
                context.Movies.Add(new Movie { Id = 210, LatinName = "Barry Lyndon (بری لیندون) - 1975", PersianName = "Barry Lyndon (بری لیندون) - 1975", Rate = 8 });
                context.Movies.Add(new Movie { Id = 211, LatinName = "Pirates of the Caribbean: The Curse of the Black Pearl (دزدان دریایی کارائیب : نفرین مروارید سیاه) - 2003", PersianName = "Pirates of the Caribbean: The Curse of the Black Pearl (دزدان دریایی کارائیب : نفرین مروارید سیاه) - 2003", Rate = 8 });
                context.Movies.Add(new Movie { Id = 212, LatinName = "Before Sunrise (پیش از نیمه شب) - 1995", PersianName = "Before Sunrise (پیش از نیمه شب) - 1995", Rate = 8 });
                context.Movies.Add(new Movie { Id = 213, LatinName = "Shutter Island (جزیره شاتر) - 2010", PersianName = "Shutter Island (جزیره شاتر) - 2010", Rate = 8 });
                context.Movies.Add(new Movie { Id = 214, LatinName = "The Graduate (فارغ التحصیل) - 1967", PersianName = "The Graduate (فارغ التحصیل) - 1967", Rate = 8 });
                context.Movies.Add(new Movie { Id = 215, LatinName = "The Celebration (جشن) - 1998", PersianName = "The Celebration (جشن) - 1998", Rate = 8 });
                context.Movies.Add(new Movie { Id = 216, LatinName = "The Hustler (بیلیارد باز) - 1961", PersianName = "The Hustler (بیلیارد باز) - 1961", Rate = 8 });
                context.Movies.Add(new Movie { Id = 217, LatinName = "Monsters, Inc. (شرکت هیولاها) - 2001", PersianName = "Monsters, Inc. (شرکت هیولاها) - 2001", Rate = 8 });
                context.Movies.Add(new Movie { Id = 218, LatinName = "Castle in the Sky (قلعه ای در آسمان) - 1986", PersianName = "Castle in the Sky (قلعه ای در آسمان) - 1986", Rate = 8 });
                context.Movies.Add(new Movie { Id = 219, LatinName = "Memories of Murder (خاطرات یک قتل) - 2003", PersianName = "Memories of Murder (خاطرات یک قتل) - 2003", Rate = 8 });
                context.Movies.Add(new Movie { Id = 220, LatinName = "Roman Holiday (تعطیلات رومی) - 1953", PersianName = "Roman Holiday (تعطیلات رومی) - 1953", Rate = 8 });
                context.Movies.Add(new Movie { Id = 221, LatinName = "Stalag 17 (بازداشتگاه شماره 17) - 1953", PersianName = "Stalag 17 (بازداشتگاه شماره 17) - 1953", Rate = 8 });
                context.Movies.Add(new Movie { Id = 222, LatinName = "The Hobbit: The Desolation of Smaug (هابیت ویرانی اسماگ) - 2013", PersianName = "The Hobbit: The Desolation of Smaug (هابیت ویرانی اسماگ) - 2013", Rate = 8 });
                context.Movies.Add(new Movie { Id = 223, LatinName = "In the Mood for Love (در حال و هوای عشق) - 2000", PersianName = "In the Mood for Love (در حال و هوای عشق) - 2000", Rate = 8 });
                context.Movies.Add(new Movie { Id = 224, LatinName = "The Help (یاری) - 2011", PersianName = "The Help (یاری) - 2011", Rate = 8 });
                context.Movies.Add(new Movie { Id = 225, LatinName = "A Fistful of Dollars (به خاطر یه مشت دلار) - 1964", PersianName = "A Fistful of Dollars (به خاطر یه مشت دلار) - 1964", Rate = 8 });
                context.Movies.Add(new Movie { Id = 226, LatinName = "Slumdog Millionaire (میلیونر زاغه نشین) - 2008", PersianName = "Slumdog Millionaire (میلیونر زاغه نشین) - 2008", Rate = 8 });
                context.Movies.Add(new Movie { Id = 227, LatinName = "The Killing (کشتن) - 1956", PersianName = "The Killing (کشتن) - 1956", Rate = 8 });
                context.Movies.Add(new Movie { Id = 228, LatinName = "Rope (طناب) - 1948", PersianName = "Rope (طناب) - 1948", Rate = 8 });
                context.Movies.Add(new Movie { Id = 229, LatinName = "Black Swan (قوی سیاه) - 2010", PersianName = "Black Swan (قوی سیاه) - 2010", Rate = 8 });
                context.Movies.Add(new Movie { Id = 230, LatinName = "The Truman Show (نمایش ترومن) - 1998", PersianName = "The Truman Show (نمایش ترومن) - 1998", Rate = 8 });
                context.Movies.Add(new Movie { Id = 231, LatinName = "Three Colors: Red (سه رنگ : قرمز) - 1994", PersianName = "Three Colors: Red (سه رنگ : قرمز) - 1994", Rate = 8 });
                context.Movies.Add(new Movie { Id = 232, LatinName = "The Diving Bell and the Butterfly (زنگ شیرجه و پروانه) - 2007", PersianName = "The Diving Bell and the Butterfly (زنگ شیرجه و پروانه) - 2007", Rate = 8 });
                context.Movies.Add(new Movie { Id = 233, LatinName = "La Dolce Vita (زندگی شیرین) - 1960", PersianName = "La Dolce Vita (زندگی شیرین) - 1960", Rate = 8 });
                context.Movies.Add(new Movie { Id = 234, LatinName = "Beauty and the Beast (دیو و دلبر) - 1991", PersianName = "Beauty and the Beast (دیو و دلبر) - 1991", Rate = 8 });
                context.Movies.Add(new Movie { Id = 235, LatinName = "Star Trek (سفرهای ستاره ای) - 2009", PersianName = "Star Trek (سفرهای ستاره ای) - 2009", Rate = 8 });
                context.Movies.Add(new Movie { Id = 236, LatinName = "Prisoners (زندانیان) - 2013", PersianName = "Prisoners (زندانیان) - 2013", Rate = 8 });
                context.Movies.Add(new Movie { Id = 237, LatinName = "Spring, Summer, Fall, Winter … and Spring (بهار تابستان ....) - 2003", PersianName = "Spring, Summer, Fall, Winter … and Spring (بهار تابستان ....) - 2003", Rate = 8 });
                context.Movies.Add(new Movie { Id = 238, LatinName = "Sleuth (کارآگاه) - 1972", PersianName = "Sleuth (کارآگاه) - 1972", Rate = 8 });
                context.Movies.Add(new Movie { Id = 239, LatinName = "A Streetcar Named Desire (تراموایی به نام هوس) - 1951", PersianName = "A Streetcar Named Desire (تراموایی به نام هوس) - 1951", Rate = 8 });
                context.Movies.Add(new Movie { Id = 240, LatinName = "The Manchurian Candidate (کاندیدای منچوری) - 1962", PersianName = "The Manchurian Candidate (کاندیدای منچوری) - 1962", Rate = 8 });
                context.Movies.Add(new Movie { Id = 241, LatinName = "The Wild Bunch (این گروه خشن) - 1969", PersianName = "The Wild Bunch (این گروه خشن) - 1969", Rate = 8 });
                context.Movies.Add(new Movie { Id = 242, LatinName = "Papiillon (پاپیون) - 1973", PersianName = "Papiillon (پاپیون) - 1973", Rate = 8 });
                context.Movies.Add(new Movie { Id = 243, LatinName = "Harvey (هاروی) - 1950", PersianName = "Harvey (هاروی) - 1950", Rate = 8 });
                context.Movies.Add(new Movie { Id = 244, LatinName = "Arsenic and Old Lace (آرسنیک و تور کهنه) - 1944", PersianName = "Arsenic and Old Lace (آرسنیک و تور کهنه) - 1944", Rate = 8 });
                context.Movies.Add(new Movie { Id = 245, LatinName = "The Man Who Shot Liberty Valance (چه کسی لیبرتی والانس را کشت) - 1962", PersianName = "The Man Who Shot Liberty Valance (چه کسی لیبرتی والانس را کشت) - 1962", Rate = 8 });
                context.Movies.Add(new Movie { Id = 246, LatinName = "Ratatoullie (راتاتویی) - 2007", PersianName = "Ratatoullie (راتاتویی) - 2007", Rate = 8 });
                context.Movies.Add(new Movie { Id = 247, LatinName = "Rain Man (مرد بارانی) - 1988", PersianName = "Rain Man (مرد بارانی) - 1988", Rate = 8 });
                context.Movies.Add(new Movie { Id = 248, LatinName = "Mystic River (رودخانه مرموز) - 2003", PersianName = "Mystic River (رودخانه مرموز) - 2003", Rate = 8 });
                context.Movies.Add(new Movie { Id = 249, LatinName = "Rosmary Baby (بچه رزمری) - 1968", PersianName = "Rosmary Baby (بچه رزمری) - 1968", Rate = 8 });
                context.Movies.Add(new Movie { Id = 250, LatinName = "Exorcist (جن گیر) - 1973", PersianName = "Exorcist (جن گیر) - 1973", Rate = 8 });
                context.Database.ExecuteSqlCommand("CREATE NONCLUSTERED INDEX [NonClusteredLatinIndex] ON [dbo].[Movies]" + 
                                                   "   (  [LatinName] ASC,  [Id] ASC, [PersianName] ASC, [Rate] ASC" +
                                                   " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]"  
                                                   );

                base.Seed(context);

            }
        }

    }
}