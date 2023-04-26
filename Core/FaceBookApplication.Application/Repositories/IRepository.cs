﻿using Microsoft.EntityFrameworkCore;

namespace FaceBookApplication.Application.Repositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T>? Table { get; }
    }
}
