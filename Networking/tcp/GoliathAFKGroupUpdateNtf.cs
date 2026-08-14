using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D08")]
public class GoliathAFKGroupUpdateNtf
{
	[Token(Token = "0x400B787")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x17000BCB")]
	public ulong group_id
	{
		[Token(Token = "0x60086F3")]
		[Address(RVA = "0x33E9F58", Offset = "0x33E9F58", VA = "0x33E9F58")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60086F4")]
		[Address(RVA = "0x33E9F60", Offset = "0x33E9F60", VA = "0x33E9F60")]
		set
		{
		}
	}

	[Token(Token = "0x60086F2")]
	[Address(RVA = "0x33E9F50", Offset = "0x33E9F50", VA = "0x33E9F50")]
	public GoliathAFKGroupUpdateNtf()
	{
	}
}
