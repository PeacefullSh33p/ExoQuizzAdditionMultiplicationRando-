using System;

namespace SuiteProg1
{// Pour déclarer un tableau : int[] array1 = new int[5]
 // Declare and set array element values:
 // int[] array2 = new int[] {1,3,5,7,9};

    // Declare a two dimensionnal array : int[,] multiDimensionalArray1 = new int[2,3];
    //Declare and set array elements values : int[,] multiDimensioalArray2 = {{1,2,3},{4,5,6}};

    /* int[] array3 = new int[5]
             */

    //for (int i = 0; i < array.GetLength(0); i++)
    //{
    // for (int j = 0; j < array.GetLength(1); j++)
    /* {
     *  Console.Write("{0} ", array[i, j]);
     *  }
     *  Console. WriteLine();
     *  }*/






    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            const int pile = 1;
            const int face = 2;
            const int min = 0; // min Nombre
            const int max = 9; // Max Nombre
            int val1 = rand.Next(min, max + 1);//1ere valeur de la  question.
            int val2 = rand.Next(min, max + 1);//2nd valeur de la  question.
            int mul = rand.Next(pile | face);//multiplie les valeurs de manière random



            int add = rand.Next(pile | face);//additione les valeurs de manière random
            int nbTotalQuestion = 6;
            int NumeroQuestion = 0;
            int BonneRéponse = 1;
            int MauvaiseRéponse = 1;
//-------------------------------------------------------------------------------------------------------------------------------------------//
//-------------------------------------------------------------------------------------------------------------------------------------------//
            for (int i = 0; i == NumeroQuestion++;)// boucle for 1ere question
            {
                val1 = rand.Next(min, max + 1);//1ere valeur de la  question.
                val2 = rand.Next(min, max + 1);//2nd valeur de la  question.
                mul = rand.Next(pile | face);//multiplie les valeurs de manière random
                add = rand.Next(pile | face);//addtionne les valeurs de manière random


                if (NumeroQuestion == 1)
                {

                    Console.WriteLine("Question n°" + NumeroQuestion + "/" + nbTotalQuestion);

                    if (mul == pile)
                    {
                        mul = rand.Next(pile | face); //multiplie les valeurs de manière random
                        Console.WriteLine(val1 + "x" + val2);
                        string réponse = Console.ReadLine();// saisi l'entrée du joueur
                        int RP = int.Parse(réponse);
                        if (val1 * val2 == RP)
                        {

                            Console.WriteLine("GG !");

                            Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                        }

                        else if (val1 * val2 != RP)
                        {
                            Console.WriteLine("SEGPA Tier");

                            Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                        }
                    }



                    if (mul != pile)
                    {
                        add = rand.Next(pile | face); //addtione les valeurs de manière random
                        Console.WriteLine(val1 + "+" + val2);
                        string réponse = Console.ReadLine();// saisi l'entrée du joueur
                        int RP = int.Parse(réponse);

                        if (val1 + val2 == RP)
                        {

                            Console.WriteLine("GG !");

                            Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                        }


                        if (val1 + val2 != RP)
                        {
                            Console.WriteLine("SEGPA Tier");

                            Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                        }

                    }
//-------------------------------------------------------------------------------------------------------------------------------------------//
                    for (int i1 = 1; i1 == NumeroQuestion++;) //bocule for 2nd Question
                    {
                        val1 = rand.Next(min, max + 1);//1ere valeur de la  question.
                        val2 = rand.Next(min, max + 1);//2nd valeur de la  question.
                        mul = rand.Next(pile | face);//multiplie les valeurs de manière random
                        add = rand.Next(pile | face);//addtionne les valeurs de manière random


                        if (NumeroQuestion == 2)
                        {

                            Console.WriteLine("Question n°" + NumeroQuestion + "/" + nbTotalQuestion);

                            if (mul == pile)
                            {
                                mul = rand.Next(pile | face); //multiplie les valeurs de manière random
                                Console.WriteLine(val1 + "x" + val2);
                                string réponse = Console.ReadLine();// saisi l'entrée du joueur
                                int RP = int.Parse(réponse);
                                if (val1 * val2 == RP)
                                {

                                    Console.WriteLine("GG !");

                                    Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                                }

                                else if (val1 * val2 != RP)
                                {
                                    Console.WriteLine("SEGPA Tier");

                                    Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                                }
                            }



                            if (mul != pile)
                            {
                                add = rand.Next(pile | face); //addtione les valeurs de manière random
                                Console.WriteLine(val1 + "+" + val2);
                                string réponse = Console.ReadLine();// saisi l'entrée du joueur
                                int RP = int.Parse(réponse);

                                if (val1 + val2 == RP)
                                {

                                    Console.WriteLine("GG !");

                                    Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                                }


                                if (val1 + val2 != RP)
                                {
                                    Console.WriteLine("SEGPA Tier");

                                    Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                                }

                            }
//-------------------------------------------------------------------------------------------------------------------------------------------//                            


                            for (int i2 = 2; i2 == NumeroQuestion++;)//Boucle 3ième question
                            {
                                val1 = rand.Next(min, max + 1);//1ere valeur de la  question.
                                val2 = rand.Next(min, max + 1);//2nd valeur de la  question.
                                mul = rand.Next(pile | face);//multiplie les valeurs de manière random
                                add = rand.Next(pile | face);//addtionne les valeurs de manière random


                                if (NumeroQuestion == 3)
                                {

                                    Console.WriteLine("Question n°" + NumeroQuestion + "/" + nbTotalQuestion);

                                    if (mul == pile)
                                    {
                                        mul = rand.Next(pile | face); //multiplie les valeurs de manière random
                                        Console.WriteLine(val1 + "x" + val2);
                                        string réponse = Console.ReadLine();// saisi l'entrée du joueur
                                        int RP = int.Parse(réponse);
                                        if (val1 * val2 == RP)
                                        {

                                            Console.WriteLine("GG !");

                                            Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                                        }

                                        else if (val1 * val2 != RP)
                                        {
                                            Console.WriteLine("SEGPA Tier");

                                            Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                                        }
                                    }



                                    if (mul != pile)
                                    {
                                        add = rand.Next(pile | face); //addtione les valeurs de manière random
                                        Console.WriteLine(val1 + "+" + val2);
                                        string réponse = Console.ReadLine();// saisi l'entrée du joueur
                                        int RP = int.Parse(réponse);

                                        if (val1 + val2 == RP)
                                        {

                                            Console.WriteLine("GG !");

                                            Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                                        }


                                        if (val1 + val2 != RP)
                                        {
                                            Console.WriteLine("SEGPA Tier");

                                            Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                                        }

                                    
                                    }
                                }
                            }

//-------------------------------------------------------------------------------------------------------------------------------------------//
                            for (int i3 = 3; i3 == NumeroQuestion++;)//Boucle 3ième question
                            {
                                val1 = rand.Next(min, max + 1);//1ere valeur de la  question.
                                val2 = rand.Next(min, max + 1);//2nd valeur de la  question.
                                mul = rand.Next(pile | face);//multiplie les valeurs de manière random
                                add = rand.Next(pile | face);//addtionne les valeurs de manière random


                                if (NumeroQuestion == 4)
                                {

                                    Console.WriteLine("Question n°" + NumeroQuestion + "/" + nbTotalQuestion);

                                    if (mul == pile)
                                    {
                                        mul = rand.Next(pile | face); //multiplie les valeurs de manière random
                                        Console.WriteLine(val1 + "x" + val2);
                                        string réponse = Console.ReadLine();// saisi l'entrée du joueur
                                        int RP = int.Parse(réponse);
                                        if (val1 * val2 == RP)
                                        {

                                            Console.WriteLine("GG !");

                                            Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                                        }

                                        else if (val1 * val2 != RP)
                                        {
                                            Console.WriteLine("SEGPA Tier");

                                            Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                                        }
                                    }



                                    if (mul != pile)
                                    {
                                        add = rand.Next(pile | face); //addtione les valeurs de manière random
                                        Console.WriteLine(val1 + "+" + val2);
                                        string réponse = Console.ReadLine();// saisi l'entrée du joueur
                                        int RP = int.Parse(réponse);

                                        if (val1 + val2 == RP)
                                        {

                                            Console.WriteLine("GG !");

                                            Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                                        }


                                        if (val1 + val2 != RP)
                                        {
                                            Console.WriteLine("SEGPA Tier");

                                            Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                                        }


                                    }
                                }
                            }
 //-------------------------------------------------------------------------------------------------------------------------------------------//

                            for (int i4 = 4; i4 == NumeroQuestion++;)//Boucle 4ième question
                            {
                                val1 = rand.Next(min, max + 1);//1ere valeur de la  question.
                                val2 = rand.Next(min, max + 1);//2nd valeur de la  question.
                                mul = rand.Next(pile | face);//multiplie les valeurs de manière random
                                add = rand.Next(pile | face);//addtionne les valeurs de manière random


                                if (NumeroQuestion == 5)
                                {

                                    Console.WriteLine("Question n°" + NumeroQuestion + "/" + nbTotalQuestion);

                                    if (mul == pile)
                                    {
                                        mul = rand.Next(pile | face); //multiplie les valeurs de manière random
                                        Console.WriteLine(val1 + "x" + val2);
                                        string réponse = Console.ReadLine();// saisi l'entrée du joueur
                                        int RP = int.Parse(réponse);
                                        if (val1 * val2 == RP)
                                        {

                                            Console.WriteLine("GG !");

                                            Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                                        }

                                        else if (val1 * val2 != RP)
                                        {
                                            Console.WriteLine("SEGPA Tier");

                                            Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                                        }
                                    }



                                    if (mul != pile)
                                    {
                                        add = rand.Next(pile | face); //addtione les valeurs de manière random
                                        Console.WriteLine(val1 + "+" + val2);
                                        string réponse = Console.ReadLine();// saisi l'entrée du joueur
                                        int RP = int.Parse(réponse);

                                        if (val1 + val2 == RP)
                                        {

                                            Console.WriteLine("GG !");

                                            Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                                        }


                                        if (val1 + val2 != RP)
                                        {
                                            Console.WriteLine("SEGPA Tier");

                                            Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                                        }


                                    }
                                }
                            }
 //-------------------------------------------------------------------------------------------------------------------------------------------//
                            for (int i5 = 5; i5 == NumeroQuestion++;)//Boucle for 6ième question
                            {
                                val1 = rand.Next(min, max + 1);//1ere valeur de la  question.
                                val2 = rand.Next(min, max + 1);//2nd valeur de la  question.
                                mul = rand.Next(pile | face);//multiplie les valeurs de manière random
                                add = rand.Next(pile | face);//addtionne les valeurs de manière random


                                if (NumeroQuestion == 6)
                                {

                                    Console.WriteLine("Question n°" + NumeroQuestion + "/" + nbTotalQuestion);

                                    if (mul == pile)
                                    {
                                        mul = rand.Next(pile | face); //multiplie les valeurs de manière random
                                        Console.WriteLine(val1 + "x" + val2);
                                        string réponse = Console.ReadLine();// saisi l'entrée du joueur
                                        int RP = int.Parse(réponse);
                                        if (val1 * val2 == RP)
                                        {

                                            Console.WriteLine("GG !");

                                            Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                                        }

                                        else if (val1 * val2 != RP)
                                        {
                                            Console.WriteLine("SEGPA Tier");

                                            Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                                        }
                                    }



                                    if (mul != pile)
                                    {
                                        add = rand.Next(pile | face); //addtione les valeurs de manière random
                                        Console.WriteLine(val1 + "+" + val2);
                                        string réponse = Console.ReadLine();// saisi l'entrée du joueur
                                        int RP = int.Parse(réponse);

                                        if (val1 + val2 == RP)
                                        {

                                            Console.WriteLine("GG !");

                                            Console.WriteLine(" nb Bonne réponse" + BonneRéponse++ + " " + "/" + "6");
                                        }


                                        if (val1 + val2 != RP)
                                        {
                                            Console.WriteLine("SEGPA Tier");

                                            Console.WriteLine(" Mauvaise réponse " + "" + MauvaiseRéponse++ + "" + "/" + "6");
                                        }


                                    }
                                    
                                    if (NumeroQuestion == nbTotalQuestion)
                                    {
                                        Console.WriteLine("Le test est fini");
                                        Console.WriteLine(BonneRéponse + "/" + "6");
                                        Console.WriteLine(MauvaiseRéponse + "/" + "6");
                                    }
                                }


                                

                            }









                        }
                    }

                }
            }
        }
    }
}















































        

              
    








