using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E89")]
public class SyncedObjectPool<T> : ObjectPool<T> where T : IObjectPoolCallback, new()
{
	[Token(Token = "0x6019726")]
	public SyncedObjectPool()
	{
	}

	[Token(Token = "0x6019727")]
	protected override IObjectPoolCallback AllocObjectInternal()
	{
		return null;
	}

	[Token(Token = "0x6019728")]
	protected override void CollectObjectInternal(T obj)
	{
	}

	[Token(Token = "0x6019729")]
	public override void Clear()
	{
	}
}
