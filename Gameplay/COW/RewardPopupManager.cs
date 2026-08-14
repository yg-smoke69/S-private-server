using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022E4")]
public class RewardPopupManager : SingletonModule<RewardPopupManager>
{
	[Token(Token = "0x400D9D4")]
	private const int MAX_ITEM_SHOWED_PER_POPUP = 5;

	[Token(Token = "0x400D9D5")]
	[FieldOffset(Offset = "0xC")]
	private List<BaseItemInfo> m_CachedBaseItemInfo;

	[Token(Token = "0x400D9D6")]
	[FieldOffset(Offset = "0x10")]
	private RewardPopupData m_RewardData;

	[Token(Token = "0x400D9D7")]
	[FieldOffset(Offset = "0x14")]
	private int m_CurrentPopupIndex;

	[Token(Token = "0x400D9D8")]
	[FieldOffset(Offset = "0x18")]
	private int m_RewardItemCount;

	[Token(Token = "0x400D9D9")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_Finished;

	[Token(Token = "0x600C026")]
	[Address(RVA = "0x2409CA8", Offset = "0x2409CA8", VA = "0x2409CA8")]
	public RewardPopupManager()
	{
	}

	[Token(Token = "0x600C027")]
	[Address(RVA = "0x2409D6C", Offset = "0x2409D6C", VA = "0x2409D6C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600C028")]
	[Address(RVA = "0x2409EC0", Offset = "0x2409EC0", VA = "0x2409EC0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600C029")]
	[Address(RVA = "0x240A014", Offset = "0x240A014", VA = "0x240A014")]
	private void PopupNextRewards(object[] data)
	{
	}
}
