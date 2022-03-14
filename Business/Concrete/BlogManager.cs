using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess;
using Entities;

namespace Business.Concrete
{
    public class BlogManager : IBlogManager
    {
        private readonly BlogDbContext _context;

        public BlogManager(BlogDbContext context)
        {
            _context = context;
        }

        public void Create(Blog blog)
        {
            blog.UpdateDate = DateTime.Now;
            blog.PublishDate = DateTime.Now;
            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            var blogs = _context.Blogs.ToList();
            return blogs;
        }
    }
}
