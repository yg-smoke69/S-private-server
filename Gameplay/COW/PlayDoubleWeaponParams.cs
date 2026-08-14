using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C7F")]
public class PlayDoubleWeaponParams
{
	[Token(Token = "0x4010FCD")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 offset;

	[Token(Token = "0x4010FCE")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 rotate;

	[Token(Token = "0x4010FCF")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 scale;

	[Token(Token = "0x6012903")]
	[Address(RVA = "0x1C074C0", Offset = "0x1C074C0", VA = "0x1C074C0")]
	public PlayDoubleWeaponParams(Vector3 _offset, Vector3 _rotate, Vector3 _scale)
	{
	}
}
