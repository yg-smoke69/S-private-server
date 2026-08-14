using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002D3")]
public class VisualDataHandles : MonoBehaviour
{
	[Token(Token = "0x4003318")]
	[FieldOffset(Offset = "0xC")]
	public Color Color;

	[Token(Token = "0x4003319")]
	[FieldOffset(Offset = "0x1C")]
	public float Radius;

	[Token(Token = "0x400331A")]
	[FieldOffset(Offset = "0x20")]
	public bool Drawed;

	[Token(Token = "0x6000D99")]
	[Address(RVA = "0x2A6A6FC", Offset = "0x2A6A6FC", VA = "0x2A6A6FC")]
	public VisualDataHandles()
	{
	}

	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x2A6A748", Offset = "0x2A6A748", VA = "0x2A6A748")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x2A6A7F4", Offset = "0x2A6A7F4", VA = "0x2A6A7F4")]
	public void SetHeat(int heat, int max = 200, int min = 0)
	{
	}
}
