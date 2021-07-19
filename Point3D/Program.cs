using System;

namespace Point3D
{
     public class Point3d{
        private double x;
        private double y;
        private double z;
        
        public Point3d(double X, double Y, double Z){
            x = X;
            y = Y;
            z = Z;
        }
        public void MoveAlongY(double Y){
            y+=Y;
        }

        public void CastToXZ(){
            y=0;
        }
        public bool IsOnXZPlane(){
            if(y == 0){
                return true;
            }
            return false;
        }
        public bool IsOnPlane(){
            if((z != 0 && y==0 && x!=0)||(x == 0 && y!=0 && z!=0)||(x != 0 && y!=0 && z==0)){
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
