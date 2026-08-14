using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A67")]
public class DrawArrow : MonoBehaviour
{
	[Token(Token = "0x4005C21")]
	[FieldOffset(Offset = "0xC")]
	public Transform m_Transform;

	[Token(Token = "0x4005C22")]
	[FieldOffset(Offset = "0x10")]
	public float m_Length;

	[Token(Token = "0x4005C23")]
	[FieldOffset(Offset = "0x14")]
	public Color m_Color;

	[Token(Token = "0x4005C24")]
	[FieldOffset(Offset = "0x24")]
	public Transform[] m_Target;

	[Token(Token = "0x6005087")]
	[Address(RVA = "0x2323B70", Offset = "0x2323B70", VA = "0x2323B70")]
	public DrawArrow()
	{
	}

	[Token(Token = "0x6005088")]
	[Address(RVA = "0x2323BBC", Offset = "0x2323BBC", VA = "0x2323BBC")]
	private void Reset()
	{
	}

	[Token(Token = "0x6005089")]
	[Address(RVA = "0x2323BD8", Offset = "0x2323BD8", VA = "0x2323BD8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600508A")]
	[Address(RVA = "0x2323F44", Offset = "0x2323F44", VA = "0x2323F44")]
	public static void ForGizmo(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20f)
	{
	}
}
