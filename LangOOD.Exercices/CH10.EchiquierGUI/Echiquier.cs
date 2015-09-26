using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CH10.EchiquierGUI
{
    enum Pieces { roi, reine, dame, fou, cavalier, tour, pion }
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
            // Définition de la grille
            echiquier = new Pieces[8, 8];
            echiquier[0, 0] = Pieces.tour;
        }

        public List<Pieces> getPiecesLigne(int noLigne)
        {
            List<Pieces> listeP = new List<Pieces>();

            for (int i = 0; i < 7; i++)
            {
                listeP.Add(echiquier[noLigne, i]);                
            }

            return listeP;
        }


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

