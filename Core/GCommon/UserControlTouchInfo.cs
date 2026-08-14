using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EE6")]
public class UserControlTouchInfo
{
	[Token(Token = "0x401A918")]
	[FieldOffset(Offset = "0x8")]
	public int TouchFinger;

	[Token(Token = "0x401A919")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 TouchPosition;

	[Token(Token = "0x401A91A")]
	[FieldOffset(Offset = "0x18")]
	public TouchPhase TouchPhase;

	[Token(Token = "0x401A91B")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 DeltaPosition;

	[Token(Token = "0x60199F3")]
	[Address(RVA = "0x2BCEF84", Offset = "0x2BCEF84", VA = "0x2BCEF84")]
	public UserControlTouchInfo()
	{
	}

	[Token(Token = "0x60199F4")]
	[Address(RVA = "0x2BD3EE4", Offset = "0x2BD3EE4", VA = "0x2BD3EE4")]
	public void Copy(UserControlTouchInfo t)
	{
	}
}
