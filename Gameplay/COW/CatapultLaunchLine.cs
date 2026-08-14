using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200043B")]
public class CatapultLaunchLine : MonoBehaviour
{
	[Token(Token = "0x4003C0B")]
	[FieldOffset(Offset = "0xC")]
	private LineRenderer m_LineRender;

	[Token(Token = "0x4003C0C")]
	private const float interval = 0.2f;

	[Token(Token = "0x4003C0D")]
	private const int pos_count = 60;

	[Token(Token = "0x600151E")]
	[Address(RVA = "0x1721C0C", Offset = "0x1721C0C", VA = "0x1721C0C")]
	public CatapultLaunchLine()
	{
	}

	[Token(Token = "0x600151F")]
	[Address(RVA = "0x1721C14", Offset = "0x1721C14", VA = "0x1721C14")]
	private void Start()
	{
	}

	[Token(Token = "0x6001520")]
	[Address(RVA = "0x1721D30", Offset = "0x1721D30", VA = "0x1721D30")]
	private void Update()
	{
	}

	[Token(Token = "0x6001521")]
	[Address(RVA = "0x1722190", Offset = "0x1722190", VA = "0x1722190")]
	private void DrawLine(Vector3 throwPos, Vector3 throwVel, Vector3 gravity)
	{
	}
}
