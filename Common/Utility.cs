﻿using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}