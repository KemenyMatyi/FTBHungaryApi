﻿namespace FTBHungary.Data.Dtos;

using Models;

public class UserDto
{
    public Guid Guid { get; set; }
    public string FullName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string RoleName { get; set; }
}