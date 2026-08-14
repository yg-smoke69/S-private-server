using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200043A")]
public class CannonFireLine : MonoBehaviour
{
	[Token(Token = "0x4003C07")]
	[FieldOffset(Offset = "0xC")]
	private LineRenderer m_LineRender;

	[Token(Token = "0x4003C08")]
	private const float interval = 0.2f;

	[Token(Token = "0x4003C09")]
	private const int pos_count = 60;

	[Token(Token = "0x4003C0A")]
	private const float grenadeLauncher1stPosRatio = 0.15f;

	[Token(Token = "0x600151A")]
	[Address(RVA = "0x17213B0", Offset = "0x17213B0", VA = "0x17213B0")]
	public CannonFireLine()
	{
	}

	[Token(Token = "0x600151B")]
	[Address(RVA = "0x17213B8", Offset = "0x17213B8", VA = "0x17213B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600151C")]
	[Address(RVA = "0x17214D4", Offset = "0x17214D4", VA = "0x17214D4")]
	private void Update()
	{
	}

	[Token(Token = "0x600151D")]
	[Address(RVA = "0x1721980", Offset = "0x1721980", VA = "0x1721980")]
	private void DrawLine(Vector3 throwPos, Vector3 throwVel, Vector3 gravity)
	{
	}
}
