﻿using FitTrackApp.WebAPI.DTOs;
using FitTrackApp.WebAPI.Models;

namespace FitTrackApp.WebAPI.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll(UserSearchDTO request);
        User GetById(int id);
        User Insert(UserUpsertDTO request);
        User Update(int id, UserUpsertDTO request);
    }
}
