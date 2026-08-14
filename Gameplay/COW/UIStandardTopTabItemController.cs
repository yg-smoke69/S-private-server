using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023CB")]
public class UIStandardTopTabItemController : UIEasyListItemController
{
	[Token(Token = "0x400DEA1")]
	[FieldOffset(Offset = "0x38")]
	private UIStandardTopTabItemView m_View;

	[Token(Token = "0x400DEA2")]
	[FieldOffset(Offset = "0x3C")]
	private StandardTopTabItemViewData m_Data;

	[Token(Token = "0x400DEA3")]
	[FieldOffset(Offset = "0x40")]
	public float selectBgWidth;

	[Token(Token = "0x600C9D8")]
	[Address(RVA = "0x2005B28", Offset = "0x2005B28", VA = "0x2005B28")]
	public UIStandardTopTabItemController()
	{
	}

	[Token(Token = "0x600C9D9")]
	[Address(RVA = "0x2005B30", Offset = "0x2005B30", VA = "0x2005B30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C9DA")]
	[Address(RVA = "0x2005BD8", Offset = "0x2005BD8", VA = "0x2005BD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C9DB")]
	[Address(RVA = "0x2005D34", Offset = "0x2005D34", VA = "0x2005D34", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C9DC")]
	[Address(RVA = "0x2006BDC", Offset = "0x2006BDC", VA = "0x2006BDC")]
	public void SetRedPointState(bool value)
	{
	}

	[Token(Token = "0x600C9DD")]
	[Address(RVA = "0x2006C94", Offset = "0x2006C94", VA = "0x2006C94")]
	public bool GetRedPointState()
	{
		return default(bool);
	}

	[Token(Token = "0x600C9DE")]
	[Address(RVA = "0x2006D40", Offset = "0x2006D40", VA = "0x2006D40", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C9DF")]
	[Address(RVA = "0x2006F5C", Offset = "0x2006F5C", VA = "0x2006F5C", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600C9E0")]
	[Address(RVA = "0x2007024", Offset = "0x2007024", VA = "0x2007024")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C9E1")]
	[Address(RVA = "0x200702C", Offset = "0x200702C", VA = "0x200702C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C9E2")]
	[Address(RVA = "0x2007034", Offset = "0x2007034", VA = "0x2007034")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
