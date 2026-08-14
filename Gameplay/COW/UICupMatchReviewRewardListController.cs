using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002079")]
internal class UICupMatchReviewRewardListController : UIBaseController
{
	[Token(Token = "0x400CB95")]
	[FieldOffset(Offset = "0x28")]
	private UICupMatchReviewRewardListView m_View;

	[Token(Token = "0x400CB96")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CB97")]
	[FieldOffset(Offset = "0x30")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CB98")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsTicket;

	[Token(Token = "0x400CB99")]
	[FieldOffset(Offset = "0x35")]
	private bool m_IsLeft;

	[Token(Token = "0x400CB9A")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<CupChestDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600A6A2")]
	[Address(RVA = "0x2AAC1B4", Offset = "0x2AAC1B4", VA = "0x2AAC1B4")]
	public UICupMatchReviewRewardListController()
	{
	}

	[Token(Token = "0x600A6A3")]
	[Address(RVA = "0x2AAC238", Offset = "0x2AAC238", VA = "0x2AAC238")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A6A4")]
	[Address(RVA = "0x2AAC2E0", Offset = "0x2AAC2E0", VA = "0x2AAC2E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A6A5")]
	[Address(RVA = "0x2AAC4A0", Offset = "0x2AAC4A0", VA = "0x2AAC4A0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A6A6")]
	[Address(RVA = "0x2AAC5D4", Offset = "0x2AAC5D4", VA = "0x2AAC5D4")]
	public void SetData(int cupMatchKey, bool isLeft, bool isTicket)
	{
	}

	[Token(Token = "0x600A6A7")]
	[Address(RVA = "0x2AAC664", Offset = "0x2AAC664", VA = "0x2AAC664")]
	private void RefreshReward()
	{
	}

	[Token(Token = "0x600A6A8")]
	[Address(RVA = "0x2AACD74", Offset = "0x2AACD74", VA = "0x2AACD74")]
	private void RefreshCupMatchReward()
	{
	}

	[Token(Token = "0x600A6A9")]
	[Address(RVA = "0x2AAD0C0", Offset = "0x2AAD0C0", VA = "0x2AAD0C0")]
	private void OnTicketStateChange(object[] param)
	{
	}

	[Token(Token = "0x600A6AA")]
	[Address(RVA = "0x2AAD394", Offset = "0x2AAD394", VA = "0x2AAD394")]
	private static int _003CRefreshReward_003Em__0(CupChestDesc a, CupChestDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x600A6AB")]
	[Address(RVA = "0x2AAD3DC", Offset = "0x2AAD3DC", VA = "0x2AAD3DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A6AC")]
	[Address(RVA = "0x2AAD3E4", Offset = "0x2AAD3E4", VA = "0x2AAD3E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
