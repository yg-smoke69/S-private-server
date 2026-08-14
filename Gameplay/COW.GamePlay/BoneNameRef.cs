using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20007A9")]
public class BoneNameRef : MonoBehaviour
{
	[Token(Token = "0x4004F0A")]
	[FieldOffset(Offset = "0xC")]
	public string BoneName;

	[Token(Token = "0x4004F0B")]
	[FieldOffset(Offset = "0x10")]
	public bool ScaleWithParent;

	[Token(Token = "0x4004F0C")]
	[FieldOffset(Offset = "0x11")]
	public bool LossyScaleWithParent;

	[Token(Token = "0x60030D9")]
	[Address(RVA = "0x13B69E4", Offset = "0x13B69E4", VA = "0x13B69E4")]
	public BoneNameRef()
	{
	}
}
