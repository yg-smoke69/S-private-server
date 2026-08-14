using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F40")]
internal class UIFFWS03RulesPopupController : UICommonRulesPopupController
{
	[Token(Token = "0x6009A4D")]
	[Address(RVA = "0x1DB05CC", Offset = "0x1DB05CC", VA = "0x1DB05CC")]
	public UIFFWS03RulesPopupController()
	{
	}

	[Token(Token = "0x6009A4E")]
	[Address(RVA = "0x1DB05D4", Offset = "0x1DB05D4", VA = "0x1DB05D4")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009A4F")]
	[Address(RVA = "0x1DB067C", Offset = "0x1DB067C", VA = "0x1DB067C", Slot = "48")]
	public override List<RuleMapping>[] GetSelfRules()
	{
		return null;
	}

	[Token(Token = "0x6009A50")]
	[Address(RVA = "0x1DB0AD0", Offset = "0x1DB0AD0", VA = "0x1DB0AD0", Slot = "49")]
	public override UICommonRulesTabItemController GetTabItemContrller()
	{
		return null;
	}

	[Token(Token = "0x6009A51")]
	[Address(RVA = "0x1DB0BC4", Offset = "0x1DB0BC4", VA = "0x1DB0BC4")]
	public List<RuleMapping>[] _003C_003EiFixBaseProxy_GetSelfRules()
	{
		return null;
	}

	[Token(Token = "0x6009A52")]
	[Address(RVA = "0x1DB0BCC", Offset = "0x1DB0BCC", VA = "0x1DB0BCC")]
	public UICommonRulesTabItemController _003C_003EiFixBaseProxy_GetTabItemContrller()
	{
		return null;
	}
}
