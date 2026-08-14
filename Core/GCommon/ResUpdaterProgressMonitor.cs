using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040DC")]
public class ResUpdaterProgressMonitor
{
	[Token(Token = "0x401B401")]
	[FieldOffset(Offset = "0x8")]
	private long m_TotalSizeInByte;

	[Token(Token = "0x401B402")]
	[FieldOffset(Offset = "0x10")]
	private long m_TotalLoadedSizeInByte;

	[Token(Token = "0x401B403")]
	[FieldOffset(Offset = "0x18")]
	private long m_TotalLoadingSizeInByte;

	[Token(Token = "0x17001CFB")]
	public long TotalSizeInByte
	{
		[Token(Token = "0x601A6F3")]
		[Address(RVA = "0x32F8718", Offset = "0x32F8718", VA = "0x32F8718")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001CFC")]
	public long TotalLoadedSizeInByte
	{
		[Token(Token = "0x601A6F4")]
		[Address(RVA = "0x32F8750", Offset = "0x32F8750", VA = "0x32F8750")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x601A6F2")]
	[Address(RVA = "0x32FC93C", Offset = "0x32FC93C", VA = "0x32FC93C")]
	public ResUpdaterProgressMonitor()
	{
	}

	[Token(Token = "0x601A6F5")]
	[Address(RVA = "0x32FC944", Offset = "0x32FC944", VA = "0x32FC944")]
	public void Clear()
	{
	}

	[Token(Token = "0x601A6F6")]
	[Address(RVA = "0x32FC960", Offset = "0x32FC960", VA = "0x32FC960")]
	public void AddLoaderInfo(long fileSize)
	{
	}

	[Token(Token = "0x601A6F7")]
	[Address(RVA = "0x32FC97C", Offset = "0x32FC97C", VA = "0x32FC97C")]
	public void OnLoadInProgress(long loadedSize)
	{
	}

	[Token(Token = "0x601A6F8")]
	[Address(RVA = "0x32E5558", Offset = "0x32E5558", VA = "0x32E5558")]
	public void OnLoadFinished(long loadedSize)
	{
	}
}
