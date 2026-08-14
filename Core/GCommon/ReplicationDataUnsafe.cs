using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004088")]
public class ReplicationDataUnsafe
{
	[Token(Token = "0x401B1FC")]
	[FieldOffset(Offset = "0x8")]
	public EReplicationInfoGroup GroupID;

	[Token(Token = "0x401B1FD")]
	[FieldOffset(Offset = "0xC")]
	public unsafe void* Value;

	[Token(Token = "0x601A43A")]
	[Address(RVA = "0x332C7D4", Offset = "0x332C7D4", VA = "0x332C7D4")]
	public ReplicationDataUnsafe()
	{
	}
}
