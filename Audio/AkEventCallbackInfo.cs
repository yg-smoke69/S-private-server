using System;
using Il2CppDummyDll;

[Token(Token = "0x2003D73")]
public class AkEventCallbackInfo : AkCallbackInfo
{
	[Token(Token = "0x401A1CC")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr swigCPtr;

	[Token(Token = "0x17001A54")]
	public uint playingID
	{
		[Token(Token = "0x6018F4B")]
		[Address(RVA = "0x35C2E9C", Offset = "0x35C2E9C", VA = "0x35C2E9C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A55")]
	public uint eventID
	{
		[Token(Token = "0x6018F4C")]
		[Address(RVA = "0x35D64D8", Offset = "0x35D64D8", VA = "0x35D64D8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6018F45")]
	[Address(RVA = "0x35CD3FC", Offset = "0x35CD3FC", VA = "0x35CD3FC")]
	internal AkEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018F46")]
	[Address(RVA = "0x35D63F0", Offset = "0x35D63F0", VA = "0x35D63F0")]
	public AkEventCallbackInfo()
	{
	}

	[Token(Token = "0x6018F47")]
	[Address(RVA = "0x35D6480", Offset = "0x35D6480", VA = "0x35D6480")]
	internal static IntPtr getCPtr(AkEventCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018F48")]
	[Address(RVA = "0x35D366C", Offset = "0x35D366C", VA = "0x35D366C", Slot = "5")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018F49")]
	[Address(RVA = "0x35D3780", Offset = "0x35D3780", VA = "0x35D3780", Slot = "1")]
	~AkEventCallbackInfo()
	{
	}

	[Token(Token = "0x6018F4A")]
	[Address(RVA = "0x35D3920", Offset = "0x35D3920", VA = "0x35D3920", Slot = "6")]
	public override void Dispose()
	{
	}
}
