using System;
using Il2CppDummyDll;

[Token(Token = "0x2003D98")]
public class AkPlaylist : AkPlaylistArray
{
	[Token(Token = "0x401A2F1")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr swigCPtr;

	[Token(Token = "0x60190DB")]
	[Address(RVA = "0x36BF71C", Offset = "0x36BF71C", VA = "0x36BF71C")]
	internal AkPlaylist(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60190DC")]
	[Address(RVA = "0x36BF7EC", Offset = "0x36BF7EC", VA = "0x36BF7EC")]
	public AkPlaylist()
	{
	}

	[Token(Token = "0x60190DD")]
	[Address(RVA = "0x36BF87C", Offset = "0x36BF87C", VA = "0x36BF87C")]
	internal static IntPtr getCPtr(AkPlaylist obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60190DE")]
	[Address(RVA = "0x36BF8D4", Offset = "0x36BF8D4", VA = "0x36BF8D4", Slot = "5")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60190DF")]
	[Address(RVA = "0x36BF9A8", Offset = "0x36BF9A8", VA = "0x36BF9A8", Slot = "1")]
	~AkPlaylist()
	{
	}

	[Token(Token = "0x60190E0")]
	[Address(RVA = "0x36BFA88", Offset = "0x36BFA88", VA = "0x36BFA88", Slot = "6")]
	public override void Dispose()
	{
	}

	[Token(Token = "0x60190E1")]
	[Address(RVA = "0x36BFCE8", Offset = "0x36BFCE8", VA = "0x36BFCE8")]
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60190E2")]
	[Address(RVA = "0x36BFDD0", Offset = "0x36BFDD0", VA = "0x36BFDD0")]
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60190E3")]
	[Address(RVA = "0x36BFE84", Offset = "0x36BFE84", VA = "0x36BFE84")]
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60190E4")]
	[Address(RVA = "0x36BFF30", Offset = "0x36BFF30", VA = "0x36BFF30")]
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60190E5")]
	[Address(RVA = "0x36BFFC8", Offset = "0x36BFFC8", VA = "0x36BFFC8")]
	public AKRESULT Enqueue(uint in_audioNodeID)
	{
		return default(AKRESULT);
	}
}
