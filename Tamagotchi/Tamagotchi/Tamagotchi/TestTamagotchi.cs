using System;

    class TestTamagotchi
    {
        static void Main(string[] args)
        {
            Random color = new Random(); 
            bool muerto = false;
            bool feliz = false;
            bool suicidio = false;
            Console.WriteLine("Quien sera el dueño del primer tamagotchi:");
            string nombre = "";
            nombre = Console.ReadLine();
            Console.WriteLine("Como quieres que se llama tu tamagotchi:");
            string nombreTamagotchi = "";
            nombreTamagotchi = Console.ReadLine();
            Console.WriteLine("Como quieres que se llama tu segundo tamagotchi:");
            string nombreTamagotchiDos = "";
            nombreTamagotchiDos = Console.ReadLine();

            Console.WriteLine("ADVERTENCIA: El tamagotchi " + nombreTamagotchi +  " y " + nombreTamagotchiDos + " tendran 3 de hambre, aburrimiento y cansancio cuando nazca");
            Console.WriteLine("INSTRUCCIONES:");
            Console.WriteLine("1 -> comer(): -2 hambre, +1 cansancio, +1 aburrimiento");
            Console.WriteLine("2 -> jugar(): -2 aburrimiento, +1 hambre, +1 cansancio ");
            Console.WriteLine("3 -> dormir(): -2 cansancio, +1 hambre, +1 aburrimiento");
            Console.WriteLine("4 -> piedravida(): Devuelve a zero hambre y cansancio y a 2 el aburrimiento");
            Console.WriteLine("5 -> suicidarse(): Pone a 5 hambre y cansancio y los tamagochis muerten al momento");
            Console.WriteLine("--------------------------------------------------------");
            Tamagotchi t1 = new Tamagotchi (3, 3, 3, 1, nombreTamagotchi);
            Console.WriteLine("El nombre del siguiente tamgotchi es " + t1.nombreTamagotchi);
            Console.WriteLine("Hambre: " + t1.hambre);
            Console.WriteLine("Aburrimiento: " + t1.aburrimiento);
            Console.WriteLine("Cansancio: " + t1.cansancio);
            Console.WriteLine("Tienes " + t1.piedraVida + " piedra vida para recuperar hambre a 0 aburrimiento y cansancio a 2 recuerda usarla bien");
           
            Tamagotchi t2 = new Tamagotchi(3, 3, 3, 1, nombreTamagotchiDos);
            Console.WriteLine("El nombre del siguiente tamgotchi es " + t2.nombreTamagotchi);
            Console.WriteLine("Hambre: " + t2.hambre);
            Console.WriteLine("Aburrimiento: " + t2.aburrimiento);
            Console.WriteLine("Cansancio: " + t2.cansancio);
            Console.WriteLine("Tienes " + t2.piedraVida + " piedra vida para recuperar hambre a 0 aburrimiento y cansancio a 2 recuerda usarla bien");
            


            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.WriteLine("                    ■■                                      ■■                                                      "); 
            Console.WriteLine("                  ■    ■                                  ■    ■                                                    ");
            Console.WriteLine("                ■        ■                              ■        ■                                                  ");
            Console.WriteLine("              ■            ■                          ■            ■                                                ");
            Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■                        ■  ■ ■ ■■ ■ ■  ■                                               ");
            Console.ForegroundColor = ConsoleColor.Gray;        
            Console.WriteLine("              ■  ■      ■  ■                          ■  ■      ■  ■                                               ");
            Console.WriteLine("              ■    ■■■■    ■                          ■    ■■■■    ■                                               ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■                        ■  ■ ■ ■■ ■ ■  ■                                              ");
            Console.WriteLine("    ■■ ■ ■ ■ ■              ■ ■ ■ ■ ■■      ■■ ■ ■ ■ ■              ■ ■ ■ ■ ■■                                     ");
            Console.WriteLine("             ■              ■                        ■              ■                                              ");
            Console.WriteLine("               ■           ■                           ■           ■                                               ");
            Console.WriteLine("                 ■ ■■■■ ■                                ■ ■■■■ ■                                                  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Que numero de operacion quieres realizar");

            do
            {
                int operacion = 0;
                operacion = Console.Read();
                
                switch (operacion) {
                    case '1':
                       
                        t1.hambre = t1.hambre - 2;
                        t1.cansancio = t1.cansancio + 1;
                        t1.aburrimiento = t1.aburrimiento + 1;

                        if (t1.aburrimiento > 5 && t2.aburrimiento > 5)
                        {
                            t1.aburrimiento = 5;
                            t2.aburrimiento = 5;
                    }

                        if (t1.hambre <= 0 && t2.hambre <= 0)
                        {
                            t1.hambre = 1;
                            t2.hambre = 1;
                        }

                        if (t1.cansancio <= 0 && t2.cansancio <= 0)
                        {
                            t1.cansancio = 1;
                            t2.cansancio = 1;
                    }

                        if (t1.aburrimiento <= 0 && t2.aburrimiento <= 0)
                        {
                            t1.aburrimiento = 1;
                            t2.aburrimiento = 1;
                    }

                        if (t1.hambre == 5 || t1.cansancio == 5 || t2.cansancio == 5 || t2.hambre == 5) 
                        {
                            muerto = true;
                        }

                        if (t1.aburrimiento == 1 && muerto == false && t2.aburrimiento == 1 && muerto == false)
                        {
                            feliz = true;
                        }

                        Console.WriteLine("Los nombres de los tamgotchis es " + t1.nombreTamagotchi + " y " + t2.nombreTamagotchi);
                        Console.WriteLine("Hambre: " + t1.hambre);
                        Console.WriteLine("Aburrimiento: " + t1.aburrimiento);
                        Console.WriteLine("Cansancio: " + t1.cansancio);
                        if (t1.hambre < 5 || t1.cansancio < 5)
                        {
                        Console.WriteLine("Que numero de operacion quieres realizar");
                         }

                    break;

                    case '2':

                        t1.hambre = t1.hambre + 1;
                        t1.cansancio = t1.cansancio + 1;
                        t1.aburrimiento = t1.aburrimiento - 2;

                        if (t1.aburrimiento > 5 || t2.aburrimiento > 5)
                        {
                            t1.aburrimiento = 5;
                            t2.aburrimiento = 5;
                    }

                
                        if (t1.hambre <= 0 || t2.hambre <= 0)
                        {
                            t1.hambre = 1;
                            t2.hambre = 1;
                        }

                        if (t1.cansancio <= 0 || t2.cansancio <= 0)
                        {
                            t1.cansancio = 1;
                            t2.cansancio = 1;
                        }

                        if (t1.aburrimiento <= 0 || t2.aburrimiento <= 0)
                        {
                            t1.aburrimiento = 1;
                            t2.aburrimiento = 1;
                    }

                        if (t1.hambre == 5 || t1.cansancio == 5)
                        {
                            muerto = true;
                        }

                        if (t1.aburrimiento == 1 && muerto == false)
                        {
                            feliz = true;
                        }


                    Console.WriteLine("Los nombres de los tamgotchis es " + t1.nombreTamagotchi + " y " + t2.nombreTamagotchi);
                    Console.WriteLine("Hambre: " + t1.hambre);
                    Console.WriteLine("Aburrimiento: " + t1.aburrimiento);
                    Console.WriteLine("Cansancio: " + t1.cansancio);
                    if (t1.hambre < 5 || t1.cansancio < 5)
                    {
                        Console.WriteLine("Que numero de operacion quieres realizar");
                    }



                    break;

                    case '3':
                        
                        t1.hambre = t1.hambre + 1;
                        t1.cansancio = t1.cansancio - 2;
                        t1.aburrimiento = t1.aburrimiento + 1;

                    if (t1.aburrimiento > 5 || t2.aburrimiento > 5)
                    {
                        t1.aburrimiento = 5;
                        t2.aburrimiento = 5;
                    }


                    if (t1.hambre <= 0 || t2.hambre <= 0)
                    {
                        t1.hambre = 1;
                        t2.hambre = 1;
                    }

                    if (t1.cansancio <= 0 || t2.cansancio <= 0)
                    {
                        t1.cansancio = 1;
                        t2.cansancio = 1;
                    }

                    if (t1.aburrimiento <= 0 || t2.aburrimiento <= 0)
                    {
                        t1.aburrimiento = 1;
                        t2.aburrimiento = 1;
                    }
                    if (t1.hambre == 5 || t1.cansancio == 5)
                        {
                            muerto = true;
                        }

                        if (t1.aburrimiento <= 1 && t1.cansancio < 5 && t1.hambre < 5)
                        {
                            feliz = true;
                        }


                    Console.WriteLine("Los nombres de los tamgotchis es " + t1.nombreTamagotchi + " y " + t2.nombreTamagotchi);
                    Console.WriteLine("Hambre: " + t1.hambre);
                    Console.WriteLine("Aburrimiento: " + t1.aburrimiento);
                    Console.WriteLine("Cansancio: " + t1.cansancio);
                    if (t1.hambre < 5 || t1.cansancio < 5)
                    {
                        Console.WriteLine("Que numero de operacion quieres realizar");
                    }

                    

                    break;

                case '4':

                    if (t1.piedraVida == 1) {

                    t1.hambre = 0;
                    t1.cansancio = 0;
                    t1.aburrimiento = 2;
                    t1.piedraVida = 0;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                    ■■                                      ■■                                                      ");
                        Console.WriteLine("                  ■    ■                                  ■    ■                                                    ");
                        Console.WriteLine("                ■        ■                              ■        ■                                                  ");
                        Console.WriteLine("              ■            ■                          ■            ■                                                ");
                        Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■                        ■  ■ ■ ■■ ■ ■  ■                                               ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("              ■  ■      ■  ■                          ■  ■      ■  ■                                               ");
                        Console.WriteLine("              ■    ■■■■    ■                          ■    ■■■■    ■                                               ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■                        ■  ■ ■ ■■ ■ ■  ■                                              ");
                        Console.WriteLine("    ■■ ■ ■ ■ ■              ■ ■ ■ ■ ■■      ■■ ■ ■ ■ ■              ■ ■ ■ ■ ■■                                     ");
                        Console.WriteLine("             ■              ■                        ■              ■                                              ");
                        Console.WriteLine("               ■           ■                           ■           ■                                               ");
                        Console.WriteLine("                 ■ ■■■■ ■                                ■ ■■■■ ■                                                  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Que numero de operacion quieres realizar");


                    }
                    else { Console.WriteLine("Ya no puedes usar la piedra, intenta hacer otra cosa"); }

                   Console.WriteLine("Los nombres de los tamgotchis es " + t1.nombreTamagotchi + " y " + t2.nombreTamagotchi);
                        Console.WriteLine("Hambre: " + t1.hambre);
                        Console.WriteLine("Aburrimiento: " + t1.aburrimiento);
                        Console.WriteLine("Cansancio: " + t1.cansancio);
                    break;

                case '5':

                    t1.cansancio = 5;
                    t1.hambre = 5;
                    t2.hambre = 5;
                    t2.cansancio = 5;
                    muerto = true;
                    suicidio = true;

                    break;

                default: break;

                }

             
            } while (muerto == false && feliz == false);

            if (muerto == true && suicidio == false)
            {
            Console.WriteLine("TUS TAMAGOTCHIS HAN MUERTO, FIN DEL JUEGO");
            Console.WriteLine("El nombre de los tamgotchis es " + t1.nombreTamagotchi + " y " + t2.nombreTamagotchi);
            Console.WriteLine("HAMBRE: " + t1.hambre);
            Console.WriteLine("CANSANCIO: " + t1.cansancio);


            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                   ■ ■ ■ ■                          ■ ■ ■ ■                        ");
            Console.WriteLine("                   ■     ■                          ■     ■                        ");
            Console.WriteLine("             ■ ■ ■ ■     ■ ■ ■ ■              ■ ■ ■ ■     ■ ■ ■ ■                            ");
            Console.WriteLine("             ■      D.E.P      ■              ■      D.E.P      ■                              ");
            Console.WriteLine("             ■ ■ ■ ■     ■ ■ ■ ■              ■ ■ ■ ■     ■ ■ ■ ■                              ");
            Console.WriteLine("                   ■     ■                          ■     ■                       ");
            Console.WriteLine("                   ■     ■                          ■     ■                       ");
            Console.WriteLine("                   ■     ■                          ■     ■                       ");
            Console.WriteLine("                   ■     ■                          ■     ■                       ");
            Console.WriteLine("                   ■     ■                          ■     ■                       ");
            Console.WriteLine("                   ■ ■ ■ ■                          ■ ■ ■ ■                        ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        if (suicidio == true && muerto == true)
        {
            Console.WriteLine("TUS TAMAGOTCHIS SE HAN SUICIDADO, FIN DEL JUEGO");
            Console.WriteLine("El nombre del siguiente tamgotchi es " + t1.nombreTamagotchi + " y " + t2.nombreTamagotchi);
            Console.WriteLine("HAMBRE: " + t1.hambre);
            Console.WriteLine("CANSANCIO: " + t1.cansancio);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                   ■ ■ ■ ■                          ■ ■ ■ ■                        ");
            Console.WriteLine("                   ■     ■                          ■     ■                        ");
            Console.WriteLine("             ■ ■ ■ ■     ■ ■ ■ ■              ■ ■ ■ ■     ■ ■ ■ ■                            ");
            Console.WriteLine("             ■      D.E.P      ■              ■      D.E.P      ■                              ");
            Console.WriteLine("             ■ ■ ■ ■     ■ ■ ■ ■              ■ ■ ■ ■     ■ ■ ■ ■                              ");
            Console.WriteLine("                   ■     ■                          ■     ■                       ");
            Console.WriteLine("                   ■     ■                          ■     ■                       ");
            Console.WriteLine("                   ■     ■                          ■     ■                       ");
            Console.WriteLine("                   ■     ■                          ■     ■                       ");
            Console.WriteLine("                   ■     ■                          ■     ■                       ");
            Console.WriteLine("                   ■ ■ ■ ■                          ■ ■ ■ ■                        ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        if (feliz == true)
            {
                Console.WriteLine("TUS TAMAGOTCHI AHORA SON LOS NUEVOS MESIAS. HAS GANADO");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                    ■                                             ■     ");
                Console.WriteLine("                  ■ ■ ■                                         ■ ■ ■              ");
                Console.WriteLine("                    ■                                             ■                ");
                Console.WriteLine("            ■ ■ ■ ■ ■ ■ ■ ■ ■                             ■ ■ ■ ■ ■ ■ ■ ■ ■                                  ");
                Console.WriteLine("            ■               ■                             ■               ■                                  ");
                Console.WriteLine("             ■             ■                               ■             ■                                   ");
                Console.WriteLine("               ■          ■                                  ■          ■                                    ");
                Console.WriteLine("                 ■ ■■■■ ■                                      ■ ■■■■ ■                                      ");
                Console.WriteLine("               ■          ■                                  ■          ■                                    ");
                Console.WriteLine("              ■            ■                                ■            ■                                   ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("              ■  ■      ■  ■                                ■  ■      ■  ■                                   ");
                Console.WriteLine("              ■    ■■■■    ■                                ■    ■■■■    ■                                   ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("             ■  ■ ■ ■■ ■ ■  ■                              ■  ■ ■ ■■ ■ ■  ■                                 ");
                Console.WriteLine("      ■ ■■■■ ■              ■ ■■■■■ ■               ■ ■■■■ ■              ■ ■■■■■ ■                         ");
                Console.WriteLine("             ■              ■                              ■              ■                                ");
                Console.WriteLine("               ■          ■                                  ■          ■                                  ");
                Console.WriteLine("                 ■ ■■■■ ■                                      ■ ■■■■ ■                                    ");
                Console.ForegroundColor = ConsoleColor.White;
        }

        }
    }

