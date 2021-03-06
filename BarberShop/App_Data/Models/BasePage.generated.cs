//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1072 with alias "basePage"
	/// <summary>Base Content</summary>
	public partial interface IBasePage : IPublishedContent
	{
		/// <summary>Body</summary>
		IHtmlString Body { get; }

		/// <summary>Image</summary>
		IPublishedContent Image { get; }

		/// <summary>Summary</summary>
		string Summary { get; }

		/// <summary>Title</summary>
		string Title { get; }
	}

	/// <summary>Base Content</summary>
	[PublishedContentModel("basePage")]
	public partial class BasePage : PublishedContentModel, IBasePage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Body
		///</summary>
		[ImplementPropertyType("body")]
		public IHtmlString Body
		{
			get { return GetBody(this); }
		}

		/// <summary>Static getter for Body</summary>
		public static IHtmlString GetBody(IBasePage that) { return that.GetPropertyValue<IHtmlString>("body"); }

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return GetImage(this); }
		}

		/// <summary>Static getter for Image</summary>
		public static IPublishedContent GetImage(IBasePage that) { return that.GetPropertyValue<IPublishedContent>("image"); }

		///<summary>
		/// Summary
		///</summary>
		[ImplementPropertyType("summary")]
		public string Summary
		{
			get { return GetSummary(this); }
		}

		/// <summary>Static getter for Summary</summary>
		public static string GetSummary(IBasePage that) { return that.GetPropertyValue<string>("summary"); }

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return GetTitle(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetTitle(IBasePage that) { return that.GetPropertyValue<string>("title"); }
	}
}
