using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000663")]
public class LevelMotionSwitch : MonoBehaviour
{
	[Token(Token = "0x400479B")]
	[FieldOffset(Offset = "0xC")]
	public LevelMotionPlatform[] PlatformArray;

	[Token(Token = "0x600281E")]
	[Address(RVA = "0x24C993C", Offset = "0x24C993C", VA = "0x24C993C")]
	public LevelMotionSwitch()
	{
	}

	[Token(Token = "0x600281F")]
	[Address(RVA = "0x24C9944", Offset = "0x24C9944", VA = "0x24C9944")]
	private void Start()
	{
	}
}
