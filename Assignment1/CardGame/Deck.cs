using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class Deck : Card
    {

        //存放54张带花色的牌的列表
        public List<Deck> allCard = new List<Deck>();
        
        public Deck()
        {
           
        }

        public Deck( suit cs,  rank cv) : base (cs, cv) {
            
        }

        //生成牌组，52张牌
        public List<Deck> createDeck(){
            for ( int i = 0; i < 4; i++)  {
                for ( int j=0; j < 13; j++){
                    allCard.Add(new Deck((suit)i,(rank)j));
                }      
            }
            return allCard;
        }

        //洗牌，随机生成下标，交换位置
        public void shuffle (){        
            Random random = new Random();
            for ( int i=allCard.Count-1;i>0; i--){
                //随机下标
                int index = random.Next(0,i);
                //随机出来的数与最后位置的数交换
                Deck temp = allCard[i];
                allCard[i] = allCard[index];
                allCard[index]=temp;        
            }
        }
    }
}
