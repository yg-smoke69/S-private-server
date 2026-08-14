using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B3B")]
internal class UISPHudMultiPlayerItemController : UIEasyListItemController
{
	[Token(Token = "0x401094C")]
	[FieldOffset(Offset = "0x38")]
	private UISPHudMultiPlayerItemView m_View;

	[Token(Token = "0x401094D")]
	[FieldOffset(Offset = "0x3C")]
	private List<UISPHudSinglePlayerItemController> m_Ctrl;

	[Token(Token = "0x6011CBC")]
	[Address(RVA = "0x1D22578", Offset = "0x1D22578", VA = "0x1D22578")]
	public UISPHudMultiPlayerItemController()
	{
	}

	[Token(Token = "0x6011CBD")]
	[Address(RVA = "0x1D22604", Offset = "0x1D22604", VA = "0x1D22604")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011CBE")]
	[Address(RVA = "0x1D226AC", Offset = "0x1D226AC", VA = "0x1D226AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011CBF")]
	[Address(RVA = "0x1D22768", Offset = "0x1D22768", VA = "0x1D22768", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011CC0")]
	[Address(RVA = "0x1D22E4C", Offset = "0x1D22E4C", VA = "0x1D22E4C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
