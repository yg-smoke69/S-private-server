using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D74")]
public class AkExternalSourceInfo : _Attribute
{
	[Token(Token = "0x401A1CD")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1CE")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A56")]
	public uint iExternalSrcCookie
	{
		[Token(Token = "0x6018F5A")]
		[Address(RVA = "0x35D8A04", Offset = "0x35D8A04", VA = "0x35D8A04")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F59")]
		[Address(RVA = "0x35D8974", Offset = "0x35D8974", VA = "0x35D8974")]
		set
		{
		}
	}

	[Token(Token = "0x17001A57")]
	public uint idCodec
	{
		[Token(Token = "0x6018F5C")]
		[Address(RVA = "0x35D8B1C", Offset = "0x35D8B1C", VA = "0x35D8B1C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F5B")]
		[Address(RVA = "0x35D8A8C", Offset = "0x35D8A8C", VA = "0x35D8A8C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A58")]
	public string szFile
	{
		[Token(Token = "0x6018F5E")]
		[Address(RVA = "0x35D8C34", Offset = "0x35D8C34", VA = "0x35D8C34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F5D")]
		[Address(RVA = "0x35D8BA4", Offset = "0x35D8BA4", VA = "0x35D8BA4")]
		set
		{
		}
	}

	[Token(Token = "0x17001A59")]
	public IntPtr pInMemory
	{
		[Token(Token = "0x6018F60")]
		[Address(RVA = "0x35D8D88", Offset = "0x35D8D88", VA = "0x35D8D88")]
		get
		{
			return default(IntPtr);
		}
		[Token(Token = "0x6018F5F")]
		[Address(RVA = "0x35D8CF8", Offset = "0x35D8CF8", VA = "0x35D8CF8")]
		set
		{
		}
	}

	[Token(Token = "0x17001A5A")]
	public uint uiMemorySize
	{
		[Token(Token = "0x6018F62")]
		[Address(RVA = "0x35D8EA0", Offset = "0x35D8EA0", VA = "0x35D8EA0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F61")]
		[Address(RVA = "0x35D8E10", Offset = "0x35D8E10", VA = "0x35D8E10")]
		set
		{
		}
	}

	[Token(Token = "0x17001A5B")]
	public uint idFile
	{
		[Token(Token = "0x6018F64")]
		[Address(RVA = "0x35D8FB8", Offset = "0x35D8FB8", VA = "0x35D8FB8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F63")]
		[Address(RVA = "0x35D8F28", Offset = "0x35D8F28", VA = "0x35D8F28")]
		set
		{
		}
	}

	[Token(Token = "0x6018F4D")]
	[Address(RVA = "0x35D8280", Offset = "0x35D8280", VA = "0x35D8280")]
	internal AkExternalSourceInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018F4E")]
	[Address(RVA = "0x35D82A8", Offset = "0x35D82A8", VA = "0x35D82A8")]
	public AkExternalSourceInfo()
	{
	}

	[Token(Token = "0x6018F4F")]
	[Address(RVA = "0x35D8344", Offset = "0x35D8344", VA = "0x35D8344")]
	public AkExternalSourceInfo(IntPtr in_pInMemory, uint in_uiMemorySize, uint in_iExternalSrcCookie, uint in_idCodec)
	{
	}

	[Token(Token = "0x6018F50")]
	[Address(RVA = "0x35D840C", Offset = "0x35D840C", VA = "0x35D840C")]
	public AkExternalSourceInfo(string in_pszFileName, uint in_iExternalSrcCookie, uint in_idCodec)
	{
	}

	[Token(Token = "0x6018F51")]
	[Address(RVA = "0x35D84C0", Offset = "0x35D84C0", VA = "0x35D84C0")]
	public AkExternalSourceInfo(uint in_idFile, uint in_iExternalSrcCookie, uint in_idCodec)
	{
	}

	[Token(Token = "0x6018F52")]
	[Address(RVA = "0x35D8574", Offset = "0x35D8574", VA = "0x35D8574")]
	internal static IntPtr getCPtr(AkExternalSourceInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018F53")]
	[Address(RVA = "0x35D85CC", Offset = "0x35D85CC", VA = "0x35D85CC", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018F54")]
	[Address(RVA = "0x35D85F8", Offset = "0x35D85F8", VA = "0x35D85F8", Slot = "1")]
	~AkExternalSourceInfo()
	{
	}

	[Token(Token = "0x6018F55")]
	[Address(RVA = "0x35D866C", Offset = "0x35D866C", VA = "0x35D866C", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6018F56")]
	[Address(RVA = "0x35D8798", Offset = "0x35D8798", VA = "0x35D8798")]
	public void Clear()
	{
	}

	[Token(Token = "0x6018F57")]
	[Address(RVA = "0x35D8820", Offset = "0x35D8820", VA = "0x35D8820")]
	public void Clone(AkExternalSourceInfo other)
	{
	}

	[Token(Token = "0x6018F58")]
	[Address(RVA = "0x35D88F8", Offset = "0x35D88F8", VA = "0x35D88F8")]
	public static int GetSizeOf()
	{
		return default(int);
	}
}
