using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D64")]
public class AkCallbackSerializer : _Attribute
{
	[Token(Token = "0x401A184")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A185")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x6018EB8")]
	[Address(RVA = "0x35CDDA4", Offset = "0x35CDDA4", VA = "0x35CDDA4")]
	internal AkCallbackSerializer(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018EB9")]
	[Address(RVA = "0x35CDDCC", Offset = "0x35CDDCC", VA = "0x35CDDCC")]
	public AkCallbackSerializer()
	{
	}

	[Token(Token = "0x6018EBA")]
	[Address(RVA = "0x35CDE68", Offset = "0x35CDE68", VA = "0x35CDE68")]
	internal static IntPtr getCPtr(AkCallbackSerializer obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018EBB")]
	[Address(RVA = "0x35CDEC0", Offset = "0x35CDEC0", VA = "0x35CDEC0", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018EBC")]
	[Address(RVA = "0x35CDEEC", Offset = "0x35CDEEC", VA = "0x35CDEEC", Slot = "1")]
	~AkCallbackSerializer()
	{
	}

	[Token(Token = "0x6018EBD")]
	[Address(RVA = "0x35CDF60", Offset = "0x35CDF60", VA = "0x35CDF60", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6018EBE")]
	[Address(RVA = "0x35CAD58", Offset = "0x35CAD58", VA = "0x35CAD58")]
	public static AKRESULT Init(IntPtr in_pMemory, uint in_uSize)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018EBF")]
	[Address(RVA = "0x35CAF20", Offset = "0x35CAF20", VA = "0x35CAF20")]
	public static void Term()
	{
	}

	[Token(Token = "0x6018EC0")]
	[Address(RVA = "0x35CC614", Offset = "0x35CC614", VA = "0x35CC614")]
	public static IntPtr Lock()
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018EC1")]
	[Address(RVA = "0x35CB040", Offset = "0x35CB040", VA = "0x35CB040")]
	public static void SetLocalOutput(uint in_uErrorLevel)
	{
	}

	[Token(Token = "0x6018EC2")]
	[Address(RVA = "0x35CD0AC", Offset = "0x35CD0AC", VA = "0x35CD0AC")]
	public static void Unlock()
	{
	}

	[Token(Token = "0x6018EC3")]
	[Address(RVA = "0x35CE08C", Offset = "0x35CE08C", VA = "0x35CE08C")]
	public static AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie)
	{
		return default(AKRESULT);
	}
}
