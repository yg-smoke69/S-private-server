using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F4F")]
public class FiveYearsSkyboxController : MonoBehaviour
{
	[Token(Token = "0x401AAFC")]
	[FieldOffset(Offset = "0xC")]
	public Material material;

	[Token(Token = "0x401AAFD")]
	[FieldOffset(Offset = "0x10")]
	public float SunSize;

	[Token(Token = "0x401AAFE")]
	[FieldOffset(Offset = "0x14")]
	public float SunSizeConvergence;

	[Token(Token = "0x401AAFF")]
	[FieldOffset(Offset = "0x18")]
	public float AtmosphereThickness;

	[Token(Token = "0x401AB00")]
	[FieldOffset(Offset = "0x1C")]
	public Color SkyTint;

	[Token(Token = "0x401AB01")]
	[FieldOffset(Offset = "0x2C")]
	public Color GroundColor;

	[Token(Token = "0x401AB02")]
	[FieldOffset(Offset = "0x3C")]
	public float Exposure;

	[Token(Token = "0x401AB03")]
	[FieldOffset(Offset = "0x40")]
	private int _SunSize;

	[Token(Token = "0x401AB04")]
	[FieldOffset(Offset = "0x44")]
	private int _SunSizeConvergence;

	[Token(Token = "0x401AB05")]
	[FieldOffset(Offset = "0x48")]
	private int _AtmosphereThickness;

	[Token(Token = "0x401AB06")]
	[FieldOffset(Offset = "0x4C")]
	private int _SkyTint;

	[Token(Token = "0x401AB07")]
	[FieldOffset(Offset = "0x50")]
	private int _GroundColor;

	[Token(Token = "0x401AB08")]
	[FieldOffset(Offset = "0x54")]
	private int _Exposure;

	[Token(Token = "0x6019C7B")]
	[Address(RVA = "0x26AD730", Offset = "0x26AD730", VA = "0x26AD730")]
	public FiveYearsSkyboxController()
	{
	}

	[Token(Token = "0x6019C7C")]
	[Address(RVA = "0x26AD738", Offset = "0x26AD738", VA = "0x26AD738")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019C7D")]
	[Address(RVA = "0x26AD82C", Offset = "0x26AD82C", VA = "0x26AD82C")]
	private void Start()
	{
	}

	[Token(Token = "0x6019C7E")]
	[Address(RVA = "0x26AD9F4", Offset = "0x26AD9F4", VA = "0x26AD9F4")]
	private void Update()
	{
	}
}
