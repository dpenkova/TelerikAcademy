﻿using System;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = Animals.Gender.Male;
        }
    }
}
