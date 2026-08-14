using System.Text;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004117")]
public class QString
{
	[Token(Token = "0x401B579")]
	[FieldOffset(Offset = "0x0")]
	private static StringBuilder stringBuilder;

	[Token(Token = "0x401B57A")]
	[FieldOffset(Offset = "0x4")]
	private static StringBuilder shareStringBuilder;

	[Token(Token = "0x601A94D")]
	[Address(RVA = "0x33255E8", Offset = "0x33255E8", VA = "0x33255E8")]
	public QString()
	{
	}

	[Token(Token = "0x601A94E")]
	[Address(RVA = "0x33255F0", Offset = "0x33255F0", VA = "0x33255F0")]
	public static StringBuilder GetShareStringBuilder()
	{
		return null;
	}

	[Token(Token = "0x601A94F")]
	[Address(RVA = "0x33256DC", Offset = "0x33256DC", VA = "0x33256DC")]
	public static string Format(string src, object[] args)
	{
		return null;
	}

	[Token(Token = "0x601A950")]
	[Address(RVA = "0x3325838", Offset = "0x3325838", VA = "0x3325838")]
	public static string Concat(string s1, string s2)
	{
		return null;
	}

	[Token(Token = "0x601A951")]
	[Address(RVA = "0x33259C8", Offset = "0x33259C8", VA = "0x33259C8")]
	public static string Concat(string s1, string s2, string s3)
	{
		return null;
	}

	[Token(Token = "0x601A952")]
	[Address(RVA = "0x3325B94", Offset = "0x3325B94", VA = "0x3325B94")]
	public static string Concat(string s1, string s2, string s3, string s4)
	{
		return null;
	}
}
