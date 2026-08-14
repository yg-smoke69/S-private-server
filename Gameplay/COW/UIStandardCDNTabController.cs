using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023B4")]
public class UIStandardCDNTabController : UIStandardTabController
{
	[Token(Token = "0x400DE49")]
	[FieldOffset(Offset = "0x34")]
	private int[] m_States;

	[Token(Token = "0x400DE4A")]
	[FieldOffset(Offset = "0x38")]
	private UIModelNewPlayer m_ModelPlayer;

	[Token(Token = "0x600C8DB")]
	[Address(RVA = "0x2062824", Offset = "0x2062824", VA = "0x2062824")]
	public UIStandardCDNTabController()
	{
	}

	[Token(Token = "0x600C8DC")]
	[Address(RVA = "0x20628AC", Offset = "0x20628AC", VA = "0x20628AC")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C8DD")]
	[Address(RVA = "0x2062954", Offset = "0x2062954", VA = "0x2062954", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C8DE")]
	[Address(RVA = "0x2062C24", Offset = "0x2062C24", VA = "0x2062C24", Slot = "33")]
	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C8DF")]
	[Address(RVA = "0x2062D70", Offset = "0x2062D70", VA = "0x2062D70")]
	public void UpdateTabStates()
	{
	}

	[Token(Token = "0x600C8E0")]
	[Address(RVA = "0x2063454", Offset = "0x2063454", VA = "0x2063454")]
	public new UIStandardCDNTabItemController GetTabItemControllerByIndex(int index, bool needScroll = true)
	{
		return null;
	}

	[Token(Token = "0x600C8E1")]
	[Address(RVA = "0x2063558", Offset = "0x2063558", VA = "0x2063558")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C8E2")]
	[Address(RVA = "0x206355C", Offset = "0x206355C", VA = "0x206355C")]
	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}
}
