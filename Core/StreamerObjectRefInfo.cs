using Il2CppDummyDll;

[Token(Token = "0x2003D23")]
public abstract class StreamerObjectRefInfo
{
	[Token(Token = "0x4019EF7")]
	[FieldOffset(Offset = "0x8")]
	public int RefCount;

	[Token(Token = "0x6018778")]
	[Address(RVA = "0x21DB4F8", Offset = "0x21DB4F8", VA = "0x21DB4F8")]
	protected StreamerObjectRefInfo()
	{
	}

	[Token(Token = "0x6018779")]
	[Address(RVA = "0x21C5218", Offset = "0x21C5218", VA = "0x21C5218")]
	public void InCreaseRefCount()
	{
	}

	[Token(Token = "0x601877A")]
	[Address(RVA = "0x21C4AA0", Offset = "0x21C4AA0", VA = "0x21C4AA0")]
	public void DecreaseRefCount(SceneStreamerInfoHelper helper)
	{
	}

	[Token(Token = "0x601877B")]
	public abstract void UnLoadAsset(SceneStreamerInfoHelper helper);
}
