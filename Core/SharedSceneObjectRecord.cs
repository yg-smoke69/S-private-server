using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003FE4")]
public class SharedSceneObjectRecord
{
	[Token(Token = "0x401AE7F")]
	[FieldOffset(Offset = "0x8")]
	public int refCount;

	[Token(Token = "0x401AE80")]
	[FieldOffset(Offset = "0xC")]
	public GameObject sceneObject;

	[Token(Token = "0x601A024")]
	[Address(RVA = "0x21C60E8", Offset = "0x21C60E8", VA = "0x21C60E8")]
	public SharedSceneObjectRecord()
	{
	}
}
