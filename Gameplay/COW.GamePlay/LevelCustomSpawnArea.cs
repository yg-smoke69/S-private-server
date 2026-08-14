using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2000606")]
public class LevelCustomSpawnArea : BaseLevelObject
{
	[Token(Token = "0x400456C")]
	[FieldOffset(Offset = "0x74")]
	public LevelDynamicCollider dynamicCollider;

	[Token(Token = "0x600250D")]
	[Address(RVA = "0x270D68C", Offset = "0x270D68C", VA = "0x270D68C")]
	public LevelCustomSpawnArea()
	{
	}

	[Token(Token = "0x600250E")]
	[Address(RVA = "0x270D694", Offset = "0x270D694", VA = "0x270D694", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600250F")]
	[Address(RVA = "0x270D738", Offset = "0x270D738", VA = "0x270D738", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002510")]
	[Address(RVA = "0x270DA68", Offset = "0x270DA68", VA = "0x270DA68")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
