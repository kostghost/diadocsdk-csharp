using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Diadoc.Api.Com
{
	[ComVisible(true)]
	[Guid("FE21CF3E-D903-45A8-B7EF-3F646B9E0336")]
	//NOTE: Это хотели, чтобы можно было использовать XML-сериализацию для классов https://yt.skbkontur.ru/issue/ddsupport-373
	[XmlType(TypeName = "ResolutionType", Namespace = "https://diadoc-api.kontur.ru")]
	public enum ResolutionType
	{
		UndefinedResolutionType = Proto.Events.ResolutionType.UndefinedResolutionType,
		Approve = Proto.Events.ResolutionType.Approve,
		Disapprove = Proto.Events.ResolutionType.Disapprove,
		UnknownResolutionType = Proto.Events.ResolutionType.UnknownResolutionType
	}
}