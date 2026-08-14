using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C4F")]
public class ActivityUpdateInfo
{
	[Token(Token = "0x400B43D")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cid_003Ek__BackingField;

	[Token(Token = "0x400B43E")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cdata_003Ek__BackingField;

	[Token(Token = "0x400B43F")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cstate_003Ek__BackingField;

	[Token(Token = "0x400B440")]
	[FieldOffset(Offset = "0x14")]
	private string _003Ccontext_003Ek__BackingField;

	[Token(Token = "0x170009F2")]
	public uint id
	{
		[Token(Token = "0x60082B9")]
		[Address(RVA = "0x33E790C", Offset = "0x33E790C", VA = "0x33E790C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082BA")]
		[Address(RVA = "0x33E7914", Offset = "0x33E7914", VA = "0x33E7914")]
		set
		{
		}
	}

	[Token(Token = "0x170009F3")]
	public uint data
	{
		[Token(Token = "0x60082BB")]
		[Address(RVA = "0x33E791C", Offset = "0x33E791C", VA = "0x33E791C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082BC")]
		[Address(RVA = "0x33E7924", Offset = "0x33E7924", VA = "0x33E7924")]
		set
		{
		}
	}

	[Token(Token = "0x170009F4")]
	public uint state
	{
		[Token(Token = "0x60082BD")]
		[Address(RVA = "0x33E792C", Offset = "0x33E792C", VA = "0x33E792C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082BE")]
		[Address(RVA = "0x33E7934", Offset = "0x33E7934", VA = "0x33E7934")]
		set
		{
		}
	}

	[Token(Token = "0x170009F5")]
	public string context
	{
		[Token(Token = "0x60082BF")]
		[Address(RVA = "0x33E793C", Offset = "0x33E793C", VA = "0x33E793C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082C0")]
		[Address(RVA = "0x33E7904", Offset = "0x33E7904", VA = "0x33E7904")]
		set
		{
		}
	}

	[Token(Token = "0x60082B8")]
	[Address(RVA = "0x33E7864", Offset = "0x33E7864", VA = "0x33E7864")]
	public ActivityUpdateInfo()
	{
	}
}
