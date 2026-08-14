using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D58")]
public class AkAcousticSurface : _Attribute
{
	[Token(Token = "0x401A161")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A162")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A17")]
	public uint textureID
	{
		[Token(Token = "0x6018E5E")]
		[Address(RVA = "0x35BE8A0", Offset = "0x35BE8A0", VA = "0x35BE8A0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E5D")]
		[Address(RVA = "0x35BE810", Offset = "0x35BE810", VA = "0x35BE810")]
		set
		{
		}
	}

	[Token(Token = "0x17001A18")]
	public uint reflectorChannelMask
	{
		[Token(Token = "0x6018E60")]
		[Address(RVA = "0x35BE9B8", Offset = "0x35BE9B8", VA = "0x35BE9B8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E5F")]
		[Address(RVA = "0x35BE928", Offset = "0x35BE928", VA = "0x35BE928")]
		set
		{
		}
	}

	[Token(Token = "0x17001A19")]
	public string strName
	{
		[Token(Token = "0x6018E62")]
		[Address(RVA = "0x35BEAD0", Offset = "0x35BEAD0", VA = "0x35BEAD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018E61")]
		[Address(RVA = "0x35BEA40", Offset = "0x35BEA40", VA = "0x35BEA40")]
		set
		{
		}
	}

	[Token(Token = "0x6018E57")]
	[Address(RVA = "0x35BE528", Offset = "0x35BE528", VA = "0x35BE528")]
	internal AkAcousticSurface(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018E58")]
	[Address(RVA = "0x35BE550", Offset = "0x35BE550", VA = "0x35BE550")]
	public AkAcousticSurface()
	{
	}

	[Token(Token = "0x6018E59")]
	[Address(RVA = "0x35BE5EC", Offset = "0x35BE5EC", VA = "0x35BE5EC")]
	internal static IntPtr getCPtr(AkAcousticSurface obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018E5A")]
	[Address(RVA = "0x35BE644", Offset = "0x35BE644", VA = "0x35BE644", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018E5B")]
	[Address(RVA = "0x35BE670", Offset = "0x35BE670", VA = "0x35BE670", Slot = "1")]
	~AkAcousticSurface()
	{
	}

	[Token(Token = "0x6018E5C")]
	[Address(RVA = "0x35BE6E4", Offset = "0x35BE6E4", VA = "0x35BE6E4", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6018E63")]
	[Address(RVA = "0x35BEB94", Offset = "0x35BEB94", VA = "0x35BEB94")]
	public void Clear()
	{
	}

	[Token(Token = "0x6018E64")]
	[Address(RVA = "0x35BEC1C", Offset = "0x35BEC1C", VA = "0x35BEC1C")]
	public void DeleteName()
	{
	}

	[Token(Token = "0x6018E65")]
	[Address(RVA = "0x35BECA4", Offset = "0x35BECA4", VA = "0x35BECA4")]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[Token(Token = "0x6018E66")]
	[Address(RVA = "0x35BED20", Offset = "0x35BED20", VA = "0x35BED20")]
	public void Clone(AkAcousticSurface other)
	{
	}
}
