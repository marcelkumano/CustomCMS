//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.8.100
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

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "719bcb995208c915")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1075 with alias "paginaType"
	/// <summary>PaginaType</summary>
	public partial interface IPaginaType : IPublishedContent
	{
		/// <summary>Meta Description</summary>
		string MetaDescription { get; }

		/// <summary>Nome da Empresa</summary>
		string NomeEmpresa { get; }

		/// <summary>Texto</summary>
		string Texto { get; }

		/// <summary>Title</summary>
		string Title { get; }
	}

	/// <summary>PaginaType</summary>
	[PublishedContentModel("paginaType")]
	public partial class PaginaType : PublishedContentModel, IPaginaType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "paginaType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PaginaType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PaginaType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return GetMetaDescription(this); }
		}

		/// <summary>Static getter for Meta Description</summary>
		public static string GetMetaDescription(IPaginaType that) { return that.GetPropertyValue<string>("metaDescription"); }

		///<summary>
		/// Nome da Empresa
		///</summary>
		[ImplementPropertyType("nomeEmpresa")]
		public string NomeEmpresa
		{
			get { return GetNomeEmpresa(this); }
		}

		/// <summary>Static getter for Nome da Empresa</summary>
		public static string GetNomeEmpresa(IPaginaType that) { return that.GetPropertyValue<string>("nomeEmpresa"); }

		///<summary>
		/// Texto
		///</summary>
		[ImplementPropertyType("texto")]
		public string Texto
		{
			get { return GetTexto(this); }
		}

		/// <summary>Static getter for Texto</summary>
		public static string GetTexto(IPaginaType that) { return that.GetPropertyValue<string>("texto"); }

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return GetTitle(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetTitle(IPaginaType that) { return that.GetPropertyValue<string>("title"); }
	}

	/// <summary>HomeType</summary>
	[PublishedContentModel("homeType")]
	public partial class HomeType : PublishedContentModel, IPaginaType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homeType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomeType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomeType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Call to action
		///</summary>
		[ImplementPropertyType("callToAction")]
		public string CallToAction
		{
			get { return this.GetPropertyValue<string>("callToAction"); }
		}

		///<summary>
		/// Descricao
		///</summary>
		[ImplementPropertyType("descricao")]
		public string Descricao
		{
			get { return this.GetPropertyValue<string>("descricao"); }
		}

		///<summary>
		/// Titulo
		///</summary>
		[ImplementPropertyType("titulo")]
		public string Titulo
		{
			get { return this.GetPropertyValue<string>("titulo"); }
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetMetaDescription(this); }
		}

		///<summary>
		/// Nome da Empresa
		///</summary>
		[ImplementPropertyType("nomeEmpresa")]
		public string NomeEmpresa
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetNomeEmpresa(this); }
		}

		///<summary>
		/// Texto
		///</summary>
		[ImplementPropertyType("texto")]
		public string Texto
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetTexto(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetTitle(this); }
		}
	}

	/// <summary>ProdutoType</summary>
	[PublishedContentModel("produtoType")]
	public partial class ProdutoType : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "produtoType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProdutoType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProdutoType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Categoria
		///</summary>
		[ImplementPropertyType("categoria")]
		public string Categoria
		{
			get { return this.GetPropertyValue<string>("categoria"); }
		}

		///<summary>
		/// Descricao
		///</summary>
		[ImplementPropertyType("descricao")]
		public string Descricao
		{
			get { return this.GetPropertyValue<string>("descricao"); }
		}

		///<summary>
		/// ExibirHome
		///</summary>
		[ImplementPropertyType("exibirHome")]
		public bool ExibirHome
		{
			get { return this.GetPropertyValue<bool>("exibirHome"); }
		}

		///<summary>
		/// FotoHome
		///</summary>
		[ImplementPropertyType("fotoHome")]
		public IPublishedContent FotoHome
		{
			get { return this.GetPropertyValue<IPublishedContent>("fotoHome"); }
		}

		///<summary>
		/// Nome
		///</summary>
		[ImplementPropertyType("nome")]
		public string Nome
		{
			get { return this.GetPropertyValue<string>("nome"); }
		}

		///<summary>
		/// Ordem
		///</summary>
		[ImplementPropertyType("ordem")]
		public int Ordem
		{
			get { return this.GetPropertyValue<int>("ordem"); }
		}
	}

	/// <summary>ProdutosType</summary>
	[PublishedContentModel("produtosType")]
	public partial class ProdutosType : PublishedContentModel, IPaginaType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "produtosType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProdutosType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProdutosType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Descricao
		///</summary>
		[ImplementPropertyType("descricao")]
		public string Descricao
		{
			get { return this.GetPropertyValue<string>("descricao"); }
		}

		///<summary>
		/// ImagemPrincipal
		///</summary>
		[ImplementPropertyType("imagemPrincipal")]
		public IPublishedContent ImagemPrincipal
		{
			get { return this.GetPropertyValue<IPublishedContent>("imagemPrincipal"); }
		}

		///<summary>
		/// Titulo
		///</summary>
		[ImplementPropertyType("titulo")]
		public string Titulo
		{
			get { return this.GetPropertyValue<string>("titulo"); }
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetMetaDescription(this); }
		}

		///<summary>
		/// Nome da Empresa
		///</summary>
		[ImplementPropertyType("nomeEmpresa")]
		public string NomeEmpresa
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetNomeEmpresa(this); }
		}

		///<summary>
		/// Texto
		///</summary>
		[ImplementPropertyType("texto")]
		public string Texto
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetTexto(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetTitle(this); }
		}
	}

	/// <summary>NovidadesType</summary>
	[PublishedContentModel("novidadesType")]
	public partial class NovidadesType : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "novidadesType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NovidadesType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NovidadesType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Descricao
		///</summary>
		[ImplementPropertyType("descricao")]
		public string Descricao
		{
			get { return this.GetPropertyValue<string>("descricao"); }
		}

		///<summary>
		/// ImagemPrincipal
		///</summary>
		[ImplementPropertyType("imagemPrincipal")]
		public IPublishedContent ImagemPrincipal
		{
			get { return this.GetPropertyValue<IPublishedContent>("imagemPrincipal"); }
		}

		///<summary>
		/// Titulo
		///</summary>
		[ImplementPropertyType("titulo")]
		public string Titulo
		{
			get { return this.GetPropertyValue<string>("titulo"); }
		}
	}

	/// <summary>NovidadeType</summary>
	[PublishedContentModel("novidadeType")]
	public partial class NovidadeType : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "novidadeType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NovidadeType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NovidadeType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Categoria
		///</summary>
		[ImplementPropertyType("categoria")]
		public string Categoria
		{
			get { return this.GetPropertyValue<string>("categoria"); }
		}

		///<summary>
		/// Conteudo
		///</summary>
		[ImplementPropertyType("conteudo")]
		public IHtmlString Conteudo
		{
			get { return this.GetPropertyValue<IHtmlString>("conteudo"); }
		}

		///<summary>
		/// ImagemHome
		///</summary>
		[ImplementPropertyType("imagemHome")]
		public IPublishedContent ImagemHome
		{
			get { return this.GetPropertyValue<IPublishedContent>("imagemHome"); }
		}

		///<summary>
		/// ImagemPrincipal
		///</summary>
		[ImplementPropertyType("imagemPrincipal")]
		public IPublishedContent ImagemPrincipal
		{
			get { return this.GetPropertyValue<IPublishedContent>("imagemPrincipal"); }
		}

		///<summary>
		/// Resumo
		///</summary>
		[ImplementPropertyType("resumo")]
		public string Resumo
		{
			get { return this.GetPropertyValue<string>("resumo"); }
		}

		///<summary>
		/// Tags
		///</summary>
		[ImplementPropertyType("tags")]
		public IEnumerable<string> Tags
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("tags"); }
		}

		///<summary>
		/// Titulo
		///</summary>
		[ImplementPropertyType("titulo")]
		public string Titulo
		{
			get { return this.GetPropertyValue<string>("titulo"); }
		}
	}

	/// <summary>DestaqueType</summary>
	[PublishedContentModel("destaqueType")]
	public partial class DestaqueType : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "destaqueType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DestaqueType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DestaqueType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// DescricaoDestaque
		///</summary>
		[ImplementPropertyType("descricaoDestaque")]
		public string DescricaoDestaque
		{
			get { return this.GetPropertyValue<string>("descricaoDestaque"); }
		}

		///<summary>
		/// ImagemDestaque
		///</summary>
		[ImplementPropertyType("destaqueImage")]
		public IPublishedContent DestaqueImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("destaqueImage"); }
		}

		///<summary>
		/// LinkAcaoDestaque
		///</summary>
		[ImplementPropertyType("linkAcaoDestaque")]
		public string LinkAcaoDestaque
		{
			get { return this.GetPropertyValue<string>("linkAcaoDestaque"); }
		}

		///<summary>
		/// TextoAcaoDestaque
		///</summary>
		[ImplementPropertyType("textoAcaoDestaque")]
		public string TextoAcaoDestaque
		{
			get { return this.GetPropertyValue<string>("textoAcaoDestaque"); }
		}

		///<summary>
		/// TituloDestaque
		///</summary>
		[ImplementPropertyType("tituloDestaque")]
		public string TituloDestaque
		{
			get { return this.GetPropertyValue<string>("tituloDestaque"); }
		}
	}

	/// <summary>UnidadesType</summary>
	[PublishedContentModel("unidadesType")]
	public partial class UnidadesType : PublishedContentModel, IPaginaType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "unidadesType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UnidadesType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UnidadesType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Descricao
		///</summary>
		[ImplementPropertyType("descricao")]
		public string Descricao
		{
			get { return this.GetPropertyValue<string>("descricao"); }
		}

		///<summary>
		/// ImagemPrincipal
		///</summary>
		[ImplementPropertyType("imagemPrincipal")]
		public IPublishedContent ImagemPrincipal
		{
			get { return this.GetPropertyValue<IPublishedContent>("imagemPrincipal"); }
		}

		///<summary>
		/// Titulo
		///</summary>
		[ImplementPropertyType("titulo")]
		public string Titulo
		{
			get { return this.GetPropertyValue<string>("titulo"); }
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetMetaDescription(this); }
		}

		///<summary>
		/// Nome da Empresa
		///</summary>
		[ImplementPropertyType("nomeEmpresa")]
		public string NomeEmpresa
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetNomeEmpresa(this); }
		}

		///<summary>
		/// Texto
		///</summary>
		[ImplementPropertyType("texto")]
		public string Texto
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetTexto(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetTitle(this); }
		}
	}

	/// <summary>UnidadeType</summary>
	[PublishedContentModel("unidadeType")]
	public partial class UnidadeType : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "unidadeType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UnidadeType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UnidadeType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// DescricaoUnidade
		///</summary>
		[ImplementPropertyType("descricaoUnidade")]
		public string DescricaoUnidade
		{
			get { return this.GetPropertyValue<string>("descricaoUnidade"); }
		}

		///<summary>
		/// EnderecoUnidade
		///</summary>
		[ImplementPropertyType("enderecoUnidade")]
		public string EnderecoUnidade
		{
			get { return this.GetPropertyValue<string>("enderecoUnidade"); }
		}

		///<summary>
		/// FotoPrincipal
		///</summary>
		[ImplementPropertyType("fotoPrincipal")]
		public IPublishedContent FotoPrincipal
		{
			get { return this.GetPropertyValue<IPublishedContent>("fotoPrincipal"); }
		}

		///<summary>
		/// HorarioFuncionamento
		///</summary>
		[ImplementPropertyType("horarioFuncionamento")]
		public string HorarioFuncionamento
		{
			get { return this.GetPropertyValue<string>("horarioFuncionamento"); }
		}

		///<summary>
		/// MiniaturaLoja
		///</summary>
		[ImplementPropertyType("miniaturaLoja")]
		public IPublishedContent MiniaturaLoja
		{
			get { return this.GetPropertyValue<IPublishedContent>("miniaturaLoja"); }
		}

		///<summary>
		/// NomeUnidade
		///</summary>
		[ImplementPropertyType("nomeUnidade")]
		public string NomeUnidade
		{
			get { return this.GetPropertyValue<string>("nomeUnidade"); }
		}
	}

	/// <summary>SobreType</summary>
	[PublishedContentModel("sobreType")]
	public partial class SobreType : PublishedContentModel, IPaginaType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sobreType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SobreType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SobreType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Descricao
		///</summary>
		[ImplementPropertyType("descricao")]
		public string Descricao
		{
			get { return this.GetPropertyValue<string>("descricao"); }
		}

		///<summary>
		/// ImagemPrincipal
		///</summary>
		[ImplementPropertyType("imagemPrincipal")]
		public IPublishedContent ImagemPrincipal
		{
			get { return this.GetPropertyValue<IPublishedContent>("imagemPrincipal"); }
		}

		///<summary>
		/// Titulo
		///</summary>
		[ImplementPropertyType("titulo")]
		public string Titulo
		{
			get { return this.GetPropertyValue<string>("titulo"); }
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetMetaDescription(this); }
		}

		///<summary>
		/// Nome da Empresa
		///</summary>
		[ImplementPropertyType("nomeEmpresa")]
		public string NomeEmpresa
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetNomeEmpresa(this); }
		}

		///<summary>
		/// Texto
		///</summary>
		[ImplementPropertyType("texto")]
		public string Texto
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetTexto(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.PaginaType.GetTitle(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
