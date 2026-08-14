using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022E2")]
public class GiftRewardPopupManager : SingletonModule<GiftRewardPopupManager>
{
	[Token(Token = "0x400D9CB")]
	[FieldOffset(Offset = "0xC")]
	private List<GiftRewardPopupData> m_GiftMailList;

	[Token(Token = "0x400D9CC")]
	[FieldOffset(Offset = "0x10")]
	private int m_CurrentPopupIndex;

	[Token(Token = "0x400D9CD")]
	[FieldOffset(Offset = "0x14")]
	private int m_GiftMailCount;

	[Token(Token = "0x400D9CE")]
	[FieldOffset(Offset = "0x18")]
	public bool m_Finished;

	[Token(Token = "0x600C01B")]
	[Address(RVA = "0x25912B8", Offset = "0x25912B8", VA = "0x25912B8")]
	public GiftRewardPopupManager()
	{
	}

	[Token(Token = "0x600C01C")]
	[Address(RVA = "0x2591384", Offset = "0x2591384", VA = "0x2591384", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600C01D")]
	[Address(RVA = "0x25913D8", Offset = "0x25913D8", VA = "0x25913D8", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600C01E")]
	[Address(RVA = "0x2591498", Offset = "0x2591498", VA = "0x2591498")]
	public void ShowAwardList(List<GiftRewardPopupData> data)
	{
	}

	[Token(Token = "0x600C01F")]
	[Address(RVA = "0x25915A8", Offset = "0x25915A8", VA = "0x25915A8")]
	public void PopupNextRewards(object[] data)
	{
	}
}
