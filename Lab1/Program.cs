using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 0;
            //DEBUT

            Console.WriteLine("Venom s'amuse à terroriser la ville comme d'habitude,");
            Console.WriteLine("mais Anti-Venom arrive pour l'en n'empêcher,");
            Console.WriteLine("va-t-il dancer comme Star Lord pour l'impressioner (1)");
            Console.WriteLine("Ou font-il un pierre feuille ciseaux (2) ?");
            choix = Convert.ToInt32(Console.ReadLine());

            if (choix == 1)
            {
                Console.WriteLine("Anti-Venom est intimidé et se fait mangé par Venom");
            }

            else if (choix == 2)
            {
                Console.WriteLine("Venom et Anti-Venom luttent de manière acharnée et en sont à la 3ème manche");
                Console.WriteLine("Cette manche sera décisive, que doit faire Venom");
                Console.WriteLine("Jouer pierre (1), feuille (2) ou ciseaux (3)");
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1)
                {
                    Console.WriteLine("Anti-Venom joue ciseaux, Venom gagne et mange Anti-Venom");
                }


                else if (choix == 2)
                {
                    Console.WriteLine("Anti-Venon joue ciseaux, il gagne malheureusement");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                else if (choix == 3)
                {
                    Console.WriteLine("Anti-Venom joue papier, perd, et se fait dévorer");
                }
            }

            Console.WriteLine("Venom a mangé Anti-Venom et continue ca route vers la ville pour manger pleins d'humains");
            Console.WriteLine("MAIS ! Il tombe sur son ami l'araigner et il veut l'empêcher a tout prit");
            Console.WriteLine("Ils vont faire un chache-cache (1)");
            Console.WriteLine("Le premier a trouvé le gants de L'infini gange (2)");
            choix = Convert.ToInt32(Console.ReadLine());

            if (choix == 1)
            {
                Console.WriteLine("Ce caché dérrièr une poubelle 3 fois plus petite que toi c'est pas une bonne idée");
                Console.ReadKey();
            }

            else if (choix == 2)
            {
                Console.WriteLine("Venom a trouvé le gant ! Il transforme Spidi en pleins de petits cubes ! et mange tout le monde comme d'habitude");
            }

            Console.WriteLine("Venom et super fatigué mais il voit son film au cinéma !! Donc il y va");
            Console.WriteLine("Dans la fil d'attente il voi une super blonde, c'est Captain Marvel !!");
            Console.WriteLine("Venom commence a ce raprocher, il utilise encore les métodes de Star Lord mais cette fois ci pour draguer (1)");
            Console.WriteLine("Venom va la voir et lui montre le gant pour l'imprésionné (2)");
            choix = Convert.ToInt32(Console.ReadLine());

            if (choix == 1)
            {
                Console.WriteLine("Ca marche avec succès ! Ils vont voir le film ensemble");
            }

            else if (choix == 2)
            {
                Console.WriteLine("Captain Marvel arrache le gant de ca main, il ne peut plus rien faire et utilise Venom cmme table basse pour les pop corn...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine("Venom et Captain Marvel sont fou amoureux !");
            Console.WriteLine("Ils vont faire une balade dans centrale park (en passent ils voient spidi en petit cube et ils marchent sur lui)");
            Console.WriteLine("Et la dans central park, ils voient THANOS. Il cherche le gant d'infini !");
            Console.WriteLine("Venom et terrorisé ! Captain Marvel prend le devant et va afronter Thanos et elle ce fait mettre KO en 2 seconde !");
            Console.WriteLine("Venom utilse le gant et re met Spidi dans ca forme normale pour l'aider (1)");
            Console.WriteLine("Il ce téléporte avec Captain grace au gant (2)");
            choix = Convert.ToInt32(Console.ReadLine());

            if (choix == 1)
            {
                Console.WriteLine("Spidi aide Venom en plus Iron Man arrive ! Thanos et rentrée sur son petit caillou et regarde le ciel comme d'hab =P Captain ce reveil regarde VenoM et s'envole avec Spdi");
                Console.WriteLine("Et ouais fallait porter c'est balls. (C'est pas le scénar de Spiderman 3 avec cette blonde la ?) oO");
                Console.ReadKey();
                Environment.Exit(0);
            }

            else if (choix == 2)
            {
                Console.WriteLine("Ils ce sont téléporter dans une maison qui et toute sale et en bordel ! Et il y a une odeur trés bisare oO");
            }

            Console.WriteLine("Un mec sort de la douche tout nu et avec une licorne ! Et il et hyper moche");
            Console.WriteLine(" Ils se regardent tous dans les yeux (Venom cache les yeux de Captain Marvel). Le mec tout nu enfil un costume rouge, mais c'est Deadpool !");
            Console.WriteLine("Ils ce tapent la discute et vont boir un verre dans le bar de Deapool (1)");
            Console.WriteLine("Ils l'attaprent et le coupe en morceaux pour le mettre dans une boite et l'envoyer dans un trou noir ! (2)");
            choix = Convert.ToInt32(Console.ReadLine());

            if (choix == 1)
            {
                Console.WriteLine("Il ne fallait pas le suivre ! Deadpool a drogué Venom et il et parit avec Captain Marvel !");
                Console.WriteLine("Ps: Ne jamais faire confiance a un mec avec une licorne qui et gommer d'une substance blanche...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine("Après toute cette animation ils s'endorment dans le canapé");
            Console.WriteLine("Et la Venom ce réveille dans ca chambre regarde autour de lui et ne voi pas Captain tout affoler il l'a cherche partout et la il remarque tout était un rêve. Il deviens drogué WALLAH.");


            Console.ReadKey();



        }
    }
}
