using System;
using Il2CppDummyDll;

namespace AK.Wwise;

[Serializable]
[Token(Token = "0x2003DFD")]
public abstract class BaseType
{
	[Token(Token = "0x401A47B")]
	[FieldOffset(Offset = "0x8")]
	private int idInternal;

	[Token(Token = "0x401A47C")]
	[FieldOffset(Offset = "0xC")]
	private byte[] valueGuidInternal;

	[Token(Token = "0x17001B64")]
	public abstract WwiseObjectReference ObjectReference
	{
		[Token(Token = "0x6019380")]
		get;
		[Token(Token = "0x6019381")]
		set;
	}

	[Token(Token = "0x17001B65")]
	public abstract WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x6019382")]
		get;
	}

	[Token(Token = "0x17001B66")]
	public virtual string Name
	{
		[Token(Token = "0x6019383")]
		[Address(RVA = "0x35BCB90", Offset = "0x35BCB90", VA = "0x35BCB90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B67")]
	public uint Id
	{
		[Token(Token = "0x6019384")]
		[Address(RVA = "0x35BCC7C", Offset = "0x35BCC7C", VA = "0x35BCC7C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001B68")]
	public int ID
	{
		[Token(Token = "0x6019389")]
		[Address(RVA = "0x35BCF44", Offset = "0x35BCF44", VA = "0x35BCF44")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B69")]
	public byte[] valueGuid
	{
		[Token(Token = "0x601938A")]
		[Address(RVA = "0x35BCF48", Offset = "0x35BCF48", VA = "0x35BCF48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601937F")]
	[Address(RVA = "0x35BBD94", Offset = "0x35BBD94", VA = "0x35BBD94")]
	protected BaseType()
	{
	}

	[Token(Token = "0x6019385")]
	[Address(RVA = "0x35BCAE0", Offset = "0x35BCAE0", VA = "0x35BCAE0", Slot = "8")]
	public virtual bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6019386")]
	[Address(RVA = "0x35BCCE0", Offset = "0x35BCCE0", VA = "0x35BCCE0")]
	public bool Validate()
	{
		return default(bool);
	}

	[Token(Token = "0x6019387")]
	[Address(RVA = "0x35BCE20", Offset = "0x35BCE20", VA = "0x35BCE20")]
	protected void Verify(AKRESULT result)
	{
	}

	[Token(Token = "0x6019388")]
	[Address(RVA = "0x35BCE24", Offset = "0x35BCE24", VA = "0x35BCE24", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
