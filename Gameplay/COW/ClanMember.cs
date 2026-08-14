using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002F98")]
public class ClanMember : _Attribute
{
	[Token(Token = "0x2002F99")]
	private sealed class _003CCompareTo_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012263")]
		[FieldOffset(Offset = "0x8")]
		internal ClanMember other;

		[Token(Token = "0x4012264")]
		[FieldOffset(Offset = "0xC")]
		internal ClanMember _0024this;

		[Token(Token = "0x6013E59")]
		[Address(RVA = "0x172BE40", Offset = "0x172BE40", VA = "0x172BE40")]
		public _003CCompareTo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013E5A")]
		[Address(RVA = "0x172BE48", Offset = "0x172BE48", VA = "0x172BE48")]
		internal bool _003C_003Em__0(TeamMemberWithAccountInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x6013E5B")]
		[Address(RVA = "0x172BEC4", Offset = "0x172BEC4", VA = "0x172BEC4")]
		internal bool _003C_003Em__1(TeamMemberWithAccountInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401225C")]
	[FieldOffset(Offset = "0x8")]
	public BaseProfileInfo m_AccountInfo;

	[Token(Token = "0x401225D")]
	[FieldOffset(Offset = "0xC")]
	public EClanRole m_Role;

	[Token(Token = "0x401225E")]
	[FieldOffset(Offset = "0x10")]
	public EPresence.AccountPresence m_Status;

	[Token(Token = "0x401225F")]
	[FieldOffset(Offset = "0x14")]
	public uint m_HonorPoint;

	[Token(Token = "0x4012260")]
	[FieldOffset(Offset = "0x18")]
	public uint m_RacePoint;

	[Token(Token = "0x4012261")]
	[FieldOffset(Offset = "0x20")]
	public ulong m_LastGainRPAt;

	[Token(Token = "0x4012262")]
	[FieldOffset(Offset = "0x28")]
	public ulong m_JoinAt;

	[Token(Token = "0x6013E55")]
	[Address(RVA = "0x172B608", Offset = "0x172B608", VA = "0x172B608")]
	public ClanMember()
	{
	}

	[Token(Token = "0x6013E56")]
	[Address(RVA = "0x172B684", Offset = "0x172B684", VA = "0x172B684")]
	public static implicit operator ClanMember(ClanMemberWithAccountInfo data)
	{
		return null;
	}

	[Token(Token = "0x6013E57")]
	[Address(RVA = "0x172B890", Offset = "0x172B890", VA = "0x172B890")]
	public void SetPresenceStatus(uint presence, ulong groupId)
	{
	}

	[Token(Token = "0x6013E58")]
	[Address(RVA = "0x172B9EC", Offset = "0x172B9EC", VA = "0x172B9EC", Slot = "4")]
	public int CompareTo(ClanMember other)
	{
		return default(int);
	}
}
