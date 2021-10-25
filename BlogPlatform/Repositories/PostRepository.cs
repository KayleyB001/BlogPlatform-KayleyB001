using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BlogPlatform.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        public BlogContext db;


        //delete if in use
        //|
        //v
        public object Posts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public PostRepository(BlogContext db)
        {
            this.db = db;
        }





        //Create
        public void Create(Post obj)
        {
            db.Posts.Add(obj);
            db.SaveChanges();
        }
        //Read
        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post GetByID(int id)
        {
            return db.Posts.Find(id);
        }
        // Update
        public void Update(Post obj)
        {
            db.Posts.Update(obj);
            db.SaveChanges();
        }
        // Delete
        public void Delete(Post obj)
        {
            db.Posts.Remove(obj);
            db.SaveChanges();
        }

        

        
    }
}
