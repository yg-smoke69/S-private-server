using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002165")]
public class UILadderMatchResetMatchRewardItemController : UIEasyListItemController
{
	[Token(Token = "0x400D1C6")]
	[FieldOffset(Offset = "0x38")]
	private UILadderMatchResetMatchRewardItemView m_View;

	[Token(Token = "0x400D1C7")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIStandardItemMiniController> m_MiniItemCtrlList;

	[Token(Token = "0x600B0BA")]
	[Address(RVA = "0x22BDCC4", Offset = "0x22BDCC4", VA = "0x22BDCC4")]
	public UILadderMatchResetMatchRewardItemController()
	{
	}

	[Token(Token = "0x600B0BB")]
	[Address(RVA = "0x22BDD50", Offset = "0x22BDD50", VA = "0x22BDD50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B0BC")]
	[Address(RVA = "0x22BDDF4", Offset = "0x22BDDF4", VA = "0x22BDDF4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B0BD")]
	[Address(RVA = "0x22BDEB0", Offset = "0x22BDEB0", VA = "0x22BDEB0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B0BE")]
	[Address(RVA = "0x22BE4B4", Offset = "0x22BE4B4", VA = "0x22BE4B4")]
	private void InitView()
	{
	}

	[Token(Token = "0x600B0BF")]
	[Address(RVA = "0x22BE6FC", Offset = "0x22BE6FC", VA = "0x22BE6FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
