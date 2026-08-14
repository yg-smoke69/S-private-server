using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031AD")]
public class DownloadInfo
{
	[Token(Token = "0x4012E4D")]
	[FieldOffset(Offset = "0x8")]
	public ResUpdateDownloadContext DownloadContext;

	[Token(Token = "0x4012E4E")]
	[FieldOffset(Offset = "0xC")]
	public ResVersionInfo.FileInfo DesignatedFileInfo;

	[Token(Token = "0x4012E4F")]
	[FieldOffset(Offset = "0x10")]
	public bool NeedRetry;

	[Token(Token = "0x6014E30")]
	[Address(RVA = "0x1C94634", Offset = "0x1C94634", VA = "0x1C94634")]
	public DownloadInfo()
	{
	}
}
