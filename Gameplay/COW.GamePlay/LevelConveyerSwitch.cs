using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000605")]
public class LevelConveyerSwitch : MonoBehaviour
{
	[Token(Token = "0x400456A")]
	[FieldOffset(Offset = "0xC")]
	public GameObject DynamicLod;

	[Token(Token = "0x400456B")]
	[FieldOffset(Offset = "0x10")]
	public GameObject StaticLod;

	[Token(Token = "0x600250B")]
	[Address(RVA = "0x270D30C", Offset = "0x270D30C", VA = "0x270D30C")]
	public LevelConveyerSwitch()
	{
	}

	[Token(Token = "0x600250C")]
	[Address(RVA = "0x270D314", Offset = "0x270D314", VA = "0x270D314")]
	private void Start()
	{
	}
}
