using System;

namespace Innlevering2
{
    public class Klokke
    {
        private  int sekund;
        private  int minutt;
        private int time;

        public Klokke()
        {
            
        }

        public Klokke( klSekund,  klMinutt,  klTime)
        {
            
        }

        public void setSekund( nySekund)
        {
            if ( nySekund > || nyMinutt < )
            {
                throw new Exception("Dette er ikke en gyldig verdi for sekund.");
            }
            sekund = ;
        }

        public int getSekund() => sekund;

        public void leggTilSekunder( antallSekund)
        {
            sekund += ;
            while (sekund > )
            {
                sekund -= ;
                (1);
            }
        }

        public void setMinutt( nyMinutt)
        {
            if ( || )
            {
                throw new Exception("Dette er ikke en gyldig verdi for minutt.");
            }
            minutt = ;
        }

        public int getMinutt() ;

        public void leggTilMinutter( antallMinutter)
        {
            minutt ;
            while ()
            {
                minutt ;
                ();
            }
        }

        public void setTime()
        {
            if ()
            {
                ("Dette er ikke en gyldig verdi for time.");
            }
            ;
        }

        public getTime();

        public void leggTilTimer()
        {
            ;
            while ()
            {
                ;
            }
        }

        public void tikk()
        {
            
        }

        private string tallToString( tall)
        {
            if (tall < )
            {
                return "0" + ;
            }
            return .ToString();
        }

        public override string ToString()
        {
            return tallToString() + ":" + 
                    () + "" + 
                    ();
        }
    }
}