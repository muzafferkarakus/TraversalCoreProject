using BusinessLayer.Concrate;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        // FeatureManager featuremanager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
