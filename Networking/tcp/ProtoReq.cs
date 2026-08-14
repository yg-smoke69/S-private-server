using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D87")]
public class ProtoReq
{
	[Token(Token = "0x400BA8D")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Ccmd_003Ek__BackingField;

	[Token(Token = "0x400BA8E")]
	[FieldOffset(Offset = "0xC")]
	private byte[] _003Cdata_003Ek__BackingField;

	[Token(Token = "0x17000D39")]
	public uint cmd
	{
		[Token(Token = "0x6008A25")]
		[Address(RVA = "0x435D004", Offset = "0x435D004", VA = "0x435D004")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A26")]
		[Address(RVA = "0x435D00C", Offset = "0x435D00C", VA = "0x435D00C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D3A")]
	public byte[] data
	{
		[Token(Token = "0x6008A27")]
		[Address(RVA = "0x435D014", Offset = "0x435D014", VA = "0x435D014")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A28")]
		[Address(RVA = "0x435D01C", Offset = "0x435D01C", VA = "0x435D01C")]
		set
		{
		}
	}

	[Token(Token = "0x6008A24")]
	[Address(RVA = "0x435CFFC", Offset = "0x435CFFC", VA = "0x435CFFC")]
	public ProtoReq()
	{
	}
}
