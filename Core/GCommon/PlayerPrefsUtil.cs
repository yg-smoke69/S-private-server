using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003FC0")]
public static class PlayerPrefsUtil
{
	[Token(Token = "0x401AD4E")]
	[FieldOffset(Offset = "0x0")]
	public static string UserKey;

	[Token(Token = "0x401AD4F")]
	public const int SHOWED = 1;

	[Token(Token = "0x401AD50")]
	public const int UNSHOWED = 0;

	[Token(Token = "0x401AD51")]
	[FieldOffset(Offset = "0x4")]
	private static StringBuilder m_KeyStringBuilder;

	[Token(Token = "0x6019F36")]
	[Address(RVA = "0x332296C", Offset = "0x332296C", VA = "0x332296C")]
	public static void DeleteKey(string key, bool global = false)
	{
	}

	[Token(Token = "0x6019F37")]
	[Address(RVA = "0x3322D54", Offset = "0x3322D54", VA = "0x3322D54")]
	public static bool DeleteAll()
	{
		return default(bool);
	}

	[Token(Token = "0x6019F38")]
	[Address(RVA = "0x3322F54", Offset = "0x3322F54", VA = "0x3322F54")]
	public static float GetFloat(string key, float defaultValue = 0f, bool global = false)
	{
		return default(float);
	}

	[Token(Token = "0x6019F39")]
	[Address(RVA = "0x3322FEC", Offset = "0x3322FEC", VA = "0x3322FEC")]
	public static int GetInt(string key, int defaultValue = 0, bool global = false)
	{
		return default(int);
	}

	[Token(Token = "0x6019F3A")]
	[Address(RVA = "0x3323084", Offset = "0x3323084", VA = "0x3323084")]
	public static string GetString(string key, [Optional] string defaultValue, bool global = false)
	{
		return null;
	}

	[Token(Token = "0x6019F3B")]
	[Address(RVA = "0x332311C", Offset = "0x332311C", VA = "0x332311C")]
	public static bool HasKey(string key, bool global = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6019F3C")]
	[Address(RVA = "0x33231AC", Offset = "0x33231AC", VA = "0x33231AC")]
	public static void Save()
	{
	}

	[Token(Token = "0x6019F3D")]
	[Address(RVA = "0x332335C", Offset = "0x332335C", VA = "0x332335C")]
	public static void SetFloat(string key, float value, bool global = false)
	{
	}

	[Token(Token = "0x6019F3E")]
	[Address(RVA = "0x3323558", Offset = "0x3323558", VA = "0x3323558")]
	public static void SetInt(string key, int value, bool global = false)
	{
	}

	[Token(Token = "0x6019F3F")]
	[Address(RVA = "0x3323754", Offset = "0x3323754", VA = "0x3323754")]
	public static void SetGlobalAddedIntKey(string key, int startnum)
	{
	}

	[Token(Token = "0x6019F40")]
	[Address(RVA = "0x332385C", Offset = "0x332385C", VA = "0x332385C")]
	public static void SetString(string key, string value, bool global = false)
	{
	}

	[Token(Token = "0x6019F41")]
	[Address(RVA = "0x3322B60", Offset = "0x3322B60", VA = "0x3322B60")]
	private static string GenKeyWithUserPrefix(string key, bool global)
	{
		return null;
	}
}
