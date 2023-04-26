using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitGenius
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
