using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AE1")]
public class UIRoomCheckSliderTemplateController : UIBaseController
{
	[Token(Token = "0x4010756")]
	[FieldOffset(Offset = "0x28")]
	private UIRoomCheckSliderTemplateView m_View;

	[Token(Token = "0x4010757")]
	[FieldOffset(Offset = "0x2C")]
	private int m_MinValue;

	[Token(Token = "0x4010758")]
	[FieldOffset(Offset = "0x30")]
	private int m_MaxValue;

	[Token(Token = "0x4010759")]
	[FieldOffset(Offset = "0x34")]
	private int m_Interval;

	[Token(Token = "0x401075A")]
	[FieldOffset(Offset = "0x38")]
	private int m_CurValue;

	[Token(Token = "0x401075B")]
	[FieldOffset(Offset = "0x3C")]
	private Action<int> m_SliderCB;

	[Token(Token = "0x401075C")]
	[FieldOffset(Offset = "0x40")]
	private Action<bool> m_ToggeleCB;

	[Token(Token = "0x6011955")]
	[Address(RVA = "0x23BB020", Offset = "0x23BB020", VA = "0x23BB020")]
	public UIRoomCheckSliderTemplateController()
	{
	}

	[Token(Token = "0x6011956")]
	[Address(RVA = "0x23BB0BC", Offset = "0x23BB0BC", VA = "0x23BB0BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011957")]
	[Address(RVA = "0x23BB160", Offset = "0x23BB160", VA = "0x23BB160", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011958")]
	[Address(RVA = "0x23BB418", Offset = "0x23BB418", VA = "0x23BB418", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011959")]
	[Address(RVA = "0x23BB488", Offset = "0x23BB488", VA = "0x23BB488")]
	public void SetSlider(string key, int max, int min, int interval, int def, bool toggleVal, bool showToggle = true)
	{
	}

	[Token(Token = "0x601195A")]
	[Address(RVA = "0x23BB7BC", Offset = "0x23BB7BC", VA = "0x23BB7BC")]
	public void SetCallBack(Action<int> sliderCB, Action<bool> toggleCB)
	{
	}

	[Token(Token = "0x601195B")]
	[Address(RVA = "0x23BB83C", Offset = "0x23BB83C", VA = "0x23BB83C")]
	public void ResetCallBack()
	{
	}

	[Token(Token = "0x601195C")]
	[Address(RVA = "0x23BB89C", Offset = "0x23BB89C", VA = "0x23BB89C")]
	private void OnToggleChanged()
	{
	}

	[Token(Token = "0x601195D")]
	[Address(RVA = "0x23BB98C", Offset = "0x23BB98C", VA = "0x23BB98C")]
	private void OnSliderChanged()
	{
	}

	[Token(Token = "0x601195E")]
	[Address(RVA = "0x23BBB58", Offset = "0x23BBB58", VA = "0x23BBB58")]
	private void OnPlusClick()
	{
	}

	[Token(Token = "0x601195F")]
	[Address(RVA = "0x23BBCEC", Offset = "0x23BBCEC", VA = "0x23BBCEC")]
	private void OnMinusClick()
	{
	}

	[Token(Token = "0x6011960")]
	[Address(RVA = "0x23BBE84", Offset = "0x23BBE84", VA = "0x23BBE84")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011961")]
	[Address(RVA = "0x23BBE8C", Offset = "0x23BBE8C", VA = "0x23BBE8C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
