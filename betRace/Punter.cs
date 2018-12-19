using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betRace
{
    class Punter
    {
        int amt;
        bool bustd;
        int csh;
        int Car;
        int myBet;
        string myLabel;
        string name;
        int wD;

        public Punter()                  //initializing punter attribute using constructor
        {
            this.amt = 0;
            this.bustd = false;
            this.csh = 0;
            this.Car = 0;
            this.myBet = 0;
            this.myLabel = "";
            this.name = "";
            this.wD = 0;

        }

        public int Amount(int mxBet)       // Max bet amount given to all punters
        {
            amt = mxBet;
            return amt;
        }

        public bool Busted()             // when punters have no cash to play bet 
        {
            if (csh <= 0)
                bustd = true;
            return bustd;
        }

        public int amtBet(int betPrice)   //how much amount they are going to bet
        {
            this.myBet = betPrice;
            return this.myBet;
        }

        public int cash()                      // Available amount for punters
        {
            this.csh = this.csh - this.myBet;
            return csh;
        }

        public int winCar()             // winning car number
        {
            Random r = new Random();
            wD = r.Next(1, 4);
            return wD;
        }

        public String getName(String name1)      // get Punters name 
        {
            this.name =  name1;
            return this.name;
        }
    }

    class Joe : Punter                    
    {
        public void joe()                      
        {
            Punter joeObj = new Punter();
            joeObj.getName("Joe");
            joeObj.cash();
        }
    }

    class Bob : Punter
    {
        public void bob()
        {
            Punter bobObj = new Punter();
            bobObj.getName("Bob");
            bobObj.cash();
        }
    }

    class AI : Punter
    {
        public void ai()
        {
            Punter aiObj = new Punter();
            aiObj.getName("AI");
            aiObj.cash();
        }
    }
}
