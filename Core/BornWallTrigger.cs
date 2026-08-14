using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005B6")]
public class BornWallTrigger : MonoBehaviour
{
	[Token(Token = "0x4004392")]
	[FieldOffset(Offset = "0xC")]
	public GameObject VfxBig;

	[Token(Token = "0x60022B3")]
	[Address(RVA = "0x2ED0DA0", Offset = "0x2ED0DA0", VA = "0x2ED0DA0")]
	public BornWallTrigger()
	{
	}

	[Token(Token = "0x60022B4")]
	[Address(RVA = "0x2ED0DA8", Offset = "0x2ED0DA8", VA = "0x2ED0DA8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60022B5")]
	[Address(RVA = "0x2ED0EFC", Offset = "0x2ED0EFC", VA = "0x2ED0EFC")]
	private void OnTriggerExit(Collider other)
	{
	}
}
