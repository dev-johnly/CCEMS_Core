﻿
using static Application.Models.DTOs.Auth.AuthenticationDTO;

namespace Application.Contracts.Services
{
    public interface IAuthService
    {
        Task<AuthResponse> AuthenticateAsync(string loginName, string password);
    }
}