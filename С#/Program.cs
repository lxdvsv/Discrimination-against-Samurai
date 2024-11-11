namespace С_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Испытание чести и жизни");

            Console.Write("Представтесь юный воин: ");
            string name = Console.ReadLine();

            Console.Write("Сколько весен и осеней вы познали?: ");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);

            Console.Write("Вам нравятся самураи? (ответьте 'да' или 'нет'): ");
            string likesSamurai = Console.ReadLine().ToLower();

            Console.Write("Бусидо важен? (ответьте 'да' или 'нет'): ");
            string isBushidoImportant = Console.ReadLine().ToLower();

            Console.Write("Знаменитый самурай? (пример: Миямото Мусаси): ");
            string famousSamurai = Console.ReadLine();

            Console.Write("Что вы знаете о ритуале самоубийства (сэппуку)?: ");
            string seppukuKnowledge = Console.ReadLine();

            Console.Write("Причины сэппуку? (пример: честь, поражение): ");
            string reasonsForSeppuku = Console.ReadLine();

            Console.Write("Что важнее для воина: честь или жизнь?: ");
            string honorOrLife = Console.ReadLine();

            Console.Write("Каковы три главных принципа бусидо?: ");
            string bushidoPrinciples = Console.ReadLine();

            Console.Write("Какая роль самурая в обществе?: ");
            string samuraiRole = Console.ReadLine();

            Console.Write("Почему самураи ценили тишину и спокойствие?: ");
            string peaceAndSilence = Console.ReadLine();

            Console.Write("Какие качества, важны для истинного самурая?: ");
            string samuraiQualities = Console.ReadLine();

            Console.Write("Какая ваша любимая книга о самураях?: ");
            string favoriteSamuraiBook = Console.ReadLine();

            Console.Write("Что самое важное в жизни самурая?: ");
            string mostImportantInSamuraiLife = Console.ReadLine();

            Console.Write("Какие фильмы о самураях вам нравятся?: ");
            string favoriteSamuraiMovies = Console.ReadLine();

            Console.Write("Какое значение имеют ритуалы в жизни самурая?: ");
            string significanceOfSamuraiRituals = Console.ReadLine();

            Console.WriteLine("\nРезультаты опроса:");
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Вам нравятся самураи: " + likesSamurai);
            Console.WriteLine("Бусидо важен: " + isBushidoImportant);
            Console.WriteLine("Знаменитый самурай: " + famousSamurai);
            Console.WriteLine("Что вы знаете о ритуале самоубийства (сэппуку): " + seppukuKnowledge);
            Console.WriteLine("Причины сэппуку: " + reasonsForSeppuku);
            Console.WriteLine("Что важнее для воина: честь или жизнь: " + honorOrLife);
            Console.WriteLine("Три главных принципа бусидо: " + bushidoPrinciples);
            Console.WriteLine("Роль самурая в обществе: " + samuraiRole);
            Console.WriteLine("Почему самураи ценили тишину и спокойствие: " + peaceAndSilence);
            Console.WriteLine("Качества, важные для самурая: " + samuraiQualities);
            Console.WriteLine("Любимая книга о самураях: " + favoriteSamuraiBook);
            Console.WriteLine("Самое важное в жизни самурая: " + mostImportantInSamuraiLife);
            Console.WriteLine("Фильм о самураях: " + favoriteSamuraiMovies);
            Console.WriteLine("Значение ритуалов в жизни самурая: " + significanceOfSamuraiRituals);

            Console.WriteLine("Спасибо за участие. Пусть честь и мудрость самурая будут с вами.!");
            Console.WriteLine("Самурай должен всегда помнить, что цель его жизни – исполнить свой долг до конца, не щадя себя. Даже перед лицом смерти он должен сохранить честь и достоинство, ибо лишь тот, кто идет до конца, достоин называться самураем.");
            Console.WriteLine("Благодарю Алексея, Игоря, и Олега за вдохновение в изучении программирования по пути самурая.");
        }
    }
}

