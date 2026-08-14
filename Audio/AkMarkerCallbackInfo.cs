using System;
using Il2CppDummyDll;

[Token(Token = "0x2003D7D")]
public class AkMarkerCallbackInfo : AkEventCallbackInfo
{
	[Token(Token = "0x401A1F0")]
	[FieldOffset(Offset = "0x14")]
	private IntPtr swigCPtr;

	[Token(Token = "0x17001A7F")]
	public uint uIdentifier
	{
		[Token(Token = "0x6018FD8")]
		[Address(RVA = "0x36B866C", Offset = "0x36B866C", VA = "0x36B866C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A80")]
	public uint uPosition
	{
		[Token(Token = "0x6018FD9")]
		[Address(RVA = "0x36B86F4", Offset = "0x36B86F4", VA = "0x36B86F4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A81")]
	public string strLabel
	{
		[Token(Token = "0x6018FDA")]
		[Address(RVA = "0x36B877C", Offset = "0x36B877C", VA = "0x36B877C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6018FD2")]
	[Address(RVA = "0x36B8298", Offset = "0x36B8298", VA = "0x36B8298")]
	internal AkMarkerCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018FD3")]
	[Address(RVA = "0x36B833C", Offset = "0x36B833C", VA = "0x36B833C")]
	public AkMarkerCallbackInfo()
	{
	}

	[Token(Token = "0x6018FD4")]
	[Address(RVA = "0x36B83CC", Offset = "0x36B83CC", VA = "0x36B83CC")]
	internal static IntPtr getCPtr(AkMarkerCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018FD5")]
	[Address(RVA = "0x36B8424", Offset = "0x36B8424", VA = "0x36B8424", Slot = "5")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018FD6")]
	[Address(RVA = "0x36B84C0", Offset = "0x36B84C0", VA = "0x36B84C0", Slot = "1")]
	~AkMarkerCallbackInfo()
	{
	}

	[Token(Token = "0x6018FD7")]
	[Address(RVA = "0x36B8534", Offset = "0x36B8534", VA = "0x36B8534", Slot = "6")]
	public override void Dispose()
	{
	}
}
