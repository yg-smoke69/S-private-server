using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B10")]
public class BountyTimeLineSubtitleController : MonoBehaviour
{
	[Token(Token = "0x4005F89")]
	[FieldOffset(Offset = "0xC")]
	public float BeginTime;

	[Token(Token = "0x4005F8A")]
	[FieldOffset(Offset = "0x10")]
	public float ShowDuration;

	[Token(Token = "0x4005F8B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ShowRoot;

	[Token(Token = "0x4005F8C")]
	[FieldOffset(Offset = "0x18")]
	private float m_ActiveTime;

	[Token(Token = "0x4005F8D")]
	[FieldOffset(Offset = "0x1C")]
	private float m_ShowedTime;

	[Token(Token = "0x60054FB")]
	[Address(RVA = "0x2ED8DC4", Offset = "0x2ED8DC4", VA = "0x2ED8DC4")]
	public BountyTimeLineSubtitleController()
	{
	}

	[Token(Token = "0x60054FC")]
	[Address(RVA = "0x2ED8DCC", Offset = "0x2ED8DCC", VA = "0x2ED8DCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60054FD")]
	[Address(RVA = "0x2ED8DFC", Offset = "0x2ED8DFC", VA = "0x2ED8DFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60054FE")]
	[Address(RVA = "0x2ED8E20", Offset = "0x2ED8E20", VA = "0x2ED8E20")]
	private void Update()
	{
	}
}
