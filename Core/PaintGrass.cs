using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F99")]
public class PaintGrass : PaintMeshes
{
	[Token(Token = "0x401ACB0")]
	[FieldOffset(Offset = "0x3C")]
	public Sprite currentSprite;

	[Token(Token = "0x17001C45")]
	public override bool HasMesh
	{
		[Token(Token = "0x6019E0F")]
		[Address(RVA = "0x1C79AD8", Offset = "0x1C79AD8", VA = "0x1C79AD8", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6019E0E")]
	[Address(RVA = "0x1C7994C", Offset = "0x1C7994C", VA = "0x1C7994C")]
	public PaintGrass()
	{
	}
}
