using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200086A")]
public class PCHurtHint : MonoBehaviour
{
	[Token(Token = "0x400529D")]
	[FieldOffset(Offset = "0xC")]
	public GameObject HintGo;

	[Token(Token = "0x400529E")]
	[FieldOffset(Offset = "0x10")]
	public TweenAlpha HitGoAlpha;

	[Token(Token = "0x400529F")]
	[FieldOffset(Offset = "0x14")]
	public TweenScale ArrowScale;

	[Token(Token = "0x40052A0")]
	[FieldOffset(Offset = "0x18")]
	public TweenColor ArrowColor;

	[Token(Token = "0x40052A1")]
	[FieldOffset(Offset = "0x1C")]
	public TweenColor ArcColor;

	[Token(Token = "0x40052A2")]
	[FieldOffset(Offset = "0x20")]
	public int HintDurationTime;

	[Token(Token = "0x40052A3")]
	[FieldOffset(Offset = "0x24")]
	public float ArrowUpTime;

	[Token(Token = "0x40052A4")]
	[FieldOffset(Offset = "0x28")]
	public float ArrowDownTime;

	[Token(Token = "0x40052A5")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 ArrowDelateScale;

	[Token(Token = "0x40052A6")]
	[FieldOffset(Offset = "0x38")]
	public int MaxHitLevel;

	[Token(Token = "0x40052A7")]
	[FieldOffset(Offset = "0x3C")]
	public float[] LevelTime;

	[Token(Token = "0x40052A8")]
	[FieldOffset(Offset = "0x40")]
	public Color NormalColor;

	[Token(Token = "0x40052A9")]
	[FieldOffset(Offset = "0x50")]
	public Color DeepColor;

	[Token(Token = "0x6003ADF")]
	[Address(RVA = "0x2980F78", Offset = "0x2980F78", VA = "0x2980F78")]
	public PCHurtHint()
	{
	}
}
