using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F61")]
public class HeightFog : MonoBehaviour
{
	[Token(Token = "0x401ABC4")]
	[FieldOffset(Offset = "0xC")]
	public Color highColor;

	[Token(Token = "0x401ABC5")]
	[FieldOffset(Offset = "0x1C")]
	public Color midColor;

	[Token(Token = "0x401ABC6")]
	[FieldOffset(Offset = "0x2C")]
	public Color lowColor;

	[Token(Token = "0x401ABC7")]
	[FieldOffset(Offset = "0x3C")]
	public Vector4 lerpLowMidHigh;

	[Token(Token = "0x401ABC8")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 lerpStartEndAnd;

	[Token(Token = "0x401ABC9")]
	[FieldOffset(Offset = "0x54")]
	public float intensity;

	[Token(Token = "0x401ABCA")]
	[FieldOffset(Offset = "0x58")]
	private int[] propsID;

	[Token(Token = "0x6019D08")]
	[Address(RVA = "0x3517E38", Offset = "0x3517E38", VA = "0x3517E38")]
	public HeightFog()
	{
	}

	[Token(Token = "0x6019D09")]
	[Address(RVA = "0x3517F24", Offset = "0x3517F24", VA = "0x3517F24")]
	private void Start()
	{
	}

	[Token(Token = "0x6019D0A")]
	[Address(RVA = "0x35180D4", Offset = "0x35180D4", VA = "0x35180D4")]
	private void UpdateProps()
	{
	}

	[Token(Token = "0x6019D0B")]
	[Address(RVA = "0x3518334", Offset = "0x3518334", VA = "0x3518334")]
	private void Update()
	{
	}
}
