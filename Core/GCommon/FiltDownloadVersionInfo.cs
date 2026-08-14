using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040B0")]
public class FiltDownloadVersionInfo : DownloadVersionInfo
{
	[Token(Token = "0x401B2D2")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<string, ResVersionInfo.FileInfo> m_NoFiltFileInfos;

	[Token(Token = "0x601A532")]
	[Address(RVA = "0x32ABB48", Offset = "0x32ABB48", VA = "0x32ABB48")]
	public FiltDownloadVersionInfo(bool isRemote, ResDownloadType download_type)
	{
	}

	[Token(Token = "0x601A533")]
	[Address(RVA = "0x32ABBF4", Offset = "0x32ABBF4", VA = "0x32ABBF4", Slot = "4")]
	protected override bool ParseFile(string content, bool from_local = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A534")]
	[Address(RVA = "0x32AD49C", Offset = "0x32AD49C", VA = "0x32AD49C", Slot = "6")]
	public override ResErrorCode SaveFileInfo(ResUpdateDownloadContext context)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A535")]
	[Address(RVA = "0x32AE4B0", Offset = "0x32AE4B0", VA = "0x32AE4B0", Slot = "5")]
	public override void ClearFileInfoList()
	{
	}

	[Token(Token = "0x601A536")]
	[Address(RVA = "0x32AE9F4", Offset = "0x32AE9F4", VA = "0x32AE9F4")]
	public Dictionary<string, ResVersionInfo.FileInfo> GetNoFiltInfoList()
	{
		return null;
	}

	[Token(Token = "0x601A537")]
	[Address(RVA = "0x32AE9FC", Offset = "0x32AE9FC", VA = "0x32AE9FC")]
	public void AddPrefiltFileInfo(ResVersionInfo.FileInfo fileInfo)
	{
	}

	[Token(Token = "0x601A538")]
	[Address(RVA = "0x32AC668", Offset = "0x32AC668", VA = "0x32AC668")]
	private string[] FiltFifleInfo(string content)
	{
		return null;
	}

	[Token(Token = "0x601A539")]
	[Address(RVA = "0x32AC99C", Offset = "0x32AC99C", VA = "0x32AC99C")]
	private void GeneratePreFiltFileInfo(string content, bool from_local = false)
	{
	}
}
