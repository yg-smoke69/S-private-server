using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200063B")]
public class LevelIceWallExport : MonoBehaviour
{
	[Token(Token = "0x4004688")]
	[FieldOffset(Offset = "0xC")]
	public Collider[] colliders;

	[Token(Token = "0x4004689")]
	[FieldOffset(Offset = "0x10")]
	public string export_name;

	[Token(Token = "0x400468A")]
	[FieldOffset(Offset = "0x14")]
	public Collider[] collisions;

	[Token(Token = "0x400468B")]
	[FieldOffset(Offset = "0x18")]
	public bool autoExportName;

	[Token(Token = "0x60026B2")]
	[Address(RVA = "0x3113778", Offset = "0x3113778", VA = "0x3113778")]
	public LevelIceWallExport()
	{
	}
}
