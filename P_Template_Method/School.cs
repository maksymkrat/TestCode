﻿using System;

namespace P_Template_Method
{
    public class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Идем в первый класс");
        }
 
        public override void Study()
        {
            Console.WriteLine("Посещаем уроки, делаем домашние задания");
        }
 
        public override void GetDocument()
        {
            Console.WriteLine("Получаем аттестат о среднем образовании");
        }
    }
}