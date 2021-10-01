using Foundation;
using System;
using UIKit;
using WebKit;
using CoreGraphics;
using Binding;

namespace WKWebViewRTCXamarin
{
    public partial class ViewController : UIViewController
    {
        WKWebView webView;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            webView = new WKWebView(View.Frame, new WKWebViewConfiguration());
            View.AddSubview(webView);

            SwiftFrameworkProxy swiftFrameworkProxy = new SwiftFrameworkProxy();
            swiftFrameworkProxy.LoadWKWebViewRTCWithWebView(webView);

            var url = new NSUrl("https://webrtc.github.io/samples/src/content/getusermedia/gum/");
            var request = new NSUrlRequest(url);
            webView.LoadRequest(request);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}