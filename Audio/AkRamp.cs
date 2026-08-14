using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D9F")]
public class AkRamp : _Attribute
{
	[Token(Token = "0x401A30B")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A30C")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001AE9")]
	public float fPrev
	{
		[Token(Token = "0x6019149")]
		[Address(RVA = "0x36C4D80", Offset = "0x36C4D80", VA = "0x36C4D80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019148")]
		[Address(RVA = "0x36C4CF0", Offset = "0x36C4CF0", VA = "0x36C4CF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001AEA")]
	public float fNext
	{
		[Token(Token = "0x601914B")]
		[Address(RVA = "0x36C4E98", Offset = "0x36C4E98", VA = "0x36C4E98")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601914A")]
		[Address(RVA = "0x36C4E08", Offset = "0x36C4E08", VA = "0x36C4E08")]
		set
		{
		}
	}

	[Token(Token = "0x6019141")]
	[Address(RVA = "0x36C495C", Offset = "0x36C495C", VA = "0x36C495C")]
	internal AkRamp(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6019142")]
	[Address(RVA = "0x36C4984", Offset = "0x36C4984", VA = "0x36C4984")]
	public AkRamp()
	{
	}

	[Token(Token = "0x6019143")]
	[Address(RVA = "0x36C4A20", Offset = "0x36C4A20", VA = "0x36C4A20")]
	public AkRamp(float in_fPrev, float in_fNext)
	{
	}

	[Token(Token = "0x6019144")]
	[Address(RVA = "0x36C4ACC", Offset = "0x36C4ACC", VA = "0x36C4ACC")]
	internal static IntPtr getCPtr(AkRamp obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6019145")]
	[Address(RVA = "0x36C4B24", Offset = "0x36C4B24", VA = "0x36C4B24", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6019146")]
	[Address(RVA = "0x36C4B50", Offset = "0x36C4B50", VA = "0x36C4B50", Slot = "1")]
	~AkRamp()
	{
	}

	[Token(Token = "0x6019147")]
	[Address(RVA = "0x36C4BC4", Offset = "0x36C4BC4", VA = "0x36C4BC4", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
