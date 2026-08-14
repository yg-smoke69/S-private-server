using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CD8")]
public class ChangePubPvtReq
{
	[Token(Token = "0x400B6BE")]
	[FieldOffset(Offset = "0x8")]
	private bool _003Cis_public_003Ek__BackingField;

	[Token(Token = "0x17000B25")]
	public bool is_public
	{
		[Token(Token = "0x600857D")]
		[Address(RVA = "0x33E8388", Offset = "0x33E8388", VA = "0x33E8388")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600857E")]
		[Address(RVA = "0x33E8390", Offset = "0x33E8390", VA = "0x33E8390")]
		set
		{
		}
	}

	[Token(Token = "0x600857C")]
	[Address(RVA = "0x33E8380", Offset = "0x33E8380", VA = "0x33E8380")]
	public ChangePubPvtReq()
	{
	}
}
