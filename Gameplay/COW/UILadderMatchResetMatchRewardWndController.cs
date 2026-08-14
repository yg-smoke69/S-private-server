using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002166")]
public class UILadderMatchResetMatchRewardWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002167")]
	private sealed class _003CShowResetRankReward_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D1CC")]
		[FieldOffset(Offset = "0x8")]
		internal uint seasonResetRank;

		[Token(Token = "0x400D1CD")]
		[FieldOffset(Offset = "0xC")]
		internal uint rankMasterLevel;

		[Token(Token = "0x600B0C7")]
		[Address(RVA = "0x22BF0D4", Offset = "0x22BF0D4", VA = "0x22BF0D4")]
		public _003CShowResetRankReward_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B0C8")]
		[Address(RVA = "0x22BF258", Offset = "0x22BF258", VA = "0x22BF258")]
		internal bool _003C_003Em__0(LadderLevelData data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D1C8")]
	[FieldOffset(Offset = "0x48")]
	private UILadderMatchResetMatchRewardWndView m_View;

	[Token(Token = "0x400D1C9")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLadderMatch m_ModelLadderBR;

	[Token(Token = "0x400D1CA")]
	[FieldOffset(Offset = "0x50")]
	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	[Token(Token = "0x400D1CB")]
	[FieldOffset(Offset = "0x54")]
	private UIModelCSLadderMatch m_ModelLadderCS;

	[Token(Token = "0x600B0C0")]
	[Address(RVA = "0x22BE91C", Offset = "0x22BE91C", VA = "0x22BE91C")]
	public UILadderMatchResetMatchRewardWndController()
	{
	}

	[Token(Token = "0x600B0C1")]
	[Address(RVA = "0x22BE924", Offset = "0x22BE924", VA = "0x22BE924")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B0C2")]
	[Address(RVA = "0x22BE9C8", Offset = "0x22BE9C8", VA = "0x22BE9C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B0C3")]
	[Address(RVA = "0x22BEBB8", Offset = "0x22BEBB8", VA = "0x22BEBB8")]
	public void ShowResetRankReward(DGNDKMLMLPM matchMode, uint seasonResetRank, uint remainUnlockTimes = 1u, uint rankMasterLevel = 20u)
	{
	}

	[Token(Token = "0x600B0C4")]
	[Address(RVA = "0x22BF0DC", Offset = "0x22BF0DC", VA = "0x22BF0DC", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B0C5")]
	[Address(RVA = "0x22BF1D4", Offset = "0x22BF1D4", VA = "0x22BF1D4", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B0C6")]
	[Address(RVA = "0x22BF250", Offset = "0x22BF250", VA = "0x22BF250")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
