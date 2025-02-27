﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KakaoApiMapView
{
    public class MyLocale
    {
        public string Name { get; set; }//지역명
        public double Lat { get; set; }//위도
        public double Lng { get; set; }//경도

        public MyLocale(string name, double lat, double lng)
        {
            Name = name;
            Lat = lat;
            Lng = lng;
        }
        public override string ToString() //public override 까지 쓰면 자동완성
        {
            return Name;
        }
    }
}
