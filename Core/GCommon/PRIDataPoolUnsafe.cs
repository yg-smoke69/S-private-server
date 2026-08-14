using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200408A")]
public class PRIDataPoolUnsafe : ReplicationDataPoolUnsafe, _Attribute, IConvertible
{
	[Token(Token = "0x401B20A")]
	[FieldOffset(Offset = "0x38")]
	protected ReplicationEntity m_Owner;

	[Token(Token = "0x401B20B")]
	[FieldOffset(Offset = "0x3C")]
	protected uint m_ReplicationID;

	[Token(Token = "0x601A46A")]
	[Address(RVA = "0x2981F2C", Offset = "0x2981F2C", VA = "0x2981F2C")]
	public PRIDataPoolUnsafe(ReplicationEntity owner, uint repID, int maxVarCount)
	{
	}

	[Token(Token = "0x601A46B")]
	[Address(RVA = "0x2981F58", Offset = "0x2981F58", VA = "0x2981F58", Slot = "47")]
	public uint GetReplicationID()
	{
		return default(uint);
	}
}
