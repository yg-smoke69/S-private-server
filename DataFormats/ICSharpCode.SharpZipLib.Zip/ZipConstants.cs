using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C04")]
public sealed class ZipConstants
{
	[Token(Token = "0x401998A")]
	public const int VersionMadeBy = 51;

	[Token(Token = "0x401998B")]
	public const int VERSION_MADE_BY = 51;

	[Token(Token = "0x401998C")]
	public const int VersionStrongEncryption = 50;

	[Token(Token = "0x401998D")]
	public const int VERSION_STRONG_ENCRYPTION = 50;

	[Token(Token = "0x401998E")]
	public const int VERSION_AES = 51;

	[Token(Token = "0x401998F")]
	public const int VersionZip64 = 45;

	[Token(Token = "0x4019990")]
	public const int LocalHeaderBaseSize = 30;

	[Token(Token = "0x4019991")]
	public const int LOCHDR = 30;

	[Token(Token = "0x4019992")]
	public const int Zip64DataDescriptorSize = 24;

	[Token(Token = "0x4019993")]
	public const int DataDescriptorSize = 16;

	[Token(Token = "0x4019994")]
	public const int EXTHDR = 16;

	[Token(Token = "0x4019995")]
	public const int CentralHeaderBaseSize = 46;

	[Token(Token = "0x4019996")]
	public const int CENHDR = 46;

	[Token(Token = "0x4019997")]
	public const int EndOfCentralRecordBaseSize = 22;

	[Token(Token = "0x4019998")]
	public const int ENDHDR = 22;

	[Token(Token = "0x4019999")]
	public const int CryptoHeaderSize = 12;

	[Token(Token = "0x401999A")]
	public const int CRYPTO_HEADER_SIZE = 12;

	[Token(Token = "0x401999B")]
	public const int LocalHeaderSignature = 67324752;

	[Token(Token = "0x401999C")]
	public const int LOCSIG = 67324752;

	[Token(Token = "0x401999D")]
	public const int SpanningSignature = 134695760;

	[Token(Token = "0x401999E")]
	public const int SPANNINGSIG = 134695760;

	[Token(Token = "0x401999F")]
	public const int SpanningTempSignature = 808471376;

	[Token(Token = "0x40199A0")]
	public const int SPANTEMPSIG = 808471376;

	[Token(Token = "0x40199A1")]
	public const int DataDescriptorSignature = 134695760;

	[Token(Token = "0x40199A2")]
	public const int EXTSIG = 134695760;

	[Token(Token = "0x40199A3")]
	public const int CENSIG = 33639248;

	[Token(Token = "0x40199A4")]
	public const int CentralHeaderSignature = 33639248;

	[Token(Token = "0x40199A5")]
	public const int Zip64CentralFileHeaderSignature = 101075792;

	[Token(Token = "0x40199A6")]
	public const int CENSIG64 = 101075792;

	[Token(Token = "0x40199A7")]
	public const int Zip64CentralDirLocatorSignature = 117853008;

	[Token(Token = "0x40199A8")]
	public const int ArchiveExtraDataSignature = 117853008;

	[Token(Token = "0x40199A9")]
	public const int CentralHeaderDigitalSignature = 84233040;

	[Token(Token = "0x40199AA")]
	public const int CENDIGITALSIG = 84233040;

	[Token(Token = "0x40199AB")]
	public const int EndOfCentralDirectorySignature = 101010256;

	[Token(Token = "0x40199AC")]
	public const int ENDSIG = 101010256;

	[Token(Token = "0x40199AD")]
	[FieldOffset(Offset = "0x0")]
	private static int defaultCodePage;

	[Token(Token = "0x17001939")]
	public static int DefaultCodePage
	{
		[Token(Token = "0x6017F45")]
		[Address(RVA = "0xA28F90", Offset = "0xA28F90", VA = "0xA28F90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6017F46")]
		[Address(RVA = "0xA2901C", Offset = "0xA2901C", VA = "0xA2901C")]
		set
		{
		}
	}

	[Token(Token = "0x6017F44")]
	[Address(RVA = "0xA28F88", Offset = "0xA28F88", VA = "0xA28F88")]
	private ZipConstants()
	{
	}

	[Token(Token = "0x6017F47")]
	[Address(RVA = "0xA290AC", Offset = "0xA290AC", VA = "0xA290AC")]
	public static string ConvertToString(byte[] data, int count)
	{
		return null;
	}

	[Token(Token = "0x6017F48")]
	[Address(RVA = "0xA291FC", Offset = "0xA291FC", VA = "0xA291FC")]
	public static string ConvertToString(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6017F49")]
	[Address(RVA = "0xA292D0", Offset = "0xA292D0", VA = "0xA292D0")]
	public static string ConvertToStringExt(int flags, byte[] data, int count)
	{
		return null;
	}

	[Token(Token = "0x6017F4A")]
	[Address(RVA = "0xA29434", Offset = "0xA29434", VA = "0xA29434")]
	public static string ConvertToStringExt(int flags, byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6017F4B")]
	[Address(RVA = "0xA23E8C", Offset = "0xA23E8C", VA = "0xA23E8C")]
	public static byte[] ConvertToArray(string str)
	{
		return null;
	}

	[Token(Token = "0x6017F4C")]
	[Address(RVA = "0xA29594", Offset = "0xA29594", VA = "0xA29594")]
	public static byte[] ConvertToArray(int flags, string str)
	{
		return null;
	}
}
