using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200299D")]
public class UIMapOpenCountDownController : UIBaseController
{
	[Token(Token = "0x4010015")]
	[FieldOffset(Offset = "0x28")]
	private UIMapOpenCountDownView m_View;

	[Token(Token = "0x4010016")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	[Token(Token = "0x4010017")]
	[FieldOffset(Offset = "0x30")]
	private uint m_CountDown;

	[Token(Token = "0x4010018")]
	[FieldOffset(Offset = "0x38")]
	private DateTime m_EndDate;

	[Token(Token = "0x6010B7A")]
	[Address(RVA = "0x2806DD0", Offset = "0x2806DD0", VA = "0x2806DD0")]
	public UIMapOpenCountDownController()
	{
	}

	[Token(Token = "0x6010B7B")]
	[Address(RVA = "0x2806E54", Offset = "0x2806E54", VA = "0x2806E54")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B7C")]
	[Address(RVA = "0x2806EFC", Offset = "0x2806EFC", VA = "0x2806EFC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B7D")]
	[Address(RVA = "0x28073E0", Offset = "0x28073E0", VA = "0x28073E0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010B7E")]
	[Address(RVA = "0x2807054", Offset = "0x2807054", VA = "0x2807054")]
	public void SetData(MapOpeningInfo mapInfo)
	{
	}

	[Token(Token = "0x6010B7F")]
	[Address(RVA = "0x2807720", Offset = "0x2807720", VA = "0x2807720")]
	private void UpdateTime()
	{
	}

	[Token(Token = "0x6010B80")]
	[Address(RVA = "0x28074FC", Offset = "0x28074FC", VA = "0x28074FC")]
	private void ShowTime(int days, int hours, int minutes, int seconds)
	{
	}

	[Token(Token = "0x6010B81")]
	[Address(RVA = "0x2807970", Offset = "0x2807970", VA = "0x2807970")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010B82")]
	[Address(RVA = "0x2807978", Offset = "0x2807978", VA = "0x2807978")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
