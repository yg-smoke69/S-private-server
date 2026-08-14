using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A63")]
internal class RushingPetsPawn : PetsPawn
{
	[Token(Token = "0x4005C18")]
	[FieldOffset(Offset = "0x2C")]
	public Transform HeadArrow;

	[Token(Token = "0x4005C19")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HeadArrowGo;

	[Token(Token = "0x4005C1A")]
	[FieldOffset(Offset = "0x34")]
	private bool show;

	[Token(Token = "0x600507D")]
	[Address(RVA = "0x316ED38", Offset = "0x316ED38", VA = "0x316ED38")]
	public RushingPetsPawn()
	{
	}

	[Token(Token = "0x600507E")]
	[Address(RVA = "0x316ED40", Offset = "0x316ED40", VA = "0x316ED40")]
	public void ShowIcon(bool showIcon)
	{
	}

	[Token(Token = "0x600507F")]
	[Address(RVA = "0x316EE00", Offset = "0x316EE00", VA = "0x316EE00")]
	public void Update()
	{
	}
}
