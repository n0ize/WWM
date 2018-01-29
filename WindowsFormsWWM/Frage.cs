using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsWWM
{
    class Frage
    {
        private int id;
        private String frageText;
        private String[] antwortarray = new string[4];
        private int schwierigkeit;

        public Frage()
        {

        }
        public Frage(int id,string frageText,String[] aa,int schwierigkeit)
        {
            this.Id = id;
            this.FrageText = frageText;
            this.Antwortarray = aa;
            this.Schwierigkeit = schwierigkeit;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string FrageText
        {
            get
            {
                return frageText;
            }

            set
            {
                frageText = value;
            }
        }

        public string[] Antwortarray
        {
            get
            {
                return antwortarray;
            }

            set
            {
                antwortarray = value;
            }
        }

        public int Schwierigkeit
        {
            get
            {
                return schwierigkeit;
            }

            set
            {
                schwierigkeit = value;
            }
        }
    }
}
