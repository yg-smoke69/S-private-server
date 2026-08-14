using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CFC")]
public static class UMAUtils
{
	[Token(Token = "0x4019E4B")]
	public const string SKIN_COLOR_NAME = "Skin";

	[Token(Token = "0x4019E4C")]
	public const int SKIN_COLOR_INDEX = 1;

	[Token(Token = "0x4019E4D")]
	public const int NONE_COLOR_INDEX = 0;

	[Token(Token = "0x60186C4")]
	[Address(RVA = "0x35E9BB4", Offset = "0x35E9BB4", VA = "0x35E9BB4")]
	public static Transform FindMyChild(Transform parentTF, string childName)
	{
		return null;
	}

	[Token(Token = "0x60186C5")]
	[Address(RVA = "0x35E9D20", Offset = "0x35E9D20", VA = "0x35E9D20")]
	public static Transform FindChildExpend(Transform parentTF, string childName)
	{
		return null;
	}

	[Token(Token = "0x60186C6")]
	[Address(RVA = "0x35E9E8C", Offset = "0x35E9E8C", VA = "0x35E9E8C")]
	public static Transform FindChildCompomentExpend(Transform parentTF, string childName)
	{
		return null;
	}

	[Token(Token = "0x60186C7")]
	[Address(RVA = "0x35E0020", Offset = "0x35E0020", VA = "0x35E0020")]
	public static int StringToHash(string name)
	{
		return default(int);
	}

	[Token(Token = "0x60186C8")]
	[Address(RVA = "0x35E9F74", Offset = "0x35E9F74", VA = "0x35E9F74")]
	public static float GaussianRandom(float mean, float dev)
	{
		return default(float);
	}

	[Token(Token = "0x60186C9")]
	[Address(RVA = "0x35EA074", Offset = "0x35EA074", VA = "0x35EA074")]
	public static int Count1(int n)
	{
		return default(int);
	}

	[Token(Token = "0x60186CA")]
	[Address(RVA = "0x35EA098", Offset = "0x35EA098", VA = "0x35EA098")]
	public static OverlayColorData[] CreateDefaultColors()
	{
		return null;
	}

	[Token(Token = "0x60186CB")]
	[Address(RVA = "0x35EA214", Offset = "0x35EA214", VA = "0x35EA214")]
	public static OverlayColorData CreateDefaultColor(string name)
	{
		return null;
	}

	[Token(Token = "0x60186CC")]
	[Address(RVA = "0x35EA450", Offset = "0x35EA450", VA = "0x35EA450")]
	public static OverlayColorData GetColor(string name, OverlayColorData[] colors)
	{
		return null;
	}
}
