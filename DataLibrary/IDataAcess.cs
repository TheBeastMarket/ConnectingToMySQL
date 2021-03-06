﻿using System.Collections.Generic;

namespace DataLibrary
{
    public interface IDataAcess
    {
        List<T> LoadData<T, U>(string sql, U parameters, string connectionString);
        void SaveData<T>(string sql, T parameters, string connectionString);
    }
}