using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002563")]
public class UIClanWarPreviewWndController : UIPopupWindowController
{
	[Token(Token = "0x400E777")]
	[FieldOffset(Offset = "0x48")]
	private UIClanWarPreviewWndView m_View;

	[Token(Token = "0x600DA52")]
	[Address(RVA = "0x29047DC", Offset = "0x29047DC", VA = "0x29047DC")]
	public UIClanWarPreviewWndController()
	{
	}

	[Token(Token = "0x600DA53")]
	[Address(RVA = "0x29047E4", Offset = "0x29047E4", VA = "0x29047E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA54")]
	[Address(RVA = "0x2904888", Offset = "0x2904888", VA = "0x2904888", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA55")]
	[Address(RVA = "0x290390C", Offset = "0x290390C", VA = "0x290390C")]
	public void SetViewData(List<BaseItemInfo> infos)
	{
	}

	[Token(Token = "0x600DA56")]
	[Address(RVA = "0x29049E4", Offset = "0x29049E4", VA = "0x29049E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
