using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B38")]
public class AnchorPoint : MonoBehaviour
{
	[Token(Token = "0x4006089")]
	[FieldOffset(Offset = "0xC")]
	private LineRenderer m_lineRenderer;

	[Token(Token = "0x400608A")]
	[FieldOffset(Offset = "0x10")]
	public GameObject ControlNode1;

	[Token(Token = "0x400608B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ControlNode2;

	[Token(Token = "0x400608C")]
	[FieldOffset(Offset = "0x18")]
	public float minDistance;

	[Token(Token = "0x600562A")]
	[Address(RVA = "0x2ECA1C0", Offset = "0x2ECA1C0", VA = "0x2ECA1C0")]
	public AnchorPoint()
	{
	}
}
