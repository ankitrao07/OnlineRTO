using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace OnlineRTO
{
    public class Utility
    {
        public static string GenerateTempRegNo()
        {
            int lenthofpass = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["TempRegKey"].ToString());//6
            string allowedChars = "";
            //allowedChars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";
            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
            allowedChars += System.Configuration.ConfigurationManager.AppSettings["AllowedChars"].ToString();//"1,2,3,4,5,6,7,8,9,0";
            char[] sep = { ',' };
            string[] arr = allowedChars.Split(sep);
            string tempRegNoString = "";
            string temp = "";
            Random rand = new Random();
            for (int i = 0; i < lenthofpass; i++)
            {
                temp = arr[rand.Next(0, arr.Length)];
                tempRegNoString += temp;
            }
            return tempRegNoString;
        }

        public static string GenerateRegNo()
        {
            string stateCode = "HR";
            string disttCodeChar = string.Empty;
            string disttCodeN = string.Empty;
            string lastNoSeries = string.Empty;
            StringBuilder regNo = new StringBuilder();
            int lenthofpass = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["TempRegKey"].ToString());//6
            string allowedChars = "";
            string allowedDigits = "";
            //allowedChars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";
            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
            char[] sep = { ',' };
            string[] arr = allowedChars.Split(sep);
            string temp = "";
            Random rand = new Random();
            for (int i = 0; i < 2; i++)
            {
                temp = arr[rand.Next(0, arr.Length)];
                disttCodeChar += temp;
            }

            allowedDigits += System.Configuration.ConfigurationManager.AppSettings["AllowedChars"].ToString();//"1,2,3,4,5,6,7,8,9,0";
            string[] numberSeries = allowedDigits.Split(sep);
                       
            Random rand1 = new Random();
            for (int i = 0; i < 2; i++)
            {
                temp = numberSeries[rand1.Next(0, numberSeries.Length)];
                disttCodeN += temp;
            }

            Random rand2 = new Random();
            for (int i = 0; i < 4; i++)
            {
                temp = numberSeries[rand2.Next(0, numberSeries.Length)];
                lastNoSeries += temp;
            }
            regNo.Append(stateCode);
            regNo.Append("-");
            regNo.Append(disttCodeN);
            regNo.Append("-");
            regNo.Append(disttCodeChar);
            regNo.Append("-");
            regNo.Append(lastNoSeries);
            return regNo.ToString();
        }
    }
}