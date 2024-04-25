﻿using MediatR;
using System;


namespace DevFreela.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string FullName { get; set; }
        public string passwordHash { get; set; }
        public string Role {  get; set; } 
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}