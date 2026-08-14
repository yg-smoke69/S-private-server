using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000AC0")]
public class SceneEditDestructiblePartObject : MonoBehaviour
{
	[Token(Token = "0x4005DE4")]
	[FieldOffset(Offset = "0xC")]
	public uint PartID;

	[Token(Token = "0x4005DE5")]
	[FieldOffset(Offset = "0x10")]
	public uint PartHP;

	[Token(Token = "0x4005DE6")]
	[FieldOffset(Offset = "0x14")]
	public OAHOIHCMOLG PartType;

	[Token(Token = "0x4005DE7")]
	[FieldOffset(Offset = "0x18")]
	public string PartEffectResourceStr;

	[Token(Token = "0x4005DE8")]
	[FieldOffset(Offset = "0x1C")]
	public Transform PartEffectContainer;

	[Token(Token = "0x600526C")]
	[Address(RVA = "0x29CCFEC", Offset = "0x29CCFEC", VA = "0x29CCFEC")]
	public SceneEditDestructiblePartObject()
	{
	}
}
