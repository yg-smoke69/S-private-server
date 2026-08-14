using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E4F")]
internal class AutoTaskClaimMailRewards : AutoPopupTask
{
	[Token(Token = "0x2001E50")]
	private sealed class _003CDo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400BF2C")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelMail modelMail;

		[Token(Token = "0x60091A8")]
		[Address(RVA = "0x10EE9A0", Offset = "0x10EE9A0", VA = "0x10EE9A0")]
		public _003CDo_003Ec__AnonStorey0()
		{
		}
	}

	[Token(Token = "0x2001E51")]
	private sealed class _003CDo_003Ec__AnonStorey1
	{
		[Token(Token = "0x400BF2D")]
		[FieldOffset(Offset = "0x8")]
		internal MailInfo info;

		[Token(Token = "0x400BF2E")]
		[FieldOffset(Offset = "0xC")]
		internal _003CDo_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

		[Token(Token = "0x60091A9")]
		[Address(RVA = "0x10EE9A8", Offset = "0x10EE9A8", VA = "0x10EE9A8")]
		public _003CDo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60091AA")]
		[Address(RVA = "0x10EEA9C", Offset = "0x10EEA9C", VA = "0x10EEA9C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400BF2B")]
	[FieldOffset(Offset = "0x8")]
	private List<GiftRewardPopupData> m_giftRewardPopupData;

	[Token(Token = "0x60091A4")]
	[Address(RVA = "0x10EE2EC", Offset = "0x10EE2EC", VA = "0x10EE2EC")]
	public AutoTaskClaimMailRewards()
	{
	}

	[Token(Token = "0x60091A5")]
	[Address(RVA = "0x10EE2F4", Offset = "0x10EE2F4", VA = "0x10EE2F4", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091A6")]
	[Address(RVA = "0x10EE3DC", Offset = "0x10EE3DC", VA = "0x10EE3DC", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091A7")]
	[Address(RVA = "0x10EE9B0", Offset = "0x10EE9B0", VA = "0x10EE9B0", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
