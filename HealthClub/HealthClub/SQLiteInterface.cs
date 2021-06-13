using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClub
{
    public interface SQLiteInterface
    {
        SQLiteConnection GetConnectionForDatabase();
    }
}
