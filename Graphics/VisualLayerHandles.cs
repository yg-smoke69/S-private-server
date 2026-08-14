using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002D4")]
public class VisualLayerHandles : MonoBehaviour
{
	[Token(Token = "0x400331B")]
	[FieldOffset(Offset = "0xC")]
	public float MinHeight;

	[Token(Token = "0x400331C")]
	[FieldOffset(Offset = "0x10")]
	public float MaxHeight;

	[Token(Token = "0x400331D")]
	[FieldOffset(Offset = "0x14")]
	public Camera DisplayCamera;

	[Token(Token = "0x400331E")]
	[FieldOffset(Offset = "0x18")]
	public object[][] PointDatas;

	[Token(Token = "0x400331F")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsShowing;

	[Token(Token = "0x4003320")]
	[FieldOffset(Offset = "0x20")]
	public float LayerRadioBase;

	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x2A6A8E8", Offset = "0x2A6A8E8", VA = "0x2A6A8E8")]
	public VisualLayerHandles()
	{
	}

	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x2A6A8F0", Offset = "0x2A6A8F0", VA = "0x2A6A8F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x2A6AA98", Offset = "0x2A6AA98", VA = "0x2A6AA98")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x2A6ABC4", Offset = "0x2A6ABC4", VA = "0x2A6ABC4")]
	private void OnDrawGizmos()
	{
	}
}
