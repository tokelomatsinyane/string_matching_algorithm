using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*C# PROGRAM SHOWING NAIVE STRING MATCHING ALGORITHM*/
namespace stringsearchtest
{
    public partial class stringsearch : Form
    {
        public stringsearch()
        {
            InitializeComponent();
        }

        public static void searchvowelindex(string phrase, string vowel)
        {
         



            int N = phrase.Length;
            int M = vowel.Length;
/*A LOOP TO SLIDE STRING CHARACTER ONE BY ONE*/
            for(int i=0; i <=N-M; i++)
            {
                
                //for current index search character match
                for (int j = 0; j < M; j++)
                {

                    if (phrase[i] != vowel[j])
                        break;
                    
                       if (phrase[i] == vowel[j])
                   
                        {
                           MessageBox.Show("The Matches are at positions: " + i);
                          
                        }

                       
                       else
                       {
                           MessageBox.Show("No Matches found");
                       }
                    

                }
               
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {

       
            string phrase = phrasetextbox.Text.Trim();      //retreaves phrase text
            string vowel = vowelinputtextbox.Text.Trim();    //retreaves vowel
            searchvowelindex(phrase, vowel);                 //search functon
          

         
        }

        private void phrasetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vowelinputtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}
