using System;
using Il2CppDummyDll;

[Token(Token = "0x2003D6F")]
public class AkDurationCallbackInfo : AkEventCallbackInfo
{
	[Token(Token = "0x401A1C5")]
	[FieldOffset(Offset = "0x14")]
	private IntPtr swigCPtr;

	[Token(Token = "0x17001A42")]
	public float fDuration
	{
		[Token(Token = "0x6018F1D")]
		[Address(RVA = "0x35D3A54", Offset = "0x35D3A54", VA = "0x35D3A54")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A43")]
	public float fEstimatedDuration
	{
		[Token(Token = "0x6018F1E")]
		[Address(RVA = "0x35D3ADC", Offset = "0x35D3ADC", VA = "0x35D3ADC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A44")]
	public uint audioNodeID
	{
		[Token(Token = "0x6018F1F")]
		[Address(RVA = "0x35D3B64", Offset = "0x35D3B64", VA = "0x35D3B64")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A45")]
	public uint mediaID
	{
		[Token(Token = "0x6018F20")]
		[Address(RVA = "0x35D3BEC", Offset = "0x35D3BEC", VA = "0x35D3BEC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A46")]
	public bool bStreaming
	{
		[Token(Token = "0x6018F21")]
		[Address(RVA = "0x35D3C74", Offset = "0x35D3C74", VA = "0x35D3C74")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6018F17")]
	[Address(RVA = "0x35CD54C", Offset = "0x35CD54C", VA = "0x35CD54C")]
	internal AkDurationCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018F18")]
	[Address(RVA = "0x35D34EC", Offset = "0x35D34EC", VA = "0x35D34EC")]
	public AkDurationCallbackInfo()
	{
	}

	[Token(Token = "0x6018F19")]
	[Address(RVA = "0x35D357C", Offset = "0x35D357C", VA = "0x35D357C")]
	internal static IntPtr getCPtr(AkDurationCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018F1A")]
	[Address(RVA = "0x35D35D4", Offset = "0x35D35D4", VA = "0x35D35D4", Slot = "5")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018F1B")]
	[Address(RVA = "0x35D3714", Offset = "0x35D3714", VA = "0x35D3714", Slot = "1")]
	~AkDurationCallbackInfo()
	{
	}

	[Token(Token = "0x6018F1C")]
	[Address(RVA = "0x35D37EC", Offset = "0x35D37EC", VA = "0x35D37EC", Slot = "6")]
	public override void Dispose()
	{
	}
}
