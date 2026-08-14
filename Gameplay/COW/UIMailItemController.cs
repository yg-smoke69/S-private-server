using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200296D")]
public class UIMailItemController : UIEasyListItemController
{
	[Token(Token = "0x200296E")]
	public enum MailType
	{
		[Token(Token = "0x400FF5A")]
		DAILY,
		[Token(Token = "0x400FF5B")]
		REPORT
	}

	[Token(Token = "0x400FF4F")]
	[FieldOffset(Offset = "0x38")]
	private UIMailItemView m_View;

	[Token(Token = "0x400FF50")]
	[FieldOffset(Offset = "0x3C")]
	private MailInfo m_Data;

	[Token(Token = "0x400FF51")]
	[FieldOffset(Offset = "0x40")]
	private ReportMailInfo m_ReportData;

	[Token(Token = "0x400FF52")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x400FF53")]
	[FieldOffset(Offset = "0x48")]
	private MailType m_MailType;

	[Token(Token = "0x400FF54")]
	[FieldOffset(Offset = "0x0")]
	private static Color m_ColorLight;

	[Token(Token = "0x400FF55")]
	[FieldOffset(Offset = "0x10")]
	private static Color m_ColorLightGrey;

	[Token(Token = "0x400FF56")]
	[FieldOffset(Offset = "0x20")]
	private static Color m_ColorDark;

	[Token(Token = "0x400FF57")]
	[FieldOffset(Offset = "0x30")]
	private static Color m_ColorSpriteDark;

	[Token(Token = "0x400FF58")]
	[FieldOffset(Offset = "0x40")]
	private static Color m_ColorSpriteLight;

	[Token(Token = "0x60109C6")]
	[Address(RVA = "0x18E1D1C", Offset = "0x18E1D1C", VA = "0x18E1D1C")]
	public UIMailItemController()
	{
	}

	[Token(Token = "0x60109C7")]
	[Address(RVA = "0x18E1D24", Offset = "0x18E1D24", VA = "0x18E1D24")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60109C8")]
	[Address(RVA = "0x18E1DC8", Offset = "0x18E1DC8", VA = "0x18E1DC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60109C9")]
	[Address(RVA = "0x18E1F24", Offset = "0x18E1F24", VA = "0x18E1F24", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60109CA")]
	[Address(RVA = "0x18E25A8", Offset = "0x18E25A8", VA = "0x18E25A8", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x60109CB")]
	[Address(RVA = "0x18E2884", Offset = "0x18E2884", VA = "0x18E2884", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60109CC")]
	[Address(RVA = "0x18E2380", Offset = "0x18E2380", VA = "0x18E2380")]
	private void RefreshMailReadIcon(bool read)
	{
	}

	[Token(Token = "0x60109CD")]
	[Address(RVA = "0x18E358C", Offset = "0x18E358C", VA = "0x18E358C")]
	private string RemainigTime(uint time)
	{
		return null;
	}

	[Token(Token = "0x60109CF")]
	[Address(RVA = "0x18E3978", Offset = "0x18E3978", VA = "0x18E3978")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60109D0")]
	[Address(RVA = "0x18E3980", Offset = "0x18E3980", VA = "0x18E3980")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60109D1")]
	[Address(RVA = "0x18E3988", Offset = "0x18E3988", VA = "0x18E3988")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
