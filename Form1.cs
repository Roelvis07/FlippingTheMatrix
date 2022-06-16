using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlippingTheMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<List<int>> arr = new List<List<int>>();

            //List<int> a = new List<int>() { 1, 2 };
            //List<int> a = new List<int>() { 112, 42, 83, 119 };
            List<int> a = new List<int>() { 107, 54, 128, 15 };
            arr.Add(a);

            //List<int> b = new List<int>() { 3, 4 };
            //List<int> b = new List<int>() { 56, 125, 56, 49 };
            List<int> b = new List<int>() { 12, 75, 110, 138 };
            arr.Add(b);
            
            //List<int> c = new List<int>() { 15, 78, 101, 43 };
            List<int> c = new List<int>() { 100, 96, 34, 85 };
            //List<int> c = new List<int>() { 15, 78, 101, 43 };
            arr.Add(c);

            //List<int> d = new List<int>() { 62, 98, 114, 108 };
            List<int> d = new List<int>() { 75, 15, 28, 112 };
            //List<int> d = new List<int>() { 62, 98, 114, 108 };
            arr.Add(d);
            /**/

            Console.WriteLine(flippingMatrix(arr));
        }
        public static int flippingMatrix(List<List<int>> matrix)
        {
            //int end = matrix.Count - 1;
            
            int sum = 0;

            for (int i = 0; i < matrix.Count / 2; i++)
            {
                for (int j = 0; j < matrix.Count / 2; j++)
                {
                    List<int> listAux = new List<int> { matrix[i][j], matrix[i][matrix.Count - 1 - j], matrix[matrix.Count - 1 - i][j], matrix[matrix.Count - 1 - i][matrix.Count - 1 - j] };
                    sum += listAux.Max();
                    
                }
            }

            return sum;
        }
    }
}
