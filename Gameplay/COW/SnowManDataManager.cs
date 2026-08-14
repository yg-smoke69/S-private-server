using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000236")]
public class SnowManDataManager : SingletonModule<SnowManDataManager>
{
	[Token(Token = "0x6000B3B")]
	[Address(RVA = "0x20F2CBC", Offset = "0x20F2CBC", VA = "0x20F2CBC")]
	public SnowManDataManager()
	{
	}

	[Token(Token = "0x6000B3C")]
	[Address(RVA = "0x20F2D4C", Offset = "0x20F2D4C", VA = "0x20F2D4C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000B3D")]
	[Address(RVA = "0x20F2E6C", Offset = "0x20F2E6C", VA = "0x20F2E6C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000B3E")]
	[Address(RVA = "0x20F2EC0", Offset = "0x20F2EC0", VA = "0x20F2EC0")]
	public List<uint> GetCurrentLevelClothIDs(uint level)
	{
		return null;
	}
}
