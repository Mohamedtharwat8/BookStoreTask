﻿using BookStoreTask.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Books.Commands.CreateBook
{
    public  class CreateBookCommand : IRequest<Guid>
    {

        public Guid BookId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public string? Author { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int Quantity { get; set; }
        public Guid CategoryId { get; set; }
      
        public override string ToString()
        {
            return $"Book name: {Name}; Price: {Price}; By:" +
                $" {Author}; On: {Date.ToShortDateString()};" +
                $" Description: {Description}";
        }
    }
}
