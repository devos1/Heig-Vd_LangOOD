﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10.EchiquierCLI
{
    enum Pieces { roi, reine, dame, fou, cavalier, tour, pion, vide }

    class Program
    {
        static void Main(string[] args)
        {
            Pieces[,] echiquier = new Pieces[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    switch (i)
                    {
                        case 0:
                            // Ligne 1 - Pièces noires
                            switch (j)
                            {
                                case 0:
                                    echiquier[i, j] = Pieces.tour;
                                    break;
                                case 1:
                                    echiquier[i, j] = Pieces.cavalier;
                                    break;
                                case 2:
                                    echiquier[i, j] = Pieces.fou;
                                    break;
                                case 3:
                                    echiquier[i, j] = Pieces.reine;
                                    break;
                                case 4:
                                    echiquier[i, j] = Pieces.roi;
                                    break;
                                case 5:
                                    echiquier[i, j] = Pieces.fou;
                                    break;
                                case 6:
                                    echiquier[i, j] = Pieces.cavalier;
                                    break;
                                case 7:
                                    echiquier[i, j] = Pieces.tour;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 1:
                            // Ligne 2 - pions noirs
                            echiquier[i, j] = Pieces.pion;
                            break;
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            // Ligne 3, 4, 5, 6 - pions noirs
                            echiquier[i, j] = Pieces.vide;
                            break;
                        case 6:
                            // Ligne 7 - pions blancs
                            echiquier[i, j] = Pieces.pion;
                            break;
                        case 7:
                            // Ligne 8 - Pièces blanches
                            switch (j)
                            {
                                case 0:
                                    echiquier[i, j] = Pieces.tour;
                                    break;
                                case 1:
                                    echiquier[i, j] = Pieces.cavalier;
                                    break;
                                case 2:
                                    echiquier[i, j] = Pieces.fou;
                                    break;
                                case 3:
                                    echiquier[i, j] = Pieces.reine;
                                    break;
                                case 4:
                                    echiquier[i, j] = Pieces.roi;
                                    break;
                                case 5:
                                    echiquier[i, j] = Pieces.fou;
                                    break;
                                case 6:
                                    echiquier[i, j] = Pieces.cavalier;
                                    break;
                                case 7:
                                    echiquier[i, j] = Pieces.tour;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    } 
                }
            }

            //--------------------------------------------------------------
            // Affichage échiquier avec pièces
            //--------------------------------------------------------------
            Console.Write("|");
            
            // Ligne 1
            for (int i = 0; i < 8; i++)
            {
                Console.Write("{0,8}|", echiquier[0,i]);
            }
            Console.WriteLine("");
            Console.Write("|");
            
            // Ligne 2
            for (int i = 0; i < 8; i++)
            {
                Console.Write("{0,6} N|", echiquier[1, i]);
            }
            Console.WriteLine("");
            Console.Write("|");
            
            // Ligne 3 à 6
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0,8}|", echiquier[2,i]);
                }
                Console.WriteLine("");
                Console.Write("|");
            }
            
            // Ligne 7
            for (int i = 0; i < 8; i++)
            {
                Console.Write("{0,6} B|", echiquier[6, i]);
            }
            Console.WriteLine("");
            Console.Write("|");
           
            // Ligne 8
            for (int i = 0; i < 8; i++)
            {
                Console.Write("{0,8}|", echiquier[7, i]);
            }

            Console.WriteLine("");
        }
    }
}
