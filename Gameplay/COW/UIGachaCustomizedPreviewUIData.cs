using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002670")]
public class UIGachaCustomizedPreviewUIData
{
	[Token(Token = "0x400ED4E")]
	[FieldOffset(Offset = "0x8")]
	public bool UseCustomizedPosition;

	[Token(Token = "0x400ED4F")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 LeftPreviewPosition;

	[Token(Token = "0x400ED50")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 RightPreviewPosition;

	[Token(Token = "0x400ED51")]
	[FieldOffset(Offset = "0x24")]
	public bool UseCustomizedProperty;

	[Token(Token = "0x600E61C")]
	[Address(RVA = "0x2471268", Offset = "0x2471268", VA = "0x2471268")]
	public UIGachaCustomizedPreviewUIData()
	{
	}
}
