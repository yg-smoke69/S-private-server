using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x200061F")]
public class LevelFeedZone : BaseLevelObject
{
	[Token(Token = "0x4004606")]
	[FieldOffset(Offset = "0x74")]
	public uint teammodeid;

	[Token(Token = "0x4004607")]
	[FieldOffset(Offset = "0x78")]
	public int milestoneid;

	[Token(Token = "0x60025E1")]
	[Address(RVA = "0x2721080", Offset = "0x2721080", VA = "0x2721080")]
	public LevelFeedZone()
	{
	}

	[Token(Token = "0x60025E2")]
	[Address(RVA = "0x2721088", Offset = "0x2721088", VA = "0x2721088")]
	public void OnLocalPlayerEnterTrigger()
	{
	}

	[Token(Token = "0x60025E3")]
	[Address(RVA = "0x2721408", Offset = "0x2721408", VA = "0x2721408")]
	public void OnLocalPlayerExitTrigger()
	{
	}

	[Token(Token = "0x60025E4")]
	[Address(RVA = "0x2721618", Offset = "0x2721618", VA = "0x2721618", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}
}
