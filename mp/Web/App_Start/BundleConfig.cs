using System.Web;
using System.Web.Optimization;

namespace Web
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                 "~/Scripts/jquery-1.11.1.js",
                 "~/Scripts/ember.js" ,
                 "~/Scripts/ember-template-compiler.js" ,
                 "~/Scripts/spa/app.js" ,
                 "~/Scripts/spa/router.js" ,
                 "~/Scripts/spa/mixins/api_mixin.js" ,
                 "~/Scripts/spa/controllers/base/base_controller.js",
                 "~/Scripts/spa/routes/start_route.js" ,
                 "~/Scripts/spa/routes/messages_route.js",
                 "~/Scripts/spa/routes/message_route.js" ,
                 "~/Scripts/spa/models/start_model.js",
                 "~/Scripts/spa/models/message_model.js" ,
                 "~/Scripts/spa/models/messages_model.js",
                 "~/Scripts/spa/controllers/start_controller.js" ,
                 "~/Scripts/spa/controllers/messages_controller.js" 
                ));

           

            BundleTable.EnableOptimizations = true;
        }
	}
}
