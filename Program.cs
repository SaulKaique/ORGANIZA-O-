///he he he feito por saul 10/12/2022
        Console.Clear();

    


    
 




        string f1 = @"Olá meu nome Yusano serei seu assistente neste projeto e guiarei você
por ele, mas apesar de tudo ele não e tão grande ou detalhado mas e um projeto feito
com tudo que foi aprendido em aula para começar qual o seu nome ?
";
        int destino2;
        string f2;
        string f3;
        string f4;
     
        int valor = new Random().Next(1, 100);
        int valor2 = new Random().Next(1, 100);
        int dtaboa ;
  
        int d1;
        int d2;
        int d3;
        
        




        Console.ForegroundColor = ConsoleColor.Yellow;

        for (int i1 = 0; i1 < f1.Length; i1++)
        {
            Console.Write(f1.ElementAt(i1));
            Thread.Sleep(60);

        }


        //nomes 
        string NPC = "YUSANO";

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.Write("Meu nome é ...:");
        string Nome =Convert.ToString( Console.ReadLine()!.ToUpper());


        //inicio 

        f2 = @$"[{NPC}]: {Nome}  Eu serei a pessoa que ira mostrar tudo que vai se passar neste projeto
mesmo ele não sendo muito grande ou muito menos detalhado  peço desculpas se tiver um erro  de 
português ou se ocorrer um erro no programa mas poder ocorrer por que ainda esta em fase de teste 
então peço que considere isso parando com todo esse bla bla bla vãos começar 


";

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;

        for (int i2 = 0; i2 < f2.Length; i2++)
        {
            Console.Write(f2.ElementAt(i2));
            Thread.Sleep(60);

        }


        f3 = $@"[{NPC}] Para começar te darei a opção de deixar eu escolher o que vai acontecer no projeto ou
você pode escolher o que você vai ver no projeto...:

";



       


        Console.ResetColor();

            d1 = 1;
            d2 = 2;
            d3 = 3;
       





            string dfala = @"Agora vou apresentar suas opçoes:
                      ";
            for (int i11 = 0; i11 < dfala.Length; i11++)
            {
                
                Console.Write(dfala.ElementAt(i11));
                Thread.Sleep(60);

            }


        Console.Clear();
            MENU01();

Console.Write(@$"{Nome}: Eu quero :");


 destino2 = Convert.ToInt32(Console.ReadLine());

        if (destino2 == d1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            f1 = $@"[{NPC}]: para começar {Nome} vamos jogar um jogo simples eu irei explicar as regras agora 

1.nos dois iremos ter 100 pontos de início e iremos girar dados para ver quem tira o maior número.


2.se a gente empatar ninguém perde ponto.


Agora que eu expliquei tudo vamos jogar..? 
";


            for (int i4 = 0; i4 < f1.Length; i4++)
            {
                Console.Write(f1.ElementAt(i4));
                Thread.Sleep(60);

            }
            Console.ResetColor();


            Console.Write($"{Nome}: Eu vou:");


            string dsim = "sim";
            string dnao = "Nao";
            string destino3 = Console.ReadLine()!;
            string nNd = "";


    if (destino3 == dsim)
    { 
       f4 = @$"[{NPC}]: vou girar os dados vamos ver os resultados 
        ";
 

JOGO();
                                            }//destino sim 

    else if (destino3 == dnao)
{




}//destino nao  

    else if(destino3 == nNd)
    {
         dtaboa = 1;
         
     

        menu02();

    destino2 =Convert.ToInt32( Console.ReadLine());





    if (destino2 == dtaboa)
    {
        taboada();


    }
    
    else if (destino2 == d2)
{
        //terminar
     Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();



}

    
            }
    
                 

        
                                 }//destino nada 
                                                   

    else if (destino2 == d2)
      {
        
       taboada();

      }

    else if (destino2 == d3)
    {
        terminar();

    }


    else if (destino2 <= 0)
    {
        MENU01();

        Console.Write(@$"{Nome}: Eu quero :");


 destino2 = Convert.ToInt32(Console.ReadLine());

        if (destino2 == d1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            f1 = $@"[{NPC}]: para começar {Nome} vamos jogar um jogo simples eu irei explicar as regras agora 

1.nos dois iremos ter 100 pontos de início e iremos girar dados para ver quem tira o maior número.


2.se a gente empatar ninguém perde ponto.


Agora que eu expliquei tudo vamos jogar..? 
";


            for (int i4 = 0; i4 < f1.Length; i4++)
            {
                Console.Write(f1.ElementAt(i4));
                Thread.Sleep(60);

            }
            Console.ResetColor();


            Console.Write($"{Nome}: Eu vou:");


            string dsim = "sim";
            string dnao = "Nao";
            string destino3 = Console.ReadLine()!;
            string nNd = "";


    if (destino3 == dsim)
    { 
       f4 = @$"[{NPC}]: vou girar os dados vamos ver os resultados 
        ";
 

JOGO();
                                            }//destino sim 

    else if (destino3 == dnao)
{




}//destino nao  

    else if(destino3 == nNd)
    {
         dtaboa = 1;
         
     

        menu02();

    destino2 =Convert.ToInt32( Console.ReadLine());





    if (destino2 == dtaboa)
    {
        taboada();


    }
    
    else if (destino2 == d2)
{
        //terminar
     Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();



}

    
            }
    
                 

        
                                 }//destino nada 
                                                   

    else if (destino2 == d2)
      {
        
        Console.Clear();

    Console.ForegroundColor = ConsoleColor.Magenta;


    Console.Write("......Tabuada do número.....:");
    int numero = Convert.ToInt32(Console.ReadLine());

    int vezes = 0;

    int resultado;
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkGreen;


while ( vezes <= 10 )
{
    resultado = numero * vezes ;

    Console.Write($"{numero} X {vezes} = {resultado}\n");
    vezes += 1;
};




    Console.ResetColor();


    Console.WriteLine("Aquarde 5 segundos:");



        Thread.Sleep(5000);


    Console.WriteLine("   ___________________________");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |      [{}]         {[]}   |");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |             []           |");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |    [_________________]   |");
    Console.WriteLine("  |__________________________|");
     
     
      menu05();
     
     
     destino2 =Convert.ToInt32( Console.ReadLine());

    


     if (destino2 == d1)
     {
            //JOGO
        JOGO();
     
     }
     

    
    else if (destino2 == d2)
    {

      Console.Clear();
       Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();


Console.ResetColor();



    }//finalizar NPC


      }  




    else if (destino2 == d3)
    {
        Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();

    }


    else if (destino2 <= 0)
    {
       lupe();

    



    }            



    }            
        
      
    else if (destino2 >= 4)
    {
              MENU01();

        Console.Write(@$"{Nome}: Eu quero :");


 destino2 = Convert.ToInt32(Console.ReadLine());

        if (destino2 == d1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            f1 = $@"[{NPC}]: para começar {Nome} vamos jogar um jogo simples eu irei explicar as regras agora 

1.nos dois iremos ter 100 pontos de início e iremos girar dados para ver quem tira o maior número.


2.se a gente empatar ninguém perde ponto.


Agora que eu expliquei tudo vamos jogar..? 
";


            for (int i4 = 0; i4 < f1.Length; i4++)
            {
                Console.Write(f1.ElementAt(i4));
                Thread.Sleep(60);

            }
            Console.ResetColor();


            Console.Write($"{Nome}: Eu vou:");


            string dsim = "sim";
            string dnao = "Nao";
            string destino3 = Console.ReadLine()!;
            string nNd = "";


    if (destino3 == dsim)
    { 
       f4 = @$"[{NPC}]: vou girar os dados vamos ver os resultados 
        ";
 

JOGO();
                                            }//destino sim 

    else if (destino3 == dnao)
{




}//destino nao  

    else if(destino3 == nNd)
    {
         dtaboa = 1;
         
     

        menu02();

    destino2 =Convert.ToInt32( Console.ReadLine());





    if (destino2 == dtaboa)
    {
        taboada();


    }
    
    else if (destino2 == d2)
{
        //terminar
     Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();



}

    
            }
    
                 

        
                                 }//destino nada 
                                                   

    else if (destino2 == d2)
      {
        
        Console.Clear();

    Console.ForegroundColor = ConsoleColor.Magenta;


    Console.Write("......Tabuada do número.....:");
    int numero = Convert.ToInt32(Console.ReadLine());

    int vezes = 0;

    int resultado;
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkGreen;


while ( vezes <= 10 )
{
    resultado = numero * vezes ;

    Console.Write($"{numero} X {vezes} = {resultado}\n");
    vezes += 1;
};




    Console.ResetColor();


    Console.WriteLine("Aquarde 5 segundos:");



        Thread.Sleep(5000);


    Console.WriteLine("   ___________________________");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |      [{}]         {[]}   |");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |             []           |");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |    [_________________]   |");
    Console.WriteLine("  |__________________________|");
     
     
      menu05();
     
     
     destino2 =Convert.ToInt32( Console.ReadLine());

    


     if (destino2 == d1)
     {
            //JOGO
        JOGO();
     
     }
     

    
    else if (destino2 == d2)
    {

      Console.Clear();
       Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();


Console.ResetColor();



    }//finalizar NPC


      }  




    else if (destino2 == d3)
    {
        Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();

    }


    else if (destino2 <= 0)   
      {



      }



    }    
        




        static void MENU01()
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(" =========================================================================== ");
        Console.WriteLine("|                             [1]---JOGAR--------                            |");
        Console.WriteLine("|                             [2]---TABOADA------                            |");                                          
        Console.WriteLine("|                             [3]---TERMINAR-----                            |");
        Console.WriteLine(" =========================================================================== ");
        Console.ResetColor();

        }


       static void menu02()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" =========================================================================== ");
            Console.WriteLine("|                             [1]---TABOADA----                             |");
            Console.WriteLine("|                             [2]---TERMINAR---                             |");
            Console.WriteLine(" =========================================================================== ");

            Console.ResetColor();


        }//menu3

  static void menu03()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" =========================================================================== ");
            Console.WriteLine("|                             [1]---PROIBIDO------                          |");
            Console.WriteLine("|                             [2]---TABOADA ------                          |");
            Console.WriteLine(" =========================================================================== ");
            Console.ResetColor();
        }
    
    

    static void menu05()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" =========================================================================== ");
            Console.WriteLine("|                             [1]---JOGAR----                             |");
            Console.WriteLine("|                             [3]---TERMINAR---                             |");
            Console.WriteLine(" =========================================================================== ");

            Console.ResetColor();

        }

    static void JOGO()
{


            //FOR DO JOGO COMPLETO 

        string NPC = "YUSANO";

      string f4 = @$"[{NPC}]: vou girar os dados vamos ver os resultados
        "; 
       for (int i14 = 0; i14 < f4.Length; i14++)
        {
            Console.Write(f4.ElementAt(i14));
            Thread.Sleep(60);
        }
      
       for (int i = 0; i < 6; i++)
       {
        
         NPC = "YUSANO";



        int valor = new Random().Next(1,100);
        int valor2 = new Random().Next(1,100);


        
       string  f5 = @$"[{NPC}]: os dados giraram e você tirou {valor} e eu tirei {valor2} 
        ";


       


        for (int i15 = 0; i15 < f5.Length; i15++)
        {
            
            Console.Write(f5.ElementAt(i15));
            Thread.Sleep(60);

        }


        


    if (valor > valor2)
    {
        string r1 = @$"{NPC}: Parabéns, você tirou um número maio que o meu você ganhou
        ";

        for (int i16 = 0; i16 < r1.Length; i16++)
        {
            Console.Write(r1.ElementAt(i16));
            Thread.Sleep(60);

        }


    }

    else if (valor < valor2)
    {
        string r2 = @$"{NPC}: Que pena para você e feliz para mim você perdeu 
        ";

    for (int i16 = 0; i16 < r2.Length; i16++)
        {
            Console.Write(r2.ElementAt(i16));
            Thread.Sleep(60);

        }

    }


        else if (valor == valor2)
        {
            string r3 = @$"{NPC}: Olha que coisa em empatamos 
            ";
        for (int i17 = 0; i17 < r3.Length; i17++)
        {
            Console.Write(r3.ElementAt(i17));
            Thread.Sleep(60);

        }


        }



        Thread.Sleep(100);


       } 

                    menu03();

            Console.Write("{ vou querer agora :");

        int destino04 = Convert.ToInt32(Console.ReadLine());
        
       int  d1 = 1;
       int  d2 = 2; 

        if (destino04 == d1)
        {
            Proibido();


        }

        if (destino04 == d2)
        {
            
            taboada();



        }


}


static void taboada()
{
         Console.Write("......Tabuada do número.....:");
    int numero = Convert.ToInt32(Console.ReadLine());

    int vezes = 0;

    int resultado;
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkGreen;


while ( vezes <= 10 )
{
    resultado = numero * vezes ;

    Console.Write($"{numero} X {vezes} = {resultado}\n");
    vezes += 1;
};




    Console.ResetColor();

        Console.WriteLine("AGUARDE 5 SEGUNDOS:");
        Thread.Sleep(5000); 
        Console.WriteLine(@"____________________
                            |                  |
                            | [____]     [___] |
                            |      {||||}      |
                            |                  |
                            | [______________] | 
                            |__________________|
        ");
    
     Console.WriteLine("Aquarde 5 segundos:");



        Thread.Sleep(5000);


    Console.WriteLine("   ___________________________");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |      [{}]         {[]}   |");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |             []           |");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |    [_________________]   |");
    Console.WriteLine("  |__________________________|");
     
     
      menu05();
     
     
     int destino2 =Convert.ToInt32( Console.ReadLine());
    int d1 = 1;
    int d2 = 2;



     if (destino2 == d1)
     {
         for (int i = 0; i < 10; i++)
       {
        
        string NPC = "YUSANO";



        int valor = new Random().Next(1,100);
        int valor2 = new Random().Next(1,100);


        string f4 = @$"[{NPC}]: vou girar os dados vamos ver os resultados
        "; 
       string  f5 = @$"[{NPC}]: os dados giraram e você tirou {valor} e eu tirei {valor2} 
        ";


        for (int i14 = 0; i14 < f4.Length; i14++)
        {
            Console.Write(f4.ElementAt(i14));
            Thread.Sleep(60);
        }


        for (int i15 = 0; i15 < f5.Length; i15++)
        {
            
            Console.Write(f5.ElementAt(i15));
            Thread.Sleep(60);

        }


        


    if (valor > valor2)
    {
        string r1 = @$"{NPC}: Parabéns, você tirou um número maio que o meu você ganhou
        ";

        for (int i16 = 0; i16 < r1.Length; i16++)
        {
            Console.Write(r1.ElementAt(i16));
            Thread.Sleep(60);

        }


    }

    else if (valor < valor2)
    {
        string r2 = @$"{NPC}: Que pena para você e feliz para mim você perdeu 
        ";

    for (int i16 = 0; i16 < r2.Length; i16++)
        {
            Console.Write(r2.ElementAt(i16));
            Thread.Sleep(60);

        }

    }


        else if (valor == valor2)
        {
            string r3 = @$"{NPC}: Olha que coisa em empatamos 
            ";
        for (int i17 = 0; i17 < r3.Length; i17++)
        {
            Console.Write(r3.ElementAt(i17));
            Thread.Sleep(60);

        }


        }



        Thread.Sleep(100);


       } 

                    menu02();

            Console.Write("{ vou querer agora :");

        int destino04 = Convert.ToInt32(Console.ReadLine());
        
         d1 = 1;
         d2 = 2; 

        if (destino04 == d1)
        {
            JOGO();


        }

        if (destino04 == d2)
        {
            
            terminar();



        }


}





}

static void terminar()
{
    string NPC = "YUSANO";


    Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
           
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");





Console.ResetColor();
}



static void Proibido()
{
    string NPC = "YUSANO";
    Console.WriteLine("DIGITE SEU NOME NOVAMENTE...:");
    string Nome = Convert.ToString(Console.ReadLine()! .ToUpper());


    string P1 = @$"{NPC}: {Nome}  PARECE QUE ALGUEM NÃO QUIS FAZER O QUE EU PEDI COM ISSO VOCÊ
    SOFRERA UMA PENALIDADE  PEQUENA TE PERDOU MAS NÃO ME DESOBEDEÇA NOVAMENTE QUANDO EU PEDIR
    ";

    string P2 = @$"{NPC}: SUA PENALIDADE É QUE EU VOU APAGAR TODOS OS SEU DADOS  , TOMAR SEU NOME
    E MESMO QUE SEJA FALSO EU VOU ACESSAR SEU COMPUTADOR E VOU ACHAR SEU VERDADEIRO NOME E VOU 
    SUBSTITUIR PARA O NOME QUE EU ESCOLHER 
     ..................
";

for (int i18 = 0; i18 < P1.Length; i18++)
{
    Console.Write(P1.ElementAt(i18));
    Thread.Sleep(60);


}

for (int i19 = 0; i19 < P2.Length; i19++)
{
    Console.Write(P2.ElementAt(i19));
    Thread.Sleep(60);


}

string nNome = Nome.Trim().ToLower()
            .Replace("a", "CU")
            .Replace("b", "NO")
            .Replace("c", "MI")
            .Replace("d", "LE")
            .Replace("e", "NO")
            .Replace("f", "LU")
            .Replace("g", "JI")
            .Replace("h", "RI")
            .Replace("i", "PA")
            .Replace("j", "ZUS")
            .Replace("k", "ME")
            .Replace("l", "PA")
            .Replace("m", "RIN")
            .Replace("n", "TE")
            .Replace("o", "CA")
            .Replace("p", "NO")
            .Replace("q", "CU")
            .Replace("r", "MIJA")
            .Replace("s", "ARI")
            .Replace("t", "CHI")
            .Replace("u", "VARA")
            .Replace("v", "CHU")
            .Replace("w", "MEI")
            .Replace("x", "NA")
            .Replace("y", "FU")
            .Replace("z", "ZI");


string  P3 = @$"{NPC}:ENCONTREI SEU NOME E JÁ VALIDEI E TROQUEI SEU NOME NO CARTORIO AGORA VOCÊ SE CHAMA {nNome}
";
string P4 = @$"{NPC}:{nNome} ESPERO QUE APRENDA UMA LIÇÃO E JÁ TA BOM POR HOJE VAMOS VOLTAR AOS COMANDOS 
";

for (int i20 = 0; i20 < P3.Length; i20++)
{
    Console.Write(P3.ElementAt(i20));
    Thread.Sleep(60);



}


for (int i21 = 0; i21 < P4.Length; i21++)
{
    Console.Write(P4.ElementAt(i21));
    Thread.Sleep(60);
}


 MENU01();

Console.Write(@$"{nNome}: eu vou para:");


int destino3 = Convert.ToInt32(Console.ReadLine());

if (destino3 <= 1)
{
    JOGO(); 
}

else if (destino3 == 2)
{
    taboada();
}

else if (destino3 >= 3)
{
 terminar();
}



}

static void lupe()
{
     int destino2;
        string f2;
        string f3;
        string f4;
     
        int valor = new Random().Next(1, 100);
        int valor2 = new Random().Next(1, 100);
        int dtaboa ;
  
        int d1;
        int d2;
        int d3;
        
        
        //nomes 
        string NPC = "YUSANO";

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.Write("Meu nome é ...:");
        string Nome =Convert.ToString( Console.ReadLine()!.ToUpper());


        //inicio 

        f2 = @$"[{NPC}]: {Nome}  Eu serei a pessoa que ira mostrar tudo que vai se passar neste projeto
mesmo ele não sendo muito grande ou muito menos detalhado  peço desculpas se tiver um erro  de 
português ou se ocorrer um erro no programa mas poder ocorrer por que ainda esta em fase de teste 
então peço que considere isso parando com todo esse bla bla bla vãos começar 


";

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;

        for (int i2 = 0; i2 < f2.Length; i2++)
        {
            Console.Write(f2.ElementAt(i2));
            Thread.Sleep(60);

        }


        f3 = $@"[{NPC}] Para começar te darei a opção de deixar eu escolher o que vai acontecer no projeto ou
você pode escolher o que você vai ver no projeto...:

";



       


        Console.ResetColor();

            d1 = 1;
            d2 = 2;
            d3 = 3;
       





            string dfala = @"Agora vou apresentar suas opçoes:
                      ";
            for (int i11 = 0; i11 < dfala.Length; i11++)
            {
                
                Console.Write(dfala.ElementAt(i11));
                Thread.Sleep(60);

            }


        Console.Clear();
            MENU01();

Console.Write(@$"{Nome}: Eu quero :");


 destino2 = Convert.ToInt32(Console.ReadLine());

        if (destino2 == d1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
           string f1 = $@"[{NPC}]: para começar {Nome} vamos jogar um jogo simples eu irei explicar as regras agora 

1.nos dois iremos ter 100 pontos de início e iremos girar dados para ver quem tira o maior número.


2.se a gente empatar ninguém perde ponto.


Agora que eu expliquei tudo vamos jogar..? 
";


            for (int i4 = 0; i4 < f1.Length; i4++)
            {
                Console.Write(f1.ElementAt(i4));
                Thread.Sleep(60);

            }
            Console.ResetColor();


            Console.Write($"{Nome}: Eu vou:");


            string dsim = "sim";
            string dnao = "Nao";
            string destino3 = Console.ReadLine()!;
            string nNd = "";


    if (destino3 == dsim)
    { 
       f4 = @$"[{NPC}]: vou girar os dados vamos ver os resultados 
        ";
 

JOGO();
                                            }//destino sim 

    else if (destino3 == dnao)
{




}//destino nao  

    else if(destino3 == nNd)
    {
         dtaboa = 1;
         
     

        menu02();

    destino2 =Convert.ToInt32( Console.ReadLine());





    if (destino2 == dtaboa)
    {
        taboada();


    }
    
    else if (destino2 == d2)
{
        //terminar
     Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();



}

    
            }
    
                 

        
                                 }//destino nada 
                                                   

    else if (destino2 == d2)
      {
        
        Console.Clear();

    Console.ForegroundColor = ConsoleColor.Magenta;


    Console.Write("......Tabuada do número.....:");
    int numero = Convert.ToInt32(Console.ReadLine());

    int vezes = 0;

    int resultado;
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkGreen;


while ( vezes <= 10 )
{
    resultado = numero * vezes ;

    Console.Write($"{numero} X {vezes} = {resultado}\n");
    vezes += 1;
};




    Console.ResetColor();


    Console.WriteLine("Aquarde 5 segundos:");



        Thread.Sleep(5000);


    Console.WriteLine("   ___________________________");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |      [{}]         {[]}   |");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |             []           |");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |    [_________________]   |");
    Console.WriteLine("  |__________________________|");
     
     
      menu05();
     
     
     destino2 =Convert.ToInt32( Console.ReadLine());

    


     if (destino2 == d1)
     {
            //JOGO
        JOGO();
     
     }
     

    
    else if (destino2 == d2)
    {

      Console.Clear();
       Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();


Console.ResetColor();



    }//finalizar NPC


      }  




    else if (destino2 == d3)
    {
        Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();

    }


    else if (destino2 <= 0)
    {
        MENU01();

        Console.Write(@$"{Nome}: Eu quero :");


 destino2 = Convert.ToInt32(Console.ReadLine());

        if (destino2 == d1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
           string  f1 = $@"[{NPC}]: para começar {Nome} vamos jogar um jogo simples eu irei explicar as regras agora 

1.nos dois iremos ter 100 pontos de início e iremos girar dados para ver quem tira o maior número.


2.se a gente empatar ninguém perde ponto.


Agora que eu expliquei tudo vamos jogar..? 
";


            for (int i4 = 0; i4 < f1.Length; i4++)
            {
                Console.Write(f1.ElementAt(i4));
                Thread.Sleep(60);

            }
            Console.ResetColor();


            Console.Write($"{Nome}: Eu vou:");


            string dsim = "sim";
            string dnao = "Nao";
            string destino3 = Console.ReadLine()!;
            string nNd = "";


    if (destino3 == dsim)
    { 
       f4 = @$"[{NPC}]: vou girar os dados vamos ver os resultados 
        ";
 

JOGO();
                                            }//destino sim 

    else if (destino3 == dnao)
{




}//destino nao  

    else if(destino3 == nNd)
    {
         dtaboa = 1;
         
     

        menu02();

    destino2 =Convert.ToInt32( Console.ReadLine());





    if (destino2 == dtaboa)
    {
        taboada();


    }
    
    else if (destino2 == d2)
{
        //terminar
     Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();



}

    
            }
    
                 

        
                                 }//destino nada 
                                                   

    else if (destino2 == d2)
      {
        
        Console.Clear();

    Console.ForegroundColor = ConsoleColor.Magenta;


    Console.Write("......Tabuada do número.....:");
    int numero = Convert.ToInt32(Console.ReadLine());

    int vezes = 0;

    int resultado;
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkGreen;


while ( vezes <= 10 )
{
    resultado = numero * vezes ;

    Console.Write($"{numero} X {vezes} = {resultado}\n");
    vezes += 1;
};




    Console.ResetColor();


    Console.WriteLine("Aquarde 5 segundos:");



        Thread.Sleep(5000);


    Console.WriteLine("   ___________________________");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |      [{}]         {[]}   |");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |             []           |");
    Console.WriteLine("  |                          |");
    Console.WriteLine("  |    [_________________]   |");
    Console.WriteLine("  |__________________________|");
     
     
      menu05();
     
     
     destino2 =Convert.ToInt32( Console.ReadLine());

    


     if (destino2 == d1)
     {
            //JOGO
        JOGO();
     
     }
     

    
    else if (destino2 == d2)
    {

      Console.Clear();
       Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();


Console.ResetColor();



    }//finalizar NPC


      }  




    else if (destino2 == d3)
    {
        Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

             string login = @"o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o=o
             ";
             
        for (int i13 = 2; i13 < login.Length; i13++)
        {
            Console.Write(login.ElementAt(i13));
            Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        

        }

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"[{NPC}]: ATE LOGO.....");


Console.ResetColor();

    }


    else if (destino2 <= 0)
    {
        lupe();

    }            


}            
        
      
    else if (destino2 >= 4)
{
    lupe();
}

}

