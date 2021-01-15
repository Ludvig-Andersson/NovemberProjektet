using System;

namespace November
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer4 = "ja";

            while (answer4 == "ja")
            {

                string answer1 = "answer1";
                string answer2 = "answer2";
                string answer3 = "answer3";

                Random generator = new Random();

                System.Console.WriteLine("Vill du starta Spelet? ja eller nej");

                answer3 = Console.ReadLine();

                if (answer3 == "nej")
                { //Så att spelet stängs ner om man svarar nej till att starta spelet
                    System.Environment.Exit(0);
                }

                if (answer3 != "ja" && answer3 != "nej")
                { //Ifall man svarar fel
                    System.Console.WriteLine("Du skrev inte ja eller nej");
                    answer3 = Console.ReadLine();
                }

                if (answer3 == "ja")
                {
                    System.Console.WriteLine("Du heter Olle, är 16 år och bor i en villa i Sverige! Du kommer träffa olika människor och beroende på hur du svarar kommer de reagera.");
                    Console.ReadLine();
                    Console.Clear();
                    System.Console.WriteLine("Du har nyss lämnat ditt hus och är påväg mot Coop. Du blir plötsligt knivhotad av en 15 åring som tvingar dig att ge han din mobil värd 10 000 kr");
                    Console.ReadLine();
                    Console.Clear();
                    System.Console.WriteLine("Du kan antingen svara (a) stick härifrån (b) Okej jag ger dig mobilen bara skada mig inte");



                    answer1 = Console.ReadLine();

                    if (answer1 != "a" && answer1 != "b")
                    { //Ifall man svarar fel
                        System.Console.WriteLine("Du skrev inte a eller b");
                        answer1 = Console.ReadLine();
                    }


                    if (answer1 == "a")
                    { //om de svarar med ett a
                        System.Console.WriteLine("Den 15 åriga ungen sprang iväg med sin kniv i handen och fegade ur");
                        Console.ReadLine();
                        Console.Clear();
                        System.Console.WriteLine("Du gick in till Coop och köpte en godispåse, när du väl kom ut ur affären så stod det 3 muskelösa 2 meter långa vuxna, De tog dig och förde dig till ett övergivet hus");
                        Console.ReadLine();
                        Console.Clear();
                        System.Console.WriteLine("Du blev fastbunden till en stol och de tog din mobil. De valde att köra coinflip om du ska bli frisläppt eller vara fastbunden över natten");
                        Console.ReadLine();
                        Console.Clear();
                        int random = generator.Next(0, 3); // Den slumpar mellan 1 och 2

                        if (random == 2)
                        {
                            System.Console.WriteLine("Du blev frisläppt och tog dig hem utan problem");
                            Console.ReadLine();
                            System.Console.WriteLine("Tur att du överlevde natten och tog dig hem hel");
                            Console.ReadLine();
                            System.Console.WriteLine("10 Minuter senare kom din farsa hem i BILTEMA kalsonger och en halväten munk i käften");
                            System.Console.WriteLine("Så var det med det, TJENA TJENA");


                        }

                        if (random == 1)
                        {
                            System.Console.WriteLine("Du kommer bli lämnad ensam hela natten");
                            Console.ReadLine();

                            System.Console.WriteLine("Efter några timmar av ensamhet började du höra något nere i källaren");
                            System.Console.WriteLine("Vill du (a) vara tyst eller vill du (b) skrika hallå");

                            answer2 = Console.ReadLine();

                            if (answer2 != "a" && answer2 != "b")
                            { //Ifall man svarar fel
                                System.Console.WriteLine("Du skrev inte a eller b");
                                answer2 = Console.ReadLine();
                            }

                            if (answer2 == "a")
                            {
                                System.Console.WriteLine("Ljudet bara mystiskt försvann i källaren");
                                System.Console.WriteLine("Efter drygt en timme så började man se två ögon sticka fram i huset");
                                System.Console.WriteLine("Det viskades MUNKAR över hela huset");
                                System.Console.WriteLine("Du frågade om han ville ha munkar och du fick svaret jaaa");
                                System.Console.WriteLine("Efter det vart det ljust i hela huset och där stod din farsa i BILTEMA kalsonger med en halvuppäten munk i käften");
                                System.Console.WriteLine("Efter det så vart det stelt en stund och sen började båda garva");
                                System.Console.WriteLine("Olles farsa släppte sedan loss dig och båda gick till Coop, köpte munkar och gick hem");
                                System.Console.WriteLine("Det kommer alltid att vara ett mysterium vad som hände den dagen");
                                System.Console.WriteLine("Så var det med det, TJENA TJENA");
                            }

                            if (answer2 == "b")
                            {
                                System.Console.WriteLine("Ljudet började sakta röra sig uppför trappan");
                                System.Console.WriteLine("3 minuter senare såg man endast ett par ögon i mörkret som viskade MUNKAR");
                                System.Console.WriteLine("Du frågade om han ville ha munkar och du fick svaret jaaa");
                                System.Console.WriteLine("Efter det vart det ljust i hela huset och där stod din farsa i BILTEMA kalsonger med en halvuppäten munk i käften");
                                System.Console.WriteLine("Efter det så vart det stelt en stund och sen började båda garva");
                                System.Console.WriteLine("Olles farsa släppte sedan loss dig och båda gick till Coop, köpte munkar och gick hem");
                                System.Console.WriteLine("Det kommer alltid att vara ett mysterium vad som hände den dagen");
                                System.Console.WriteLine("Så var det med det, TJENA TJENA");

                            }


                        }



                    }

                    if (answer1 == "b")
                    { //om de svarar med ett b
                        System.Console.WriteLine("Den 15 åriga ungen sprang iväg med mobilen");
                        Console.ReadLine();
                        Console.Clear();
                        System.Console.WriteLine("Du valde att smyga efter ungen som tog din mobil vilket ledde dig till ett gammalt övergivet hus");
                        Console.ReadLine();
                        Console.Clear();
                        System.Console.WriteLine("Du blev nyfiken och valde att smyga in i huset och smyglyssna på deras konversation");
                        Console.ReadLine();
                        Console.Clear();
                        System.Console.WriteLine("Du blev påkommen av 3 muskelösa 2 meter långa vuxna män och blev fastbunden till en stol.");
                        Console.ReadLine();
                        Console.Clear();
                        System.Console.WriteLine("De tog din mobil. De valde att köra coinflip om du ska bli frisläppt eller vara fastbunden över natten");
                        Console.ReadLine();
                        int random = generator.Next(0, 3); // Den slumpar mellan 1 och 2


                        if (random == 2) //ifall slumpen blir 2
                        {
                            System.Console.WriteLine("Du blev frisläppt och tog dig hem utan problem");
                            Console.ReadLine();
                            Console.Clear();
                            System.Console.WriteLine("Tur att du överlevde natten och tog dig hem hel");
                            Console.ReadLine();
                            Console.Clear();
                            System.Console.WriteLine("10 Minuter senare kom din farsa hem i BILTEMA kalsonger och en halväten munk i käften");
                            Console.ReadLine();
                            Console.Clear();
                            System.Console.WriteLine("Så var det med det, TJENA TJENA");
                            Console.ReadLine();
                            Console.Clear();


                        }

                        if (random == 1) //ifall slumpen blir 1
                        {
                            System.Console.WriteLine("Du kommer bli lämnad ensam hela natten");
                            Console.ReadLine();
                            Console.Clear();

                            System.Console.WriteLine("Efter några timmar av ensamhet började du höra något nere i källaren");
                            Console.ReadLine();
                            Console.Clear();
                            System.Console.WriteLine("Vill du (a) vara tyst eller vill du (b) skrika hallå");

                            answer2 = Console.ReadLine();

                            if (answer2 == "a")
                            {
                                System.Console.WriteLine("Ljudet bara mystiskt försvann i källaren");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Efter drygt en timme så började man se två ögon sticka fram i huset");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Det viskades MUNKAR över hela huset");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Du frågade om han ville ha munkar och du fick svaret jaaa");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Efter det vart det ljust i hela huset och där stod din farsa i BILTEMA kalsonger med en halvuppäten munk i käften");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Efter det så vart det stelt en stund och sen började båda garva");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Olles farsa släppte sedan loss dig och båda gick till Coop, köpte munkar och gick hem");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Det kommer alltid att vara ett mysterium vad som hände den dagen");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Så var det med det, TJENA TJENA");
                                Console.ReadLine();
                                Console.Clear();
                            }

                            if (answer2 == "b")
                            {
                                System.Console.WriteLine("Ljudet började sakta röra sig uppför trappan");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("3 minuter senare såg man endast ett par ögon i mörkret som viskade MUNKAR");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Du frågade om han ville ha munkar och du fick svaret jaaa");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Efter det vart det ljust i hela huset och där stod din farsa i BILTEMA kalsonger med en halvuppäten munk i käften");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Efter det så vart det stelt en stund och sen började båda garva");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Olles farsa släppte sedan loss dig och båda gick till Coop, köpte munkar och gick hem");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Det kommer alltid att vara ett mysterium vad som hände den dagen");
                                Console.ReadLine();
                                Console.Clear();
                                System.Console.WriteLine("Så var det med det, TJENA TJENA");
                                Console.ReadLine();
                                Console.Clear();

                            }


                        }

                    }

                    System.Console.WriteLine("Vill du spela igen? ja eller nej");

                    answer4 = Console.ReadLine();

                    if (answer4 == "Nej")
                    {
                        System.Environment.Exit(0);
                    }


                }






                Console.ReadLine();





            }
        }
    }
}