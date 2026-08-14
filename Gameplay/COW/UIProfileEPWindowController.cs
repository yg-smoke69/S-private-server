using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A9A")]
public class UIProfileEPWindowController : UIPopupWindowController
{
	[Token(Token = "0x40105CE")]
	[FieldOffset(Offset = "0x48")]
	private UIProfileEpWindowShowView m_View;

	[Token(Token = "0x6011662")]
	[Address(RVA = "0x16D6408", Offset = "0x16D6408", VA = "0x16D6408")]
	public UIProfileEPWindowController()
	{
	}

	[Token(Token = "0x6011663")]
	[Address(RVA = "0x16D6410", Offset = "0x16D6410", VA = "0x16D6410")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011664")]
	[Address(RVA = "0x16D64B4", Offset = "0x16D64B4", VA = "0x16D64B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011665")]
	[Address(RVA = "0x16D6570", Offset = "0x16D6570", VA = "0x16D6570")]
	public void SetUIdata(List<BasicEPInfo> info)
	{
	}

	[Token(Token = "0x6011666")]
	[Address(RVA = "0x16D67D8", Offset = "0x16D67D8", VA = "0x16D67D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
