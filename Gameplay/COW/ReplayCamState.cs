using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A61")]
internal struct ReplayCamState
{
	[Token(Token = "0x4005BFC")]
	[FieldOffset(Offset = "0x0")]
	public FOFJEMOKAOH.CLCKGCKMDNE Mode;

	[Token(Token = "0x4005BFD")]
	[FieldOffset(Offset = "0x8")]
	public IHAAMHPPLMG Id;

	[Token(Token = "0x4005BFE")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 Position;

	[Token(Token = "0x4005BFF")]
	[FieldOffset(Offset = "0x2C")]
	public Quaternion Rotation;
}
