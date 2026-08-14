using System;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20031FE")]
public class RelationshipInfo
{
	[Token(Token = "0x4013081")]
	[FieldOffset(Offset = "0x8")]
	public int OldIntimacy;

	[Token(Token = "0x4013082")]
	[FieldOffset(Offset = "0xC")]
	private IntimacyState _003CIntimcyState_003Ek__BackingField;

	[Token(Token = "0x4013083")]
	[FieldOffset(Offset = "0x10")]
	private uint m_DelayCall;

	[Token(Token = "0x4013084")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700163B")]
	public EFriend.SpecialFriendState CurrentRelationshipState
	{
		[Token(Token = "0x601517D")]
		[Address(RVA = "0x1973334", Offset = "0x1973334", VA = "0x1973334")]
		get
		{
			return default(EFriend.SpecialFriendState);
		}
		[Token(Token = "0x601517E")]
		[Address(RVA = "0x19733A8", Offset = "0x19733A8", VA = "0x19733A8")]
		set
		{
		}
	}

	[Token(Token = "0x1700163C")]
	public bool Visible
	{
		[Token(Token = "0x601517F")]
		[Address(RVA = "0x1973414", Offset = "0x1973414", VA = "0x1973414")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6015180")]
		[Address(RVA = "0x197348C", Offset = "0x197348C", VA = "0x197348C")]
		set
		{
		}
	}

	[Token(Token = "0x1700163D")]
	public IntimacyState IntimcyState
	{
		[Token(Token = "0x6015181")]
		[Address(RVA = "0x19733A0", Offset = "0x19733A0", VA = "0x19733A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015182")]
		[Address(RVA = "0x19734F8", Offset = "0x19734F8", VA = "0x19734F8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700163E")]
	public FriendAccountInfo CurrentTargetFriend
	{
		[Token(Token = "0x6015183")]
		[Address(RVA = "0x1973500", Offset = "0x1973500", VA = "0x1973500")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015184")]
		[Address(RVA = "0x1973668", Offset = "0x1973668", VA = "0x1973668")]
		private set
		{
		}
	}

	[Token(Token = "0x601517C")]
	[Address(RVA = "0x1973324", Offset = "0x1973324", VA = "0x1973324")]
	public RelationshipInfo()
	{
	}

	[Token(Token = "0x6015185")]
	[Address(RVA = "0x19736C4", Offset = "0x19736C4", VA = "0x19736C4")]
	public static RelationshipInfo Createrelationship(IntimacyState state)
	{
		return null;
	}

	[Token(Token = "0x6015186")]
	[Address(RVA = "0x1973A9C", Offset = "0x1973A9C", VA = "0x1973A9C")]
	public void UpdateRelationshipState(EFriend.SpecialFriendState state)
	{
	}

	[Token(Token = "0x6015187")]
	[Address(RVA = "0x1973B10", Offset = "0x1973B10", VA = "0x1973B10", Slot = "1")]
	~RelationshipInfo()
	{
	}

	[Token(Token = "0x6015188")]
	[Address(RVA = "0x1973C18", Offset = "0x1973C18", VA = "0x1973C18")]
	private void SetStateCountDown(float validTime)
	{
	}

	[Token(Token = "0x6015189")]
	[Address(RVA = "0x19737B8", Offset = "0x19737B8", VA = "0x19737B8")]
	private void InitRelationshipState()
	{
	}

	[Token(Token = "0x601518A")]
	[Address(RVA = "0x1973DC4", Offset = "0x1973DC4", VA = "0x1973DC4")]
	private static void _003CSetStateCountDown_003Em__0()
	{
	}
}
