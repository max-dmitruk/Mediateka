﻿using System;

namespace MediaBase
{
    public class Photo : Media
    {
        private string resolution;
        public string Resolution
        {
            get
            {
                return resolution;
            }
            set
            {
                resolution = value;
            }
        }

        public override void Play() {}
        public override void Add() {}
        public override void Delete(string name) {}
        public override string Search(string name)
        {
            return name;
        }
    }
}
