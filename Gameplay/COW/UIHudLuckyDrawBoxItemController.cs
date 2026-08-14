using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027A9")]
public class UIHudLuckyDrawBoxItemController : UIBaseController
{
	[Token(Token = "0x400F4DD")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLuckyDrawBoxItemView m_View;

	[Token(Token = "0x400F4DE")]
	[FieldOffset(Offset = "0x2C")]
	private FBKJDCGPPIO m_Item;

	[Token(Token = "0x600F4B3")]
	[Address(RVA = "0xFF2F74", Offset = "0xFF2F74", VA = "0xFF2F74")]
	public UIHudLuckyDrawBoxItemController()
	{
	}

	[Token(Token = "0x600F4B4")]
	[Address(RVA = "0xFF2FF8", Offset = "0xFF2FF8", VA = "0xFF2FF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F4B5")]
	[Address(RVA = "0xFF30A0", Offset = "0xFF30A0", VA = "0xFF30A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F4B6")]
	[Address(RVA = "0xFF1B24", Offset = "0xFF1B24", VA = "0xFF1B24")]
	public void SetViewData(FBKJDCGPPIO levelLuckyDrawGridItem)
	{
	}

	[Token(Token = "0x600F4B7")]
	[Address(RVA = "0xFF315C", Offset = "0xFF315C", VA = "0xFF315C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
