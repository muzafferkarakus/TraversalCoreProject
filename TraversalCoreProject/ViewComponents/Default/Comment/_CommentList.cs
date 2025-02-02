﻿using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default.Comment
{
    public class _CommentList: ViewComponent
    {
        CommentManager commentManager =new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            
            var values =commentManager.TGetDestinationById(id);
            return View(values);
        }
    }
}
