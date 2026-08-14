using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022DC")]
public class CommonRewardWndManager : SingletonModule<CommonRewardWndManager>
{
	[Token(Token = "0x20022DD")]
	private sealed class _003CShowOptionalBundleView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D9C0")]
		[FieldOffset(Offset = "0x8")]
		internal OptionalRewardWndCfg cfg;

		[Token(Token = "0x600C010")]
		[Address(RVA = "0x173AD28", Offset = "0x173AD28", VA = "0x173AD28")]
		public _003CShowOptionalBundleView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C011")]
		[Address(RVA = "0x173D15C", Offset = "0x173D15C", VA = "0x173D15C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20022DE")]
	private sealed class _003CShowLegendRerandomView_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D9C1")]
		[FieldOffset(Offset = "0x8")]
		internal RewardWndCfg cfg;

		[Token(Token = "0x400D9C2")]
		[FieldOffset(Offset = "0xC")]
		internal uint gachaID;

		[Token(Token = "0x400D9C3")]
		[FieldOffset(Offset = "0x10")]
		internal CommonRewardWndManager _0024this;

		[Token(Token = "0x600C012")]
		[Address(RVA = "0x173BCE4", Offset = "0x173BCE4", VA = "0x173BCE4")]
		public _003CShowLegendRerandomView_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600C013")]
		[Address(RVA = "0x173D098", Offset = "0x173D098", VA = "0x173D098")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600C014")]
		[Address(RVA = "0x173D128", Offset = "0x173D128", VA = "0x173D128")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x20022DF")]
	private sealed class _003CShowLadderRankUpView_003Ec__AnonStorey2
	{
		[Token(Token = "0x400D9C4")]
		[FieldOffset(Offset = "0x8")]
		internal OptionalRewardRankInfoWndCfg cfg;

		[Token(Token = "0x600C015")]
		[Address(RVA = "0x173C47C", Offset = "0x173C47C", VA = "0x173C47C")]
		public _003CShowLadderRankUpView_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600C016")]
		[Address(RVA = "0x173D034", Offset = "0x173D034", VA = "0x173D034")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20022E0")]
	private sealed class _003CShowRewardsView_003Ec__AnonStorey3
	{
		[Token(Token = "0x400D9C5")]
		[FieldOffset(Offset = "0x8")]
		internal RewardWndCfg cfg;

		[Token(Token = "0x400D9C6")]
		[FieldOffset(Offset = "0xC")]
		internal CommonRewardWndManager _0024this;

		[Token(Token = "0x600C017")]
		[Address(RVA = "0x173D02C", Offset = "0x173D02C", VA = "0x173D02C")]
		public _003CShowRewardsView_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600C018")]
		[Address(RVA = "0x173D1C0", Offset = "0x173D1C0", VA = "0x173D1C0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400D9BE")]
	public const int MAX_ITEM_SHOWED_PER_POPUP = 5;

	[Token(Token = "0x400D9BF")]
	public const int MAX_ITEM_SHOWED_PER_POPUP_DOUBLE_ROW = 10;

	[Token(Token = "0x600C009")]
	[Address(RVA = "0x173A638", Offset = "0x173A638", VA = "0x173A638")]
	public CommonRewardWndManager()
	{
	}

	[Token(Token = "0x600C00A")]
	[Address(RVA = "0x173A6C8", Offset = "0x173A6C8", VA = "0x173A6C8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600C00B")]
	[Address(RVA = "0x173A71C", Offset = "0x173A71C", VA = "0x173A71C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600C00C")]
	[Address(RVA = "0x173A770", Offset = "0x173A770", VA = "0x173A770")]
	public void ShowOptionalBundleView(OptionalRewardWndCfg cfg)
	{
	}

	[Token(Token = "0x600C00D")]
	[Address(RVA = "0x173AD30", Offset = "0x173AD30", VA = "0x173AD30")]
	public void ShowLegendRerandomView(RewardWndCfg cfg, uint gachaID)
	{
	}

	[Token(Token = "0x600C00E")]
	[Address(RVA = "0x173BCEC", Offset = "0x173BCEC", VA = "0x173BCEC")]
	public void ShowLadderRankUpView(OptionalRewardRankInfoWndCfg cfg)
	{
	}

	[Token(Token = "0x600C00F")]
	[Address(RVA = "0x173C484", Offset = "0x173C484", VA = "0x173C484")]
	public void ShowRewardsView(RewardWndCfg cfg)
	{
	}
}
