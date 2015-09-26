using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CH10.EchiquierGUI
{
    enum Pieces { roi, reine, dame, fou, cavalier, tour, pion, vide }


    // Not Used
    struct Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return this.x;
        }
    
        public int getY()
        {
            return this.y;
        }
    }

    class Echiquier
    {
        private Pieces[,] echiquier;

        public  Echiquier()
        {
            // Définition et init de la grille
            echiquier = new Pieces[8, 8];
            initEchiquier();
        }

        private void initEchiquier()
        {
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
                            // Ligne 3, 4, 5, 6 - vide
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
        }

        public List<Pieces> getPiecesLigne(int noLigne)
        {
            List<Pieces> listeP = new List<Pieces>();

            for (int i = 0; i < 8; i++)
            {
                listeP.Add(echiquier[noLigne, i]);                
            }

            return listeP;
        }


        // Not Used
        public Pieces getPiecePosition(int x, int y)
        {
            Pieces piece = echiquier[x, y];
            return piece;
        }

        public Point? PlacerPiece(int x, int y, Pieces piece)
        {
            if (x < 0 || x > 7 || y < 0 || y > 7)
            {
                MessageBox.Show("Erreur, les positions x et y doivent être comprises entre 0 et 7");
                return null;
            }
            else
            {
                Point p = new Point(x, y);
                return p;
            }
        }
    }
}

