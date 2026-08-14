using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2000003")]
public class FastAO : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0xC")]
	public bool Fast;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x10")]
	public float AOIntensity;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x14")]
	public float AOBlurAmount;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x18")]
	public float AORadius;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x1C")]
	public float AOArea;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x20")]
	private Camera _cam;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x24")]
	private Material _aoMat;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x28")]
	private Shader _aoShader;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x2C")]
	private CommandBuffer _cmd;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int BLURTEXTUREID;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int instensityString;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int blurAmountString;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int radiusString;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int areaString;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x14")]
	private static readonly string fastKeyword;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x26AC7D4", Offset = "0x26AC7D4", VA = "0x26AC7D4")]
	public FastAO()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x26AC7F0", Offset = "0x26AC7F0", VA = "0x26AC7F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x26AC87C", Offset = "0x26AC87C", VA = "0x26AC87C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x26ACB4C", Offset = "0x26ACB4C", VA = "0x26ACB4C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x26ACDC0", Offset = "0x26ACDC0", VA = "0x26ACDC0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x26AC898", Offset = "0x26AC898", VA = "0x26AC898")]
	private void Init()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x26ACA9C", Offset = "0x26ACA9C", VA = "0x26ACA9C")]
	private void InitCmdBuffer()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x26ACF2C", Offset = "0x26ACF2C", VA = "0x26ACF2C")]
	private void AddCommandBuffer()
	{
	}
}
