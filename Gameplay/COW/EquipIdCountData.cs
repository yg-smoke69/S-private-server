using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200017C")]
public class EquipIdCountData
{
	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x4000974")]
	[FieldOffset(Offset = "0xC")]
	public int Count;

	[Token(Token = "0x600089E")]
	[Address(RVA = "0x2539598", Offset = "0x2539598", VA = "0x2539598")]
	public EquipIdCountData()
	{
	}

	[Token(Token = "0x600089F")]
	[Address(RVA = "0x25395A0", Offset = "0x25395A0", VA = "0x25395A0")]
	public static EquipIdCountData Parse(string s)
	{
		return null;
	}
}
