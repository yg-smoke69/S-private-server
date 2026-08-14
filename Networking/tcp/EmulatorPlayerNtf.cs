using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D26")]
public class EmulatorPlayerNtf
{
	[Token(Token = "0x400B831")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cemulator_account_id_003Ek__BackingField;

	[Token(Token = "0x17000C1E")]
	public ulong emulator_account_id
	{
		[Token(Token = "0x60087AD")]
		[Address(RVA = "0x33E92A0", Offset = "0x33E92A0", VA = "0x33E92A0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60087AE")]
		[Address(RVA = "0x33E92A8", Offset = "0x33E92A8", VA = "0x33E92A8")]
		set
		{
		}
	}

	[Token(Token = "0x60087AC")]
	[Address(RVA = "0x33E9298", Offset = "0x33E9298", VA = "0x33E9298")]
	public EmulatorPlayerNtf()
	{
	}
}
