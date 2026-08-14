using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CEE")]
public static class OptimizedVector
{
	[Token(Token = "0x6018613")]
	[Address(RVA = "0x2D4F894", Offset = "0x2D4F894", VA = "0x2D4F894")]
	private static int FloatToByte(float x)
	{
		return default(int);
	}

	[Token(Token = "0x6018614")]
	[Address(RVA = "0x2D4F9B8", Offset = "0x2D4F9B8", VA = "0x2D4F9B8")]
	private static float ByteToFloat(uint x)
	{
		return default(float);
	}

	[Token(Token = "0x6018615")]
	[Address(RVA = "0x2D4F9D8", Offset = "0x2D4F9D8", VA = "0x2D4F9D8")]
	public static uint ConvertToUInt(ref Vector3 normal)
	{
		return default(uint);
	}

	[Token(Token = "0x6018616")]
	[Address(RVA = "0x2D4FACC", Offset = "0x2D4FACC", VA = "0x2D4FACC")]
	public static uint ConvertToUInt(ref Vector4 normal)
	{
		return default(uint);
	}

	[Token(Token = "0x6018617")]
	[Address(RVA = "0x2D4FBD4", Offset = "0x2D4FBD4", VA = "0x2D4FBD4")]
	public static void ConvertToVector4(uint data, out Vector4 res)
	{
	}

	[Token(Token = "0x6018618")]
	[Address(RVA = "0x2D4FD44", Offset = "0x2D4FD44", VA = "0x2D4FD44")]
	public static void ConvertToVector3(uint data, out Vector3 res)
	{
	}

	[Token(Token = "0x6018619")]
	[Address(RVA = "0x2D4FE88", Offset = "0x2D4FE88", VA = "0x2D4FE88")]
	public static Vector3[] ConvertToVector3s(uint[] ops)
	{
		return null;
	}

	[Token(Token = "0x601861A")]
	[Address(RVA = "0x2D4FFD4", Offset = "0x2D4FFD4", VA = "0x2D4FFD4")]
	public static Vector4[] ConvertToVector4s(uint[] ops)
	{
		return null;
	}

	[Token(Token = "0x601861B")]
	[Address(RVA = "0x2D50124", Offset = "0x2D50124", VA = "0x2D50124")]
	public static uint[] ConvertFromVector4sToUInts(Vector4[] vs)
	{
		return null;
	}

	[Token(Token = "0x601861C")]
	[Address(RVA = "0x2D50228", Offset = "0x2D50228", VA = "0x2D50228")]
	public static uint[] ConvertFromVector3sToUInts(Vector3[] vs)
	{
		return null;
	}
}
