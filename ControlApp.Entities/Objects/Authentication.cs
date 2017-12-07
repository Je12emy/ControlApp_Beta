﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Authentication : BaseEntity
    {
        public int ID_User { get; set; }
        public string  User_nickname { get; set; }
        public string Password { get; set; }
        public int ID_Area { get; set; }
        public string Authentic_State { get; set; }
        public Authentication()
        {
            ID_User = 0;
            User_nickname = null;
            Password = null;
            ID_Area = 0;
            Authentic_State = null;
        }
        public Authentication(int pID_User, string pUser_nickname, string pPassword, int pID_Area, string pAuthentic_State)
        {
            this.ID_User = pID_User;
            this.User_nickname = pUser_nickname;
            this.Password = pPassword;
            this.ID_Area = pID_Area;
            this.Authentic_State = pAuthentic_State;
        }
    }
}
