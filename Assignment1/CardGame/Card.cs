using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{

    class Card
    {        
       
        public suit cardShape;
        public rank cardValue;

        public enum suit {Spade, Heart, Diamond, Club}
        public enum rank {TWO=0, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, J, Q, K, Ace}

          

        //defaut constructor
        public Card() {}

        //constructor
        public Card (suit cs, rank cv){
            cardShape = cs;
            cardValue = cv;  
        }


        //methods
        //枚举访问器accessor
        public rank Rank {get;set;}
        public suit Suit{get;set;}


        //随机生成花色
        // public suit getRandomCardSuit() {
        //     var s = Enum.GetValues(typeof(suit));
        //     return (suit) s.GetValue(new Random().Next(s.Length));
        // }
        // //随机生成牌
        // public rank getRandomCardValue() {
        //     var v = Enum.GetValues(typeof(rank));
        //     return (rank)v.GetValue(new Random().Next(v.Length));    
        // }
    }
    
}


