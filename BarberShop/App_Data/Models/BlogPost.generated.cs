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
	/// <summary>Blog Post</summary>
	[PublishedContentModel("blogPost")]
	public partial class BlogPost : PublishedContentModel, IBasePage, ISEocontent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Body
		///</summary>
		[ImplementPropertyType("body")]
		public IHtmlString Body
		{
			get { return Umbraco.Web.PublishedContentModels.BasePage.GetBody(this); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return Umbraco.Web.PublishedContentModels.BasePage.GetImage(this); }
		}

		///<summary>
		/// Summary
		///</summary>
		[ImplementPropertyType("summary")]
		public string Summary
		{
			get { return Umbraco.Web.PublishedContentModels.BasePage.GetSummary(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.BasePage.GetTitle(this); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.SEocontent.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.SEocontent.GetMetaTitle(this); }
		}
	}
}
