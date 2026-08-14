using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E09")]
internal abstract class SparkEventData_Base
{
	[Token(Token = "0x400BE41")]
	[FieldOffset(Offset = "0x8")]
	public ulong match_id;

	[Token(Token = "0x6008FB4")]
	[Address(RVA = "0x20F5080", Offset = "0x20F5080", VA = "0x20F5080")]
	protected SparkEventData_Base()
	{
	}

	[Token(Token = "0x6008FB5")]
	public abstract string GetEventType();
}
