using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x200062C")]
public class LevelGiantShop : BaseLevelObject
{
	[Token(Token = "0x600263C")]
	[Address(RVA = "0x27257FC", Offset = "0x27257FC", VA = "0x27257FC")]
	public LevelGiantShop()
	{
	}

	[Token(Token = "0x600263D")]
	[Address(RVA = "0x2725804", Offset = "0x2725804", VA = "0x2725804", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600263E")]
	[Address(RVA = "0x27258A8", Offset = "0x27258A8", VA = "0x27258A8")]
	public void OnLocalPlayerEnterTrigger()
	{
	}

	[Token(Token = "0x600263F")]
	[Address(RVA = "0x2725B14", Offset = "0x2725B14", VA = "0x2725B14")]
	public void OnLocalPlayerExitTrigger()
	{
	}
}
