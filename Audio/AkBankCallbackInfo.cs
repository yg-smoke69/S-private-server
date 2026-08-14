using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D60")]
public class AkBankCallbackInfo : _Attribute
{
	[Token(Token = "0x401A179")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A17A")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A27")]
	public uint bankID
	{
		[Token(Token = "0x6018EAC")]
		[Address(RVA = "0x35C71C8", Offset = "0x35C71C8", VA = "0x35C71C8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A28")]
	public IntPtr inMemoryBankPtr
	{
		[Token(Token = "0x6018EAD")]
		[Address(RVA = "0x35C7250", Offset = "0x35C7250", VA = "0x35C7250")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17001A29")]
	public AKRESULT loadResult
	{
		[Token(Token = "0x6018EAE")]
		[Address(RVA = "0x35C72D8", Offset = "0x35C72D8", VA = "0x35C72D8")]
		get
		{
			return default(AKRESULT);
		}
	}

	[Token(Token = "0x17001A2A")]
	public int memPoolId
	{
		[Token(Token = "0x6018EAF")]
		[Address(RVA = "0x35C7360", Offset = "0x35C7360", VA = "0x35C7360")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6018EA6")]
	[Address(RVA = "0x35C6EE0", Offset = "0x35C6EE0", VA = "0x35C6EE0")]
	internal AkBankCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018EA7")]
	[Address(RVA = "0x35C6F08", Offset = "0x35C6F08", VA = "0x35C6F08")]
	public AkBankCallbackInfo()
	{
	}

	[Token(Token = "0x6018EA8")]
	[Address(RVA = "0x35C6FA4", Offset = "0x35C6FA4", VA = "0x35C6FA4")]
	internal static IntPtr getCPtr(AkBankCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018EA9")]
	[Address(RVA = "0x35C6FFC", Offset = "0x35C6FFC", VA = "0x35C6FFC", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018EAA")]
	[Address(RVA = "0x35C7028", Offset = "0x35C7028", VA = "0x35C7028", Slot = "1")]
	~AkBankCallbackInfo()
	{
	}

	[Token(Token = "0x6018EAB")]
	[Address(RVA = "0x35C709C", Offset = "0x35C709C", VA = "0x35C709C", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
