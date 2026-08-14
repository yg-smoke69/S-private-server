using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004080")]
public class ReplicationData
{
	[Token(Token = "0x401B1F4")]
	[FieldOffset(Offset = "0x8")]
	public EReplicationInfoGroup GroupID;

	[Token(Token = "0x401B1F5")]
	[FieldOffset(Offset = "0xC")]
	public object Value;

	[Token(Token = "0x601A3B6")]
	[Address(RVA = "0x332B5DC", Offset = "0x332B5DC", VA = "0x332B5DC")]
	public ReplicationData()
	{
	}
}
