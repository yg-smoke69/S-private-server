using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003ED1")]
public struct AnimationID : _Attribute
{
	[Token(Token = "0x401A864")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_Value;

	[Token(Token = "0x401A865")]
	[FieldOffset(Offset = "0x0")]
	public static readonly AnimationID INVALID;

	[Token(Token = "0x6019915")]
	[Address(RVA = "0x93D18C", Offset = "0x93D18C", VA = "0x93D18C")]
	private AnimationID(int value)
	{
	}

	[Token(Token = "0x6019916")]
	[Address(RVA = "0x26B3D04", Offset = "0x26B3D04", VA = "0x26B3D04")]
	public static implicit operator int(AnimationID id)
	{
		return default(int);
	}

	[Token(Token = "0x6019917")]
	[Address(RVA = "0x26B459C", Offset = "0x26B459C", VA = "0x26B459C")]
	public static implicit operator AnimationID(int value)
	{
		return default(AnimationID);
	}

	[Token(Token = "0x6019918")]
	[Address(RVA = "0x26B4B28", Offset = "0x26B4B28", VA = "0x26B4B28")]
	public static bool operator ==(AnimationID a, AnimationID b)
	{
		return default(bool);
	}

	[Token(Token = "0x6019919")]
	[Address(RVA = "0x26B4B3C", Offset = "0x26B4B3C", VA = "0x26B4B3C")]
	public static bool operator !=(AnimationID a, AnimationID b)
	{
		return default(bool);
	}

	[Token(Token = "0x601991A")]
	[Address(RVA = "0x93D194", Offset = "0x93D194", VA = "0x93D194", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x601991B")]
	[Address(RVA = "0x93D1BC", Offset = "0x93D1BC", VA = "0x93D1BC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601991C")]
	[Address(RVA = "0x93D1C4", Offset = "0x93D1C4", VA = "0x93D1C4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x601991D")]
	[Address(RVA = "0x93D1EC", Offset = "0x93D1EC", VA = "0x93D1EC")]
	public int GetLayerIndex()
	{
		return default(int);
	}

	[Token(Token = "0x601991E")]
	[Address(RVA = "0x93D200", Offset = "0x93D200", VA = "0x93D200")]
	public int GetID()
	{
		return default(int);
	}

	[Token(Token = "0x601991F")]
	[Address(RVA = "0x26B44F4", Offset = "0x26B44F4", VA = "0x26B44F4")]
	public static int MakeAnimationID(int id, int layerIndex = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6019920")]
	[Address(RVA = "0x93D214", Offset = "0x93D214", VA = "0x93D214", Slot = "4")]
	public bool Equals(AnimationID other)
	{
		return default(bool);
	}
}
