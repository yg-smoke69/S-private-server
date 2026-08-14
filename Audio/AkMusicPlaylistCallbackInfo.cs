using System;
using Il2CppDummyDll;

[Token(Token = "0x2003D90")]
public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo
{
	[Token(Token = "0x401A2E2")]
	[FieldOffset(Offset = "0x14")]
	private IntPtr swigCPtr;

	[Token(Token = "0x17001AB7")]
	public uint playlistID
	{
		[Token(Token = "0x6019083")]
		[Address(RVA = "0x36BA478", Offset = "0x36BA478", VA = "0x36BA478")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001AB8")]
	public uint uNumPlaylistItems
	{
		[Token(Token = "0x6019084")]
		[Address(RVA = "0x36BA500", Offset = "0x36BA500", VA = "0x36BA500")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001AB9")]
	public uint uPlaylistSelection
	{
		[Token(Token = "0x6019085")]
		[Address(RVA = "0x36BA588", Offset = "0x36BA588", VA = "0x36BA588")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001ABA")]
	public uint uPlaylistItemDone
	{
		[Token(Token = "0x6019086")]
		[Address(RVA = "0x36BA610", Offset = "0x36BA610", VA = "0x36BA610")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x601907D")]
	[Address(RVA = "0x36BA0A4", Offset = "0x36BA0A4", VA = "0x36BA0A4")]
	internal AkMusicPlaylistCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x601907E")]
	[Address(RVA = "0x36BA148", Offset = "0x36BA148", VA = "0x36BA148")]
	public AkMusicPlaylistCallbackInfo()
	{
	}

	[Token(Token = "0x601907F")]
	[Address(RVA = "0x36BA1D8", Offset = "0x36BA1D8", VA = "0x36BA1D8")]
	internal static IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6019080")]
	[Address(RVA = "0x36BA230", Offset = "0x36BA230", VA = "0x36BA230", Slot = "5")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6019081")]
	[Address(RVA = "0x36BA2CC", Offset = "0x36BA2CC", VA = "0x36BA2CC", Slot = "1")]
	~AkMusicPlaylistCallbackInfo()
	{
	}

	[Token(Token = "0x6019082")]
	[Address(RVA = "0x36BA340", Offset = "0x36BA340", VA = "0x36BA340", Slot = "6")]
	public override void Dispose()
	{
	}
}
