using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004176")]
public class UITriangleSprite : UISprite
{
	[Token(Token = "0x2004177")]
	public enum Verts
	{
		[Token(Token = "0x401B744")]
		LeftBottom,
		[Token(Token = "0x401B745")]
		LeftTop,
		[Token(Token = "0x401B746")]
		RightTop,
		[Token(Token = "0x401B747")]
		RightBottom
	}

	[Token(Token = "0x401B742")]
	[FieldOffset(Offset = "0x1D4")]
	public Verts IngoreVert;

	[Token(Token = "0x601ABF5")]
	[Address(RVA = "0x2BC1C78", Offset = "0x2BC1C78", VA = "0x2BC1C78")]
	public UITriangleSprite()
	{
	}

	[Token(Token = "0x601ABF6")]
	[Address(RVA = "0x2BC1CFC", Offset = "0x2BC1CFC", VA = "0x2BC1CFC", Slot = "46")]
	protected override void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}
}
