using System;
using Il2CppDummyDll;

[Token(Token = "0x2003D70")]
public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo
{
	[Token(Token = "0x401A1C6")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr swigCPtr;

	[Token(Token = "0x17001A47")]
	public uint playingID
	{
		[Token(Token = "0x6018F28")]
		[Address(RVA = "0x35D402C", Offset = "0x35D402C", VA = "0x35D402C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A48")]
	public uint audioNodeID
	{
		[Token(Token = "0x6018F29")]
		[Address(RVA = "0x35D40B4", Offset = "0x35D40B4", VA = "0x35D40B4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A49")]
	public IntPtr pCustomInfo
	{
		[Token(Token = "0x6018F2A")]
		[Address(RVA = "0x35D413C", Offset = "0x35D413C", VA = "0x35D413C")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x6018F22")]
	[Address(RVA = "0x35CD4A4", Offset = "0x35CD4A4", VA = "0x35CD4A4")]
	internal AkDynamicSequenceItemCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018F23")]
	[Address(RVA = "0x35D3CFC", Offset = "0x35D3CFC", VA = "0x35D3CFC")]
	public AkDynamicSequenceItemCallbackInfo()
	{
	}

	[Token(Token = "0x6018F24")]
	[Address(RVA = "0x35D3D8C", Offset = "0x35D3D8C", VA = "0x35D3D8C")]
	internal static IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018F25")]
	[Address(RVA = "0x35D3DE4", Offset = "0x35D3DE4", VA = "0x35D3DE4", Slot = "5")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018F26")]
	[Address(RVA = "0x35D3E8C", Offset = "0x35D3E8C", VA = "0x35D3E8C", Slot = "1")]
	~AkDynamicSequenceItemCallbackInfo()
	{
	}

	[Token(Token = "0x6018F27")]
	[Address(RVA = "0x35D3EF8", Offset = "0x35D3EF8", VA = "0x35D3EF8", Slot = "6")]
	public override void Dispose()
	{
	}
}
