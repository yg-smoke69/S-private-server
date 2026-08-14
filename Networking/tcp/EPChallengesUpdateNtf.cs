using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CB5")]
public class EPChallengesUpdateNtf
{
	[Token(Token = "0x400B5A5")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B5A6")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cep_id_003Ek__BackingField;

	[Token(Token = "0x400B5A7")]
	[FieldOffset(Offset = "0x14")]
	private List<EPChallengesUpdateInfo> _003Cupdate_info_003Ek__BackingField;

	[Token(Token = "0x400B5A8")]
	[FieldOffset(Offset = "0x18")]
	private EPChallengeIDsCompletedInfo _003Ccompleted_info_003Ek__BackingField;

	[Token(Token = "0x17000AC5")]
	public ulong account_id
	{
		[Token(Token = "0x60084AA")]
		[Address(RVA = "0x33E91B8", Offset = "0x33E91B8", VA = "0x33E91B8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60084AB")]
		[Address(RVA = "0x33E91C0", Offset = "0x33E91C0", VA = "0x33E91C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000AC6")]
	public uint ep_id
	{
		[Token(Token = "0x60084AC")]
		[Address(RVA = "0x33E91D0", Offset = "0x33E91D0", VA = "0x33E91D0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084AD")]
		[Address(RVA = "0x33E91D8", Offset = "0x33E91D8", VA = "0x33E91D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AC7")]
	public List<EPChallengesUpdateInfo> update_info
	{
		[Token(Token = "0x60084AE")]
		[Address(RVA = "0x33E91E0", Offset = "0x33E91E0", VA = "0x33E91E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084AF")]
		[Address(RVA = "0x33E91B0", Offset = "0x33E91B0", VA = "0x33E91B0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000AC8")]
	public EPChallengeIDsCompletedInfo completed_info
	{
		[Token(Token = "0x60084B0")]
		[Address(RVA = "0x33E91E8", Offset = "0x33E91E8", VA = "0x33E91E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084B1")]
		[Address(RVA = "0x33E91F0", Offset = "0x33E91F0", VA = "0x33E91F0")]
		set
		{
		}
	}

	[Token(Token = "0x60084A9")]
	[Address(RVA = "0x33E9124", Offset = "0x33E9124", VA = "0x33E9124")]
	public EPChallengesUpdateNtf()
	{
	}
}
