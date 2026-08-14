using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A30")]
public class PreviewFeatureAdjust : MonoBehaviour
{
	[Token(Token = "0x4005B37")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 localPos;

	[Token(Token = "0x4005B38")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 localScale;

	[Token(Token = "0x4005B39")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 localRotate;

	[Token(Token = "0x6004F71")]
	[Address(RVA = "0x195AFBC", Offset = "0x195AFBC", VA = "0x195AFBC")]
	public PreviewFeatureAdjust()
	{
	}
}
