using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000007")]
public class UVmove : MonoBehaviour
{
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0xC")]
	public int ScrollSpeed;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x10")]
	public int countX;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x14")]
	public int countY;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x18")]
	public int tilingX;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x1C")]
	public int tilingY;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x20")]
	private float offsetX;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x24")]
	private float offsetY;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2A63530", Offset = "0x2A63530", VA = "0x2A63530")]
	public UVmove()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2A63560", Offset = "0x2A63560", VA = "0x2A63560")]
	private void Start()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2A636FC", Offset = "0x2A636FC", VA = "0x2A636FC")]
	private void Update()
	{
	}
}
