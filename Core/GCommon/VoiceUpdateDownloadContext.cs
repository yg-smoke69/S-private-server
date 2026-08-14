using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040D7")]
public class VoiceUpdateDownloadContext : ResUpdateDownloadContext
{
	[Token(Token = "0x601A6B9")]
	[Address(RVA = "0x2BD95E4", Offset = "0x2BD95E4", VA = "0x2BD95E4")]
	public VoiceUpdateDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously)
	{
	}

	[Token(Token = "0x601A6BA")]
	[Address(RVA = "0x2BD9604", Offset = "0x2BD9604", VA = "0x2BD9604", Slot = "10")]
	public override void StartGetLocalVersion([Optional] Action<ResDownloadType> on_version_check_finished)
	{
	}

	[Token(Token = "0x601A6BB")]
	[Address(RVA = "0x2BD978C", Offset = "0x2BD978C", VA = "0x2BD978C", Slot = "9")]
	public override void DeleteAllFile()
	{
	}

	[Token(Token = "0x601A6BC")]
	[Address(RVA = "0x2BD9874", Offset = "0x2BD9874", VA = "0x2BD9874", Slot = "11")]
	public override void StartVersionCheck()
	{
	}

	[Token(Token = "0x601A6BD")]
	[Address(RVA = "0x2BD9CBC", Offset = "0x2BD9CBC", VA = "0x2BD9CBC", Slot = "12")]
	protected override void onRemoteVersionInfoLoaded(bool result)
	{
	}

	[Token(Token = "0x601A6BE")]
	[Address(RVA = "0x2BD9F48", Offset = "0x2BD9F48", VA = "0x2BD9F48")]
	private void onLocalFileInfoLoaded_Pass(bool result)
	{
	}

	[Token(Token = "0x601A6BF")]
	[Address(RVA = "0x2BDA050", Offset = "0x2BDA050", VA = "0x2BDA050", Slot = "13")]
	protected override void onRemoteFileInfoLoaded(bool result)
	{
	}
}
