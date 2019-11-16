using Pchp.Core;
using PeachPied.WordPress.Sdk;

namespace PeachPied.Demo.Plugins
{
    public class DemoWidgetPlugin : IWpPlugin
    {
        WpApp app;

        public int RegisterMyWidget()
        { 
             this.app.Context.Call("register_widget", "DemoWidget");
             return 0;
        }

        public void Configure(WpApp app)
        {
            this.app = app;
            var demoWidget = new DemoWidget(app.Context);
            app.Context.Call("add_action", (PhpValue)"widgets_init", RegisterMyWidget());
        }
    }


    public class DemoWidget : WP_Widget
    {
        public DemoWidget(Context ctx) : base(ctx)
        {
        }

        public override PhpValue widget(PhpValue args, PhpValue instance)
        {
            return base.widget(args, instance);
        }
    }
}