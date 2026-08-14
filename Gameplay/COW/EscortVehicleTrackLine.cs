using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200043C")]
public class EscortVehicleTrackLine : MonoBehaviour
{
	[Token(Token = "0x4003C0E")]
	[FieldOffset(Offset = "0xC")]
	private bool m_showLaunchLine;

	[Token(Token = "0x4003C0F")]
	[FieldOffset(Offset = "0x10")]
	public LineRenderer m_LineRender;

	[Token(Token = "0x4003C10")]
	private const float interval = 0.2f;

	[Token(Token = "0x4003C11")]
	private const int pos_count = 60;

	[Token(Token = "0x4003C12")]
	[FieldOffset(Offset = "0x14")]
	public Transform[] m_Positions;

	[Token(Token = "0x6001522")]
	[Address(RVA = "0x2539B68", Offset = "0x2539B68", VA = "0x2539B68")]
	public EscortVehicleTrackLine()
	{
	}

	[Token(Token = "0x6001523")]
	[Address(RVA = "0x2539B70", Offset = "0x2539B70", VA = "0x2539B70")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001524")]
	[Address(RVA = "0x2539C68", Offset = "0x2539C68", VA = "0x2539C68")]
	private void Start()
	{
	}

	[Token(Token = "0x6001525")]
	[Address(RVA = "0x2539D70", Offset = "0x2539D70", VA = "0x2539D70")]
	public void DrawLine()
	{
	}
}
