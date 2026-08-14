using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20006B6")]
public class LevelTimingItemGenerator : BaseLevelObject
{
	[Token(Token = "0x4004A77")]
	[FieldOffset(Offset = "0x74")]
	public uint m_ItemID;

	[Token(Token = "0x4004A78")]
	[FieldOffset(Offset = "0x78")]
	public float m_RefreshInterval;

	[Token(Token = "0x6002B1E")]
	[Address(RVA = "0x2423678", Offset = "0x2423678", VA = "0x2423678")]
	public LevelTimingItemGenerator()
	{
	}

	[Token(Token = "0x6002B1F")]
	[Address(RVA = "0x2423680", Offset = "0x2423680", VA = "0x2423680", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002B20")]
	[Address(RVA = "0x2423724", Offset = "0x2423724", VA = "0x2423724", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002B21")]
	[Address(RVA = "0x2423794", Offset = "0x2423794", VA = "0x2423794")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}
}
