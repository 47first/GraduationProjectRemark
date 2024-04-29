﻿namespace WinFormsApplication.Services
{
    public interface IAuthorizationService
    {
        public bool IsAuthorized { get; }

        public int? UserId { get; }

        public void SingIn(string login, string password);

        public void Logout();
    }
}