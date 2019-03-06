﻿using DBEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Provider
{
    public interface IOnlineStoreProvider
    {
        IEnumerable<BookOnlineStore> GetAllBooks();
    }
}
