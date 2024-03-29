﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12
{
    /// <summary>
    /// Класс "пользователь"
    /// Описывает атрибуты юзера
    /// </summary>
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string Login, string Name, bool IsPremium) 
        {     
            this.Login = Login;
            this.Name = Name;
            this.IsPremium = IsPremium;
        }
    }
}
