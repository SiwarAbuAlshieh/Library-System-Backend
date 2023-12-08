﻿using LibrarySystem.Core.Common;
using LibrarySystem.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Repository
{
    public interface IBookRepository
    {
        void CreateBook(Book book);
        void UpdateBook(int id, Book book);
        void DeleteBook(int id);
        Book GetBookById(int id);
        List<Book> GetAllBooks();
    }
}
