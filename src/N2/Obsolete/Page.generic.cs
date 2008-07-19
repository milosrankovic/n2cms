using System;
using System.Web;
using N2.Engine;

namespace N2.Web.UI
{
    /// <summary>
    /// This class name has been deprecated. Page base class that provides easy access to the current page item.
    /// </summary>
	/// <typeparam name="PageT">The type of content item served by the page inheriting this class.</typeparam>
    [Obsolete("Please use N2.Web.UI.ContentPage instead.")]
    public abstract class Page<TPage> : ContentPage<TPage>
        where TPage : N2.ContentItem
    {
	}
}
