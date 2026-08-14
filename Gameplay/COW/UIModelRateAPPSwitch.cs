using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20031F4")]
public class UIModelRateAPPSwitch : UIBaseModel
{
	[Token(Token = "0x20031F5")]
	private class ModeRankRequirement
	{
		[Token(Token = "0x4013035")]
		[FieldOffset(Offset = "0x8")]
		private uint m_Mode;

		[Token(Token = "0x4013036")]
		[FieldOffset(Offset = "0xC")]
		private uint m_Rank;

		[Token(Token = "0x6015136")]
		[Address(RVA = "0x313E700", Offset = "0x313E700", VA = "0x313E700")]
		public ModeRankRequirement(uint mode, uint rank)
		{
		}

		[Token(Token = "0x6015137")]
		[Address(RVA = "0x313F0FC", Offset = "0x313F0FC", VA = "0x313F0FC")]
		public bool IsRequirementMeet(uint mode, uint rank)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401302D")]
	private const string SHOW_RATEAPP_POPUP_DAYOFYEAR_KEY = "SHOW_RATEAPP_POPUP_DAYOFYEAR";

	[Token(Token = "0x401302E")]
	[FieldOffset(Offset = "0xC")]
	private bool m_Ready;

	[Token(Token = "0x401302F")]
	[FieldOffset(Offset = "0x10")]
	private uint m_Cooldown;

	[Token(Token = "0x4013030")]
	[FieldOffset(Offset = "0x14")]
	private List<ModeRankRequirement> m_Requirements;

	[Token(Token = "0x4013031")]
	[FieldOffset(Offset = "0x18")]
	public bool IOSOpen;

	[Token(Token = "0x4013032")]
	[FieldOffset(Offset = "0x19")]
	public bool GPOpen;

	[Token(Token = "0x4013033")]
	[FieldOffset(Offset = "0x1A")]
	public bool HuaweiOpen;

	[Token(Token = "0x4013034")]
	[FieldOffset(Offset = "0x1B")]
	public bool ThirdPartyOpen;

	[Token(Token = "0x601512C")]
	[Address(RVA = "0x313E490", Offset = "0x313E490", VA = "0x313E490")]
	public UIModelRateAPPSwitch()
	{
	}

	[Token(Token = "0x601512D")]
	[Address(RVA = "0x313E514", Offset = "0x313E514", VA = "0x313E514")]
	public void ProcessRateAppSwitch(CSGetRateAppSwitchRes data)
	{
	}

	[Token(Token = "0x601512E")]
	[Address(RVA = "0x313E82C", Offset = "0x313E82C", VA = "0x313E82C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601512F")]
	[Address(RVA = "0x313E8FC", Offset = "0x313E8FC", VA = "0x313E8FC", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015130")]
	[Address(RVA = "0x313E954", Offset = "0x313E954", VA = "0x313E954")]
	private bool CanRateApp()
	{
		return default(bool);
	}

	[Token(Token = "0x6015131")]
	[Address(RVA = "0x313E9AC", Offset = "0x313E9AC", VA = "0x313E9AC")]
	private int GetPopupDayOfYear()
	{
		return default(int);
	}

	[Token(Token = "0x6015132")]
	[Address(RVA = "0x313EA8C", Offset = "0x313EA8C", VA = "0x313EA8C")]
	private bool IsPopupCooldownFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x6015133")]
	[Address(RVA = "0x313EC8C", Offset = "0x313EC8C", VA = "0x313EC8C")]
	public void SetPopupDayOfYear()
	{
	}

	[Token(Token = "0x6015134")]
	[Address(RVA = "0x313EDD4", Offset = "0x313EDD4", VA = "0x313EDD4")]
	public bool IsRateAppAvailable(uint curMode, uint curRank)
	{
		return default(bool);
	}

	[Token(Token = "0x6015135")]
	[Address(RVA = "0x313F1AC", Offset = "0x313F1AC", VA = "0x313F1AC")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
