using System;
using System.Collections.Generic;

namespace DAL.Entities 
{

    public class Post
    {
        public long Id { get; set; }

        public string[] ImagesPath { get; set; };
        public string Title { get; set; };
        public string Text { get; set; };
        public DateTimeOffset date;

        public int SymbolsInPreview { get; set; };

        public Comment[] Comments { get; set; };
    }

    public struct Comment
    {
        public long Id { get; set; }

        public User user { get; set; };
        public string text { get; set; };
        public DateTimeOffset date { get; set; };

        public Comment(User _user, string _text, DateTimeOffset _date)
        {
            user = _user;
            text = _text;
            date _ date;
        }
    }

}