using Bus.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Concerete
{
    public class CommentManager:ICommentService
    {
        Repository<Comment> RComment=new Repository<Comment>();

        ICommentDAL _commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }
        public List<Comment> getById(int id)
        {
            return _commentDAL.findById(x=>x.BlogId==id);
        }
        public List<Comment> GetCommentsByStatusTrue()
        {
            return _commentDAL.getAll().Where(x=>x.CommentStatus==true).ToList();
        }
        public List<Comment> GetCommentsByStatusFalse()
        {
            return _commentDAL.getAll().Where(x=>x.CommentStatus ==false).ToList();
        }
        public void CommetStatusToFalse(int id)
        {
            var value= _commentDAL.getById(id);
            value.CommentStatus=false;
            _commentDAL.update(value);
        }
        public void CommetStatusToTrue(int id)
        {
            var value = _commentDAL.getById(id);
            value.CommentStatus = true;
            _commentDAL.update(value);
        }

        public List<Comment> GetList()
        {
            return _commentDAL.getAll();
        }

        public void AddComment(Comment comment)
        {
            _commentDAL.insert(comment);
        }

        public void DeleteComment(Comment comment)
        {
            _commentDAL.delete(comment);
        }

        public void UpdateComment(Comment comment)
        {
            _commentDAL.update(comment);
        }

        public Comment GetById(int id)
        {
            return _commentDAL.getById(id);
        }
    }
}
