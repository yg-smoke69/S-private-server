using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D9A")]
public class AkPlaylistItem : _Attribute
{
	[Token(Token = "0x401A2F4")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A2F5")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001AD4")]
	public uint audioNodeID
	{
		[Token(Token = "0x6019112")]
		[Address(RVA = "0x36C1C18", Offset = "0x36C1C18", VA = "0x36C1C18")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6019111")]
		[Address(RVA = "0x36C1B88", Offset = "0x36C1B88", VA = "0x36C1B88")]
		set
		{
		}
	}

	[Token(Token = "0x17001AD5")]
	public int msDelay
	{
		[Token(Token = "0x6019114")]
		[Address(RVA = "0x36C1D30", Offset = "0x36C1D30", VA = "0x36C1D30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6019113")]
		[Address(RVA = "0x36C1CA0", Offset = "0x36C1CA0", VA = "0x36C1CA0")]
		set
		{
		}
	}

	[Token(Token = "0x17001AD6")]
	public IntPtr pCustomInfo
	{
		[Token(Token = "0x6019116")]
		[Address(RVA = "0x36C1E48", Offset = "0x36C1E48", VA = "0x36C1E48")]
		get
		{
			return default(IntPtr);
		}
		[Token(Token = "0x6019115")]
		[Address(RVA = "0x36C1DB8", Offset = "0x36C1DB8", VA = "0x36C1DB8")]
		set
		{
		}
	}

	[Token(Token = "0x6019107")]
	[Address(RVA = "0x36B1A24", Offset = "0x36B1A24", VA = "0x36B1A24")]
	internal AkPlaylistItem(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6019108")]
	[Address(RVA = "0x36C158C", Offset = "0x36C158C", VA = "0x36C158C")]
	public AkPlaylistItem()
	{
	}

	[Token(Token = "0x6019109")]
	[Address(RVA = "0x36C1628", Offset = "0x36C1628", VA = "0x36C1628")]
	public AkPlaylistItem(AkPlaylistItem in_rCopy)
	{
	}

	[Token(Token = "0x601910A")]
	[Address(RVA = "0x36B18F8", Offset = "0x36B18F8", VA = "0x36B18F8")]
	internal static IntPtr getCPtr(AkPlaylistItem obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x601910B")]
	[Address(RVA = "0x36C1714", Offset = "0x36C1714", VA = "0x36C1714", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x601910C")]
	[Address(RVA = "0x36C1740", Offset = "0x36C1740", VA = "0x36C1740", Slot = "1")]
	~AkPlaylistItem()
	{
	}

	[Token(Token = "0x601910D")]
	[Address(RVA = "0x36C17B4", Offset = "0x36C17B4", VA = "0x36C17B4", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x601910E")]
	[Address(RVA = "0x36C18E0", Offset = "0x36C18E0", VA = "0x36C18E0")]
	public AkPlaylistItem Assign(AkPlaylistItem in_rCopy)
	{
		return null;
	}

	[Token(Token = "0x601910F")]
	[Address(RVA = "0x36C19EC", Offset = "0x36C19EC", VA = "0x36C19EC")]
	public bool IsEqualTo(AkPlaylistItem in_rCopy)
	{
		return default(bool);
	}

	[Token(Token = "0x6019110")]
	[Address(RVA = "0x36C1AC4", Offset = "0x36C1AC4", VA = "0x36C1AC4")]
	public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc)
	{
		return default(AKRESULT);
	}
}
