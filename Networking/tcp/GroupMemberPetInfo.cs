using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CE8")]
public class GroupMemberPetInfo
{
	[Token(Token = "0x400B729")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cid_003Ek__BackingField;

	[Token(Token = "0x400B72A")]
	[FieldOffset(Offset = "0xC")]
	private string _003Cname_003Ek__BackingField;

	[Token(Token = "0x400B72B")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Clevel_003Ek__BackingField;

	[Token(Token = "0x400B72C")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cskin_id_003Ek__BackingField;

	[Token(Token = "0x17000B90")]
	public uint id
	{
		[Token(Token = "0x6008663")]
		[Address(RVA = "0x33EB4D8", Offset = "0x33EB4D8", VA = "0x33EB4D8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008664")]
		[Address(RVA = "0x33EB4E0", Offset = "0x33EB4E0", VA = "0x33EB4E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B91")]
	public string name
	{
		[Token(Token = "0x6008665")]
		[Address(RVA = "0x33EB4E8", Offset = "0x33EB4E8", VA = "0x33EB4E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008666")]
		[Address(RVA = "0x33EB4D0", Offset = "0x33EB4D0", VA = "0x33EB4D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B92")]
	public uint level
	{
		[Token(Token = "0x6008667")]
		[Address(RVA = "0x33EB4F0", Offset = "0x33EB4F0", VA = "0x33EB4F0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008668")]
		[Address(RVA = "0x33EB4F8", Offset = "0x33EB4F8", VA = "0x33EB4F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B93")]
	public uint skin_id
	{
		[Token(Token = "0x6008669")]
		[Address(RVA = "0x33EB500", Offset = "0x33EB500", VA = "0x33EB500")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600866A")]
		[Address(RVA = "0x33EB508", Offset = "0x33EB508", VA = "0x33EB508")]
		set
		{
		}
	}

	[Token(Token = "0x6008662")]
	[Address(RVA = "0x33EB430", Offset = "0x33EB430", VA = "0x33EB430")]
	public GroupMemberPetInfo()
	{
	}
}
