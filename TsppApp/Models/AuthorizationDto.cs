﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsppApp.Models
{
    public class AuthorizationDto
    {
        public string Login { get; init; } = string.Empty;
        public string Password { get; init; } = string.Empty;
    }
}
