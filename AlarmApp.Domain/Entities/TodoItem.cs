﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlarmApp.Domain.Shared;

namespace AlarmApp.Domain.Entities
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public TodoStatus Status { get; set; }

        protected TodoItem()
        {
        }

        public TodoItem(Guid id, string title, string description)
        {
            Id = id;
            SetTitle(title);
            SetDescription(description);
            Status = TodoStatus.Opened;
        }

        private void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException($"{nameof(Title)} can not be blank.");
            }

            Title = title;
        }

        private void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullException($"{nameof(Description)} can not be blank.");
            }

            Description = description;
        }

        internal void ChangeStatus(TodoStatus status)
        {
            Status = status;
        }
    }
}
