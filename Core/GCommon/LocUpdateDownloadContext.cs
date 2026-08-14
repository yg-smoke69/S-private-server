using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GCommon;

[Token(Token = "0x20040D8")]
public class LocUpdateDownloadContext : ResUpdateDownloadContext
{
	[Token(Token = "0x17001CF5")]
	public override bool SupportBackgroundDownload
	{
		[Token(Token = "0x601A6C1")]
		[Address(RVA = "0x29617E0", Offset = "0x29617E0", VA = "0x29617E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601A6C0")]
	[Address(RVA = "0x29617C0", Offset = "0x29617C0", VA = "0x29617C0")]
	public LocUpdateDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously)
	{
	}

	[Token(Token = "0x601A6C2")]
	[Address(RVA = "0x29617E8", Offset = "0x29617E8", VA = "0x29617E8")]
	public bool CheckCurLocFile(LocLang target_lang, string config_path, bool use_assets)
	{
		return default(bool);
	}

	[Token(Token = "0x601A6C3")]
	[Address(RVA = "0x2961EEC", Offset = "0x2961EEC", VA = "0x2961EEC", Slot = "14")]
	public override float GetFileDownloadProcess()
	{
		return default(float);
	}

	[Token(Token = "0x601A6C4")]
	[Address(RVA = "0x2961F54", Offset = "0x2961F54", VA = "0x2961F54")]
	private void _003CCheckCurLocFile_003Em__0(UnityWebRequest www, ResWithTempFileLoader loader)
	{
	}

	[Token(Token = "0x601A6C5")]
	[Address(RVA = "0x2962768", Offset = "0x2962768", VA = "0x2962768")]
	private void _003CCheckCurLocFile_003Em__1(string hashCode, ResUnzipFileLoader unzip_loader)
	{
	}
}
