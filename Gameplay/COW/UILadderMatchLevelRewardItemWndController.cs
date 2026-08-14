using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002160")]
public class UILadderMatchLevelRewardItemWndController : UIEasyListItemController
{
	[Token(Token = "0x400D1A3")]
	[FieldOffset(Offset = "0x38")]
	private UILadderMatchLevelRewardItemView m_View;

	[Token(Token = "0x400D1A4")]
	[FieldOffset(Offset = "0x3C")]
	private UIStandardItemMiniController m_ItemMiniCtrl;

	[Token(Token = "0x600B06B")]
	[Address(RVA = "0x1AF31D8", Offset = "0x1AF31D8", VA = "0x1AF31D8")]
	public UILadderMatchLevelRewardItemWndController()
	{
	}

	[Token(Token = "0x600B06C")]
	[Address(RVA = "0x1AF31E0", Offset = "0x1AF31E0", VA = "0x1AF31E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B06D")]
	[Address(RVA = "0x1AF3284", Offset = "0x1AF3284", VA = "0x1AF3284", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B06E")]
	[Address(RVA = "0x1AF3334", Offset = "0x1AF3334", VA = "0x1AF3334")]
	private void SetArrowDark(bool value)
	{
	}

	[Token(Token = "0x600B06F")]
	[Address(RVA = "0x1AF3450", Offset = "0x1AF3450", VA = "0x1AF3450")]
	public int SortRankDisplayItemBaseOnQuality(BaseItemInfo x, BaseItemInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x600B070")]
	[Address(RVA = "0x1AF3500", Offset = "0x1AF3500", VA = "0x1AF3500", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B071")]
	[Address(RVA = "0x1AF3BCC", Offset = "0x1AF3BCC", VA = "0x1AF3BCC")]
	private void InitItem()
	{
	}

	[Token(Token = "0x600B072")]
	[Address(RVA = "0x1AF3E94", Offset = "0x1AF3E94", VA = "0x1AF3E94")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
