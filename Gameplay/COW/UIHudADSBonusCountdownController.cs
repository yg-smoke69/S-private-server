using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F97")]
internal class UIHudADSBonusCountdownController : UIBaseController
{
	[Token(Token = "0x400C642")]
	[FieldOffset(Offset = "0x28")]
	private UIHudADSBonusCountdownView m_View;

	[Token(Token = "0x400C643")]
	[FieldOffset(Offset = "0x2C")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400C644")]
	[FieldOffset(Offset = "0x30")]
	private float m_EndTime;

	[Token(Token = "0x400C645")]
	[FieldOffset(Offset = "0x34")]
	private Color winStyleColorBg;

	[Token(Token = "0x400C646")]
	[FieldOffset(Offset = "0x44")]
	private Color winStyleColorFor;

	[Token(Token = "0x400C647")]
	[FieldOffset(Offset = "0x54")]
	private Color loseStyleColorBg;

	[Token(Token = "0x400C648")]
	[FieldOffset(Offset = "0x64")]
	private Color loseStyleColorFor;

	[Token(Token = "0x6009D40")]
	[Address(RVA = "0x1636B8C", Offset = "0x1636B8C", VA = "0x1636B8C")]
	public UIHudADSBonusCountdownController()
	{
	}

	[Token(Token = "0x6009D41")]
	[Address(RVA = "0x1636CFC", Offset = "0x1636CFC", VA = "0x1636CFC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009D42")]
	[Address(RVA = "0x1636DA4", Offset = "0x1636DA4", VA = "0x1636DA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D43")]
	[Address(RVA = "0x1636E60", Offset = "0x1636E60", VA = "0x1636E60")]
	public void ShowBonusCountdown(float bonusEndTime)
	{
	}

	[Token(Token = "0x6009D44")]
	[Address(RVA = "0x16370F8", Offset = "0x16370F8", VA = "0x16370F8")]
	public void SetUIStyle(bool isWinStyle)
	{
	}

	[Token(Token = "0x6009D45")]
	[Address(RVA = "0x1637284", Offset = "0x1637284", VA = "0x1637284")]
	private void Update()
	{
	}

	[Token(Token = "0x6009D46")]
	[Address(RVA = "0x1637460", Offset = "0x1637460", VA = "0x1637460")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
