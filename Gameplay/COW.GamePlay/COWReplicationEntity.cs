using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2000413")]
public abstract class COWReplicationEntity : ReplicationEntity
{
	[Token(Token = "0x600141D")]
	[Address(RVA = "0x1E8F108", Offset = "0x1E8F108", VA = "0x1E8F108")]
	protected COWReplicationEntity()
	{
	}

	[Token(Token = "0x600141E")]
	[Address(RVA = "0x1E8F110", Offset = "0x1E8F110", VA = "0x1E8F110", Slot = "27")]
	protected override bool IsLocalEntity()
	{
		return default(bool);
	}

	[Token(Token = "0x600141F")]
	[Address(RVA = "0x1E8F1DC", Offset = "0x1E8F1DC", VA = "0x1E8F1DC", Slot = "28")]
	protected override void RegisterEntity()
	{
	}

	[Token(Token = "0x6001420")]
	[Address(RVA = "0x1E8F31C", Offset = "0x1E8F31C", VA = "0x1E8F31C", Slot = "29")]
	protected override void UnRegisterEntity()
	{
	}
}
