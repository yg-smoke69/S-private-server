using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002970")]
public class UIMailRewardItemController : UIBaseController
{
	[Token(Token = "0x400FF5E")]
	[FieldOffset(Offset = "0x28")]
	private UIMailRewardItemView m_View;

	[Token(Token = "0x400FF5F")]
	[FieldOffset(Offset = "0x2C")]
	private UIStandardItemMiniController m_UIStandardItemMiniController;

	[Token(Token = "0x400FF60")]
	[FieldOffset(Offset = "0x30")]
	private BaseItemInfo m_Item;

	[Token(Token = "0x60109DF")]
	[Address(RVA = "0x18E4654", Offset = "0x18E4654", VA = "0x18E4654")]
	public UIMailRewardItemController()
	{
	}

	[Token(Token = "0x60109E0")]
	[Address(RVA = "0x18E46D8", Offset = "0x18E46D8", VA = "0x18E46D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60109E1")]
	[Address(RVA = "0x18E477C", Offset = "0x18E477C", VA = "0x18E477C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60109E2")]
	[Address(RVA = "0x18DE4A8", Offset = "0x18DE4A8", VA = "0x18DE4A8")]
	public void SetData(BaseItemInfo item, bool claimed)
	{
	}

	[Token(Token = "0x60109E3")]
	[Address(RVA = "0x18E48CC", Offset = "0x18E48CC", VA = "0x18E48CC")]
	private void ShowItemTip()
	{
	}

	[Token(Token = "0x60109E4")]
	[Address(RVA = "0x18E4A14", Offset = "0x18E4A14", VA = "0x18E4A14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
