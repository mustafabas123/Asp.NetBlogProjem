using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetList();
        void AddComment(Comment comment);
        void DeleteComment(Comment comment);
        void UpdateComment(Comment comment);
        Comment GetById(int id);
    }
}
