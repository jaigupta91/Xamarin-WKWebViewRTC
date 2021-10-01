using Foundation;
using WebKit;

namespace Binding
{
	// @interface SwiftFrameworkProxy : NSObject
	[BaseType(typeof(NSObject))]
	interface SwiftFrameworkProxy
	{
		// -(WKWebView * _Nonnull)loadWKWebViewRTCWithWebView:(WKWebView * _Nonnull)webView __attribute__((warn_unused_result("")));
		[Export("loadWKWebViewRTCWithWebView:")]
		WKWebView LoadWKWebViewRTCWithWebView(WKWebView webView);
	}
}
