using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023BC")]
public class UIStandardItemMini2Controller : UIBaseController
{
	[Token(Token = "0x400DE64")]
	[FieldOffset(Offset = "0x28")]
	private UIStandardItemMini2View m_View;

	[Token(Token = "0x400DE65")]
	[FieldOffset(Offset = "0x2C")]
	public StatndardItemMiniData m_Data;

	[Token(Token = "0x600C936")]
	[Address(RVA = "0x206B408", Offset = "0x206B408", VA = "0x206B408")]
	public UIStandardItemMini2Controller()
	{
	}

	[Token(Token = "0x600C937")]
	[Address(RVA = "0x206B48C", Offset = "0x206B48C", VA = "0x206B48C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C938")]
	[Address(RVA = "0x206B534", Offset = "0x206B534", VA = "0x206B534", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C939")]
	[Address(RVA = "0x206B6C8", Offset = "0x206B6C8", VA = "0x206B6C8")]
	public void SetStandItemMiniData(StatndardItemMiniData data)
	{
	}

	[Token(Token = "0x600C93A")]
	[Address(RVA = "0x206B734", Offset = "0x206B734", VA = "0x206B734")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x600C93B")]
	[Address(RVA = "0x206BD4C", Offset = "0x206BD4C", VA = "0x206BD4C")]
	public void SetBtnClickEvent(Callback callback)
	{
	}

	[Token(Token = "0x600C93C")]
	[Address(RVA = "0x206BBA0", Offset = "0x206BBA0", VA = "0x206BBA0")]
	public void SetQualityBG()
	{
	}

	[Token(Token = "0x600C93D")]
	[Address(RVA = "0x206B9E8", Offset = "0x206B9E8", VA = "0x206B9E8")]
	public void RefreshBaseItemView(BaseItemInfo info)
	{
	}

	[Token(Token = "0x600C93E")]
	[Address(RVA = "0x206BAE8", Offset = "0x206BAE8", VA = "0x206BAE8")]
	public void SetClaimedState(bool show)
	{
	}

	[Token(Token = "0x600C93F")]
	[Address(RVA = "0x206BDA8", Offset = "0x206BDA8", VA = "0x206BDA8")]
	public void SetItemPermanentState(bool show)
	{
	}

	[Token(Token = "0x600C940")]
	[Address(RVA = "0x206BE40", Offset = "0x206BE40", VA = "0x206BE40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
