﻿namespace App.Services.Dto.Auth;

public class UserInfoResult
{
    public string Id { get; set; }
    public string? FullName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public IEnumerable<string> Roles { get; set; }
}
