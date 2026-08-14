using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F71")]
public class LineRendererFollower : MonoBehaviour
{
	[Token(Token = "0x401ABF8")]
	[FieldOffset(Offset = "0xC")]
	public LineRenderer line;

	[Token(Token = "0x401ABF9")]
	[FieldOffset(Offset = "0x10")]
	public float progress;

	[Token(Token = "0x401ABFA")]
	[FieldOffset(Offset = "0x14")]
	private float m_currentProgress;

	[Token(Token = "0x401ABFB")]
	[FieldOffset(Offset = "0x18")]
	private bool m_useWorldSpace;

	[Token(Token = "0x6019D3D")]
	[Address(RVA = "0x3117A34", Offset = "0x3117A34", VA = "0x3117A34")]
	public LineRendererFollower()
	{
	}

	[Token(Token = "0x6019D3E")]
	[Address(RVA = "0x3117A50", Offset = "0x3117A50", VA = "0x3117A50")]
	private void Update()
	{
	}
}
