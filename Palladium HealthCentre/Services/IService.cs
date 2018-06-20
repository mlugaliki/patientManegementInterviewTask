﻿using System.Collections.Generic;

namespace Palladium.HealthCentre.Services
{
    interface IService<T>
    {
        void Save(T obj);

        void Update(T obj);

        void Delete(T obj);

        List<T> GetAll();

        T GetById(long id);
    }
}