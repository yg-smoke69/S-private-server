using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040BA")]
public class ResWithTempFileLoader : ResWithTimeoutFileLoader
{
	[Token(Token = "0x401B2FE")]
	[FieldOffset(Offset = "0x30")]
	public string TempPath;

	[Token(Token = "0x401B2FF")]
	[FieldOffset(Offset = "0x34")]
	public string TempFileHash;

	[Token(Token = "0x401B300")]
	[FieldOffset(Offset = "0x38")]
	public string FlagPath;

	[Token(Token = "0x17001CD2")]
	public virtual long CELL_SIZE
	{
		[Token(Token = "0x601A56F")]
		[Address(RVA = "0x3300B20", Offset = "0x3300B20", VA = "0x3300B20", Slot = "16")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001CD3")]
	public string ResFileHash
	{
		[Token(Token = "0x601A570")]
		[Address(RVA = "0x32E77F0", Offset = "0x32E77F0", VA = "0x32E77F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CD4")]
	public ResFileType FileType
	{
		[Token(Token = "0x601A571")]
		[Address(RVA = "0x32E77CC", Offset = "0x32E77CC", VA = "0x32E77CC")]
		get
		{
			return default(ResFileType);
		}
	}

	[Token(Token = "0x601A56E")]
	[Address(RVA = "0x32E8394", Offset = "0x32E8394", VA = "0x32E8394")]
	public ResWithTempFileLoader()
	{
	}
}
