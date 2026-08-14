using Il2CppDummyDll;
using UnityEngine;

namespace FF_TA;

[Token(Token = "0x2003F53")]
public class GlobalLightSetting : MonoBehaviour
{
	[Token(Token = "0x2003F54")]
	public enum AmbientType
	{
		[Token(Token = "0x401AB3C")]
		Environment_On,
		[Token(Token = "0x401AB3D")]
		Character_Off
	}

	[Token(Token = "0x401AB16")]
	[FieldOffset(Offset = "0xC")]
	public bool _AutoCharacterAmbinet;

	[Token(Token = "0x401AB17")]
	[FieldOffset(Offset = "0x10")]
	public AmbientType _AmbientType;

	[Token(Token = "0x401AB18")]
	[FieldOffset(Offset = "0x14")]
	public bool _PropMode;

	[Token(Token = "0x401AB19")]
	[FieldOffset(Offset = "0x18")]
	public float _bakeyShadow;

	[Token(Token = "0x401AB1A")]
	[FieldOffset(Offset = "0x1C")]
	public Color _AmbientColor;

	[Token(Token = "0x401AB1B")]
	[FieldOffset(Offset = "0x2C")]
	public float _LightScaleLow;

	[Token(Token = "0x401AB1C")]
	[FieldOffset(Offset = "0x30")]
	public float _AoScale;

	[Token(Token = "0x401AB1D")]
	[FieldOffset(Offset = "0x34")]
	public bool _Optimize;

	[Token(Token = "0x401AB1E")]
	[FieldOffset(Offset = "0x38")]
	public float _fogCover;

	[Token(Token = "0x401AB1F")]
	[FieldOffset(Offset = "0x3C")]
	public float _sunPow;

	[Token(Token = "0x401AB20")]
	[FieldOffset(Offset = "0x40")]
	public float _sunIntencity;

	[Token(Token = "0x401AB21")]
	[FieldOffset(Offset = "0x44")]
	public Color _sunColor;

	[Token(Token = "0x401AB22")]
	[FieldOffset(Offset = "0x54")]
	public float _sunDistance;

	[Token(Token = "0x401AB23")]
	[FieldOffset(Offset = "0x58")]
	public Color characterAmbinet;

	[Token(Token = "0x401AB24")]
	[FieldOffset(Offset = "0x68")]
	public Vector4 _custom_SHAr;

	[Token(Token = "0x401AB25")]
	[FieldOffset(Offset = "0x78")]
	public Vector4 _custom_SHAg;

	[Token(Token = "0x401AB26")]
	[FieldOffset(Offset = "0x88")]
	public Vector4 _custom_SHAb;

	[Token(Token = "0x401AB27")]
	[FieldOffset(Offset = "0x98")]
	public Vector4 _custom_SHBr;

	[Token(Token = "0x401AB28")]
	[FieldOffset(Offset = "0xA8")]
	public Vector4 _custom_SHBg;

	[Token(Token = "0x401AB29")]
	[FieldOffset(Offset = "0xB8")]
	public Vector4 _custom_SHBb;

	[Token(Token = "0x401AB2A")]
	[FieldOffset(Offset = "0xC8")]
	public Vector4 _custom_SHC;

	[Token(Token = "0x401AB2B")]
	[FieldOffset(Offset = "0xD8")]
	private int m_custom_SHArID;

	[Token(Token = "0x401AB2C")]
	[FieldOffset(Offset = "0xDC")]
	private int m_custom_SHAgID;

	[Token(Token = "0x401AB2D")]
	[FieldOffset(Offset = "0xE0")]
	private int m_custom_SHAbID;

	[Token(Token = "0x401AB2E")]
	[FieldOffset(Offset = "0xE4")]
	private int m_custom_SHBrID;

	[Token(Token = "0x401AB2F")]
	[FieldOffset(Offset = "0xE8")]
	private int m_custom_SHBgID;

	[Token(Token = "0x401AB30")]
	[FieldOffset(Offset = "0xEC")]
	private int m_custom_SHBbID;

	[Token(Token = "0x401AB31")]
	[FieldOffset(Offset = "0xF0")]
	private int m_custom_SHCID;

	[Token(Token = "0x401AB32")]
	[FieldOffset(Offset = "0xF4")]
	private int m_custom_AmbientColorID;

	[Token(Token = "0x401AB33")]
	[FieldOffset(Offset = "0xF8")]
	private int m_custom_LightScaleLowID;

	[Token(Token = "0x401AB34")]
	[FieldOffset(Offset = "0xFC")]
	private int m_custom_BakedShadowScale;

	[Token(Token = "0x401AB35")]
	[FieldOffset(Offset = "0x100")]
	private int m_custom_fogCoverID;

	[Token(Token = "0x401AB36")]
	[FieldOffset(Offset = "0x104")]
	private int m_custom_sunColID;

	[Token(Token = "0x401AB37")]
	[FieldOffset(Offset = "0x108")]
	private int m_custom_sunIntencityID;

	[Token(Token = "0x401AB38")]
	[FieldOffset(Offset = "0x10C")]
	private int m_custom_sunPowID;

	[Token(Token = "0x401AB39")]
	[FieldOffset(Offset = "0x110")]
	private int m_custom_sunStartEndID;

	[Token(Token = "0x401AB3A")]
	[FieldOffset(Offset = "0x114")]
	private int m_custom_AoScaleID;

	[Token(Token = "0x17001C2C")]
	public float BakeyShadow
	{
		[Token(Token = "0x6019C93")]
		[Address(RVA = "0x26ABA68", Offset = "0x26ABA68", VA = "0x26ABA68")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6019C92")]
	[Address(RVA = "0x26AB77C", Offset = "0x26AB77C", VA = "0x26AB77C")]
	public GlobalLightSetting()
	{
	}

	[Token(Token = "0x6019C94")]
	[Address(RVA = "0x26ABBA8", Offset = "0x26ABBA8", VA = "0x26ABBA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6019C95")]
	[Address(RVA = "0x26ABBF4", Offset = "0x26ABBF4", VA = "0x26ABBF4")]
	private void SetCharacterAmbint()
	{
	}

	[Token(Token = "0x6019C96")]
	[Address(RVA = "0x26ABC2C", Offset = "0x26ABC2C", VA = "0x26ABC2C")]
	private void HideLight()
	{
	}

	[Token(Token = "0x6019C97")]
	[Address(RVA = "0x26ABDC8", Offset = "0x26ABDC8", VA = "0x26ABDC8")]
	private void SetGloalLight()
	{
	}

	[Token(Token = "0x6019C98")]
	[Address(RVA = "0x26ABFF8", Offset = "0x26ABFF8", VA = "0x26ABFF8")]
	private void OnDisable()
	{
	}
}
