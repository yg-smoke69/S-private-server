using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20025E7")]
internal class UIElitePassChallengeItemController : UIEasyListItemController
{
	[Token(Token = "0x20025E8")]
	private enum EPBtnState
	{
		[Token(Token = "0x400EA58")]
		OnGoing,
		[Token(Token = "0x400EA59")]
		Lock,
		[Token(Token = "0x400EA5A")]
		Claimed,
		[Token(Token = "0x400EA5B")]
		Reached,
		[Token(Token = "0x400EA5C")]
		ReachedButIsNotEP
	}

	[Token(Token = "0x20025E9")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EA5D")]
		[FieldOffset(Offset = "0x8")]
		internal object data;

		[Token(Token = "0x400EA5E")]
		[FieldOffset(Offset = "0xC")]
		internal int data_index;

		[Token(Token = "0x400EA5F")]
		[FieldOffset(Offset = "0x10")]
		internal UIElitePassChallengeItemController _0024this;

		[Token(Token = "0x600DF79")]
		[Address(RVA = "0x2A4EEE8", Offset = "0x2A4EEE8", VA = "0x2A4EEE8")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DF7A")]
		[Address(RVA = "0x2A514BC", Offset = "0x2A514BC", VA = "0x2A514BC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400EA4E")]
	[FieldOffset(Offset = "0x38")]
	private UIElitePassChallengeItemView m_View;

	[Token(Token = "0x400EA4F")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelElitePass m_EPModel;

	[Token(Token = "0x400EA50")]
	[FieldOffset(Offset = "0x40")]
	private EPChallengeInfo m_ChallengeInfo;

	[Token(Token = "0x400EA51")]
	[FieldOffset(Offset = "0x44")]
	private EPBtnState m_BtnState;

	[Token(Token = "0x400EA52")]
	[FieldOffset(Offset = "0x48")]
	private List<UIStandardItemMiniController> m_Rewards;

	[Token(Token = "0x400EA53")]
	[FieldOffset(Offset = "0x4C")]
	private string PREFIX_TEAM_WORK;

	[Token(Token = "0x400EA54")]
	[FieldOffset(Offset = "0x50")]
	private uint DelayCallID;

	[Token(Token = "0x400EA55")]
	[FieldOffset(Offset = "0x54")]
	private string GoPosString;

	[Token(Token = "0x400EA56")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600DF68")]
	[Address(RVA = "0x2A4E300", Offset = "0x2A4E300", VA = "0x2A4E300")]
	public UIElitePassChallengeItemController()
	{
	}

	[Token(Token = "0x600DF69")]
	[Address(RVA = "0x2A4E3A0", Offset = "0x2A4E3A0", VA = "0x2A4E3A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DF6A")]
	[Address(RVA = "0x2A4EA3C", Offset = "0x2A4EA3C", VA = "0x2A4EA3C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DF6B")]
	[Address(RVA = "0x2A4EB58", Offset = "0x2A4EB58", VA = "0x2A4EB58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DF6C")]
	[Address(RVA = "0x2A4E65C", Offset = "0x2A4E65C", VA = "0x2A4E65C")]
	private void InitLabel()
	{
	}

	[Token(Token = "0x600DF6D")]
	[Address(RVA = "0x2A4EC00", Offset = "0x2A4EC00", VA = "0x2A4EC00", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600DF6E")]
	[Address(RVA = "0x2A4EEF0", Offset = "0x2A4EEF0", VA = "0x2A4EEF0")]
	private void InitView(object data, int data_index)
	{
	}

	[Token(Token = "0x600DF6F")]
	[Address(RVA = "0x2A50890", Offset = "0x2A50890", VA = "0x2A50890")]
	private void OnClaimBtnClick()
	{
	}

	[Token(Token = "0x600DF70")]
	[Address(RVA = "0x2A50D34", Offset = "0x2A50D34", VA = "0x2A50D34")]
	private void OnGoToEPBtnClick()
	{
	}

	[Token(Token = "0x600DF71")]
	[Address(RVA = "0x2A50EC8", Offset = "0x2A50EC8", VA = "0x2A50EC8")]
	private void OnGoTaskBtnClick()
	{
	}

	[Token(Token = "0x600DF72")]
	[Address(RVA = "0x2A4FE74", Offset = "0x2A4FE74", VA = "0x2A4FE74")]
	private void SetButtonState(EPTarget_Status taskState, bool isEPPlayer, bool isLock, bool isEPOnlyTask)
	{
	}

	[Token(Token = "0x600DF73")]
	[Address(RVA = "0x2A50344", Offset = "0x2A50344", VA = "0x2A50344")]
	private void SetReward(BaseItemInfo[] lst)
	{
	}

	[Token(Token = "0x600DF74")]
	[Address(RVA = "0x2A50DA0", Offset = "0x2A50DA0", VA = "0x2A50DA0")]
	private void GotoEPUpgrade()
	{
	}

	[Token(Token = "0x600DF75")]
	[Address(RVA = "0x2A51268", Offset = "0x2A51268", VA = "0x2A51268")]
	private void _003COnClaimBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x600DF76")]
	[Address(RVA = "0x2A51390", Offset = "0x2A51390", VA = "0x2A51390")]
	private static void _003COnClaimBtnClick_003Em__1()
	{
	}

	[Token(Token = "0x600DF77")]
	[Address(RVA = "0x2A514AC", Offset = "0x2A514AC", VA = "0x2A514AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DF78")]
	[Address(RVA = "0x2A514B4", Offset = "0x2A514B4", VA = "0x2A514B4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
