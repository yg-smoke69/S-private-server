using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CED")]
public class ShowPetActionNtf
{
	[Token(Token = "0x400B737")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B738")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Caction_id_003Ek__BackingField;

	[Token(Token = "0x17000B9E")]
	public ulong account_id
	{
		[Token(Token = "0x6008684")]
		[Address(RVA = "0x435F2E0", Offset = "0x435F2E0", VA = "0x435F2E0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008685")]
		[Address(RVA = "0x435F2E8", Offset = "0x435F2E8", VA = "0x435F2E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B9F")]
	public uint action_id
	{
		[Token(Token = "0x6008686")]
		[Address(RVA = "0x435F2F8", Offset = "0x435F2F8", VA = "0x435F2F8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008687")]
		[Address(RVA = "0x435F300", Offset = "0x435F300", VA = "0x435F300")]
		set
		{
		}
	}

	[Token(Token = "0x6008683")]
	[Address(RVA = "0x435F2D8", Offset = "0x435F2D8", VA = "0x435F2D8")]
	public ShowPetActionNtf()
	{
	}
}
