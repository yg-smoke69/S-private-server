using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E90")]
public class UIBigEvent_GlobalProgress_BtnItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400C02B")]
	[FieldOffset(Offset = "0x28")]
	private UIBigEvent_GlobalProgress_BtnItemView m_View;

	[Token(Token = "0x400C02C")]
	[FieldOffset(Offset = "0x2C")]
	public CustomEventEntranceDesc Data;

	[Token(Token = "0x400C02D")]
	[FieldOffset(Offset = "0x30")]
	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	[Token(Token = "0x6009338")]
	[Address(RVA = "0x301F234", Offset = "0x301F234", VA = "0x301F234")]
	public UIBigEvent_GlobalProgress_BtnItemController()
	{
	}

	[Token(Token = "0x6009339")]
	[Address(RVA = "0x301F2B8", Offset = "0x301F2B8", VA = "0x301F2B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600933A")]
	[Address(RVA = "0x301F360", Offset = "0x301F360", VA = "0x301F360", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600933B")]
	[Address(RVA = "0x301F628", Offset = "0x301F628", VA = "0x301F628", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600933C")]
	[Address(RVA = "0x301F758", Offset = "0x301F758", VA = "0x301F758", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600933D")]
	[Address(RVA = "0x301FB58", Offset = "0x301FB58", VA = "0x301FB58", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600933E")]
	[Address(RVA = "0x301FBEC", Offset = "0x301FBEC", VA = "0x301FBEC")]
	private void OnClickBtn()
	{
	}

	[Token(Token = "0x600933F")]
	[Address(RVA = "0x301CA38", Offset = "0x301CA38", VA = "0x301CA38")]
	public void SetData(CustomEventEntranceDesc data)
	{
	}

	[Token(Token = "0x6009340")]
	[Address(RVA = "0x301F824", Offset = "0x301F824", VA = "0x301F824")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6009341")]
	[Address(RVA = "0x30203A0", Offset = "0x30203A0", VA = "0x30203A0")]
	private void RefreshPeakDayBubble()
	{
	}

	[Token(Token = "0x6009342")]
	[Address(RVA = "0x302059C", Offset = "0x302059C", VA = "0x302059C")]
	private void RefreshMissionRedPoint()
	{
	}

	[Token(Token = "0x6009343")]
	[Address(RVA = "0x30206D0", Offset = "0x30206D0", VA = "0x30206D0")]
	private void RefreshExchangeStoreRedPoint()
	{
	}

	[Token(Token = "0x6009344")]
	[Address(RVA = "0x30207FC", Offset = "0x30207FC", VA = "0x30207FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009345")]
	[Address(RVA = "0x3020804", Offset = "0x3020804", VA = "0x3020804")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
