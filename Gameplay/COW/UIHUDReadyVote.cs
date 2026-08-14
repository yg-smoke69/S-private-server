using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C3A")]
public class UIHUDReadyVote : UIBaseController
{
	[Token(Token = "0x4010DE4")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDReadyVoteView m_View;

	[Token(Token = "0x4010DE5")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsCurValid;

	[Token(Token = "0x4010DE6")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_IsBodyVote;

	[Token(Token = "0x4010DE7")]
	[FieldOffset(Offset = "0x30")]
	private int m_VoteBodyID;

	[Token(Token = "0x17001327")]
	public int VoteBodyID
	{
		[Token(Token = "0x60126ED")]
		[Address(RVA = "0x1687504", Offset = "0x1687504", VA = "0x1687504")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60126EC")]
	[Address(RVA = "0x1687480", Offset = "0x1687480", VA = "0x1687480")]
	public UIHUDReadyVote()
	{
	}

	[Token(Token = "0x60126EE")]
	[Address(RVA = "0x168755C", Offset = "0x168755C", VA = "0x168755C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60126EF")]
	[Address(RVA = "0x1687604", Offset = "0x1687604", VA = "0x1687604", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60126F0")]
	[Address(RVA = "0x1687760", Offset = "0x1687760", VA = "0x1687760")]
	public void SetVoteInfo(bool isBodyVote, int bodyID = -1)
	{
	}

	[Token(Token = "0x60126F1")]
	[Address(RVA = "0x16877E8", Offset = "0x16877E8", VA = "0x16877E8")]
	public void ClearVoteInfo()
	{
	}

	[Token(Token = "0x60126F2")]
	[Address(RVA = "0x1687850", Offset = "0x1687850", VA = "0x1687850")]
	private void ToVote()
	{
	}

	[Token(Token = "0x60126F3")]
	[Address(RVA = "0x1687998", Offset = "0x1687998", VA = "0x1687998")]
	public void SetEnable(bool value)
	{
	}

	[Token(Token = "0x60126F4")]
	[Address(RVA = "0x1687A68", Offset = "0x1687A68", VA = "0x1687A68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
