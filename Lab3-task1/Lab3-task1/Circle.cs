using System;

namespace Lab3_task1{
    class Circle{
        private String name;
        private double raduis=0.0;

        //default constructor
        public Circle(){

        } 

        //constructor
        public Circle(String n, double r)
        {
            name = n;
            raduis = r;
        }

        //get circle area method
        public double CircleArea(){
            return Math.PI * raduis * raduis;
        }

        //Accessor methods 
        public String cName(){
            return name;
        }

        public double cRadius(){
            return raduis;    
        } 

        //Comparing the radius value, data tyoe is bool
        public bool Is_Greater_Than(Circle other){
            // Note keyword "this", Call cRadius() in Circle object passed as argument 
            if (this.cRadius() > other.cRadius()){
                return true;
            } 
            else
                return false; 
        }
   }
}