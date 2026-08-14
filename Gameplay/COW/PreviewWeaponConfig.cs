using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C86")]
public class PreviewWeaponConfig
{
	[Token(Token = "0x4010FE8")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 Rotation;

	[Token(Token = "0x4010FE9")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 PosOffSet;

	[Token(Token = "0x6012921")]
	[Address(RVA = "0x1968298", Offset = "0x1968298", VA = "0x1968298")]
	public PreviewWeaponConfig()
	{
	}
}
