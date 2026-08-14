using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F73")]
public class LobbyFogSetting : MonoBehaviour
{
	[Token(Token = "0x401AC11")]
	[FieldOffset(Offset = "0xC")]
	public bool updateEveryFrame;

	[Token(Token = "0x401AC12")]
	[FieldOffset(Offset = "0x10")]
	public Color fogColor;

	[Token(Token = "0x401AC13")]
	[FieldOffset(Offset = "0x20")]
	public bool useCustomStart;

	[Token(Token = "0x401AC14")]
	[FieldOffset(Offset = "0x24")]
	public float fogStartDistance;

	[Token(Token = "0x401AC15")]
	[FieldOffset(Offset = "0x28")]
	public float fogEndDistance;

	[Token(Token = "0x401AC16")]
	[FieldOffset(Offset = "0x2C")]
	private bool _fogEnabled;

	[Token(Token = "0x401AC17")]
	[FieldOffset(Offset = "0x30")]
	private FogMode _fogMode;

	[Token(Token = "0x401AC18")]
	[FieldOffset(Offset = "0x34")]
	private float _originalStartDistance;

	[Token(Token = "0x401AC19")]
	[FieldOffset(Offset = "0x38")]
	private float _originalEndDistance;

	[Token(Token = "0x401AC1A")]
	[FieldOffset(Offset = "0x3C")]
	private Color _orginalColor;

	[Token(Token = "0x6019D49")]
	[Address(RVA = "0x1C636BC", Offset = "0x1C636BC", VA = "0x1C636BC")]
	public LobbyFogSetting()
	{
	}

	[Token(Token = "0x6019D4A")]
	[Address(RVA = "0x1C636D0", Offset = "0x1C636D0", VA = "0x1C636D0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6019D4B")]
	[Address(RVA = "0x1C636E8", Offset = "0x1C636E8", VA = "0x1C636E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6019D4C")]
	[Address(RVA = "0x1C637B0", Offset = "0x1C637B0", VA = "0x1C637B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6019D4D")]
	[Address(RVA = "0x1C63824", Offset = "0x1C63824", VA = "0x1C63824")]
	private void OnDisable()
	{
	}
}
