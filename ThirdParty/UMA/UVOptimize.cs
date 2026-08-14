using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CED")]
public static class UVOptimize
{
	[Token(Token = "0x601860D")]
	[Address(RVA = "0x35EA570", Offset = "0x35EA570", VA = "0x35EA570")]
	private static uint FloatToUShort(float x)
	{
		return default(uint);
	}

	[Token(Token = "0x601860E")]
	[Address(RVA = "0x35EA5D0", Offset = "0x35EA5D0", VA = "0x35EA5D0")]
	public static float UShortToFloat(uint value)
	{
		return default(float);
	}

	[Token(Token = "0x601860F")]
	[Address(RVA = "0x35EA5F0", Offset = "0x35EA5F0", VA = "0x35EA5F0")]
	public static uint Convert(ref Vector2 uv)
	{
		return default(uint);
	}

	[Token(Token = "0x6018610")]
	[Address(RVA = "0x35EA698", Offset = "0x35EA698", VA = "0x35EA698")]
	public static void ConvertToVector2(uint value, out Vector2 v)
	{
	}

	[Token(Token = "0x6018611")]
	[Address(RVA = "0x35E2374", Offset = "0x35E2374", VA = "0x35E2374")]
	public static Vector2[] ConvertToUVs(uint[] opvs)
	{
		return null;
	}

	[Token(Token = "0x6018612")]
	[Address(RVA = "0x35E3C4C", Offset = "0x35E3C4C", VA = "0x35E3C4C")]
	public static uint[] ConvertFromUVs(Vector2[] uvs)
	{
		return null;
	}
}
