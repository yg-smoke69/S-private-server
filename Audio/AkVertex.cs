using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003DAE")]
public class AkVertex : _Attribute
{
	[Token(Token = "0x401A36A")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A36B")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001B16")]
	public float X
	{
		[Token(Token = "0x6019200")]
		[Address(RVA = "0x2EBFAF4", Offset = "0x2EBFAF4", VA = "0x2EBFAF4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60191FF")]
		[Address(RVA = "0x2EB9FE4", Offset = "0x2EB9FE4", VA = "0x2EB9FE4")]
		set
		{
		}
	}

	[Token(Token = "0x17001B17")]
	public float Y
	{
		[Token(Token = "0x6019202")]
		[Address(RVA = "0x2EBFB7C", Offset = "0x2EBFB7C", VA = "0x2EBFB7C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019201")]
		[Address(RVA = "0x2EBA074", Offset = "0x2EBA074", VA = "0x2EBA074")]
		set
		{
		}
	}

	[Token(Token = "0x17001B18")]
	public float Z
	{
		[Token(Token = "0x6019204")]
		[Address(RVA = "0x2EBFC04", Offset = "0x2EBFC04", VA = "0x2EBFC04")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019203")]
		[Address(RVA = "0x2EBA104", Offset = "0x2EBA104", VA = "0x2EBA104")]
		set
		{
		}
	}

	[Token(Token = "0x60191F8")]
	[Address(RVA = "0x2EBF758", Offset = "0x2EBF758", VA = "0x2EBF758")]
	internal AkVertex(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60191F9")]
	[Address(RVA = "0x2EBF780", Offset = "0x2EBF780", VA = "0x2EBF780")]
	public AkVertex()
	{
	}

	[Token(Token = "0x60191FA")]
	[Address(RVA = "0x2EBF81C", Offset = "0x2EBF81C", VA = "0x2EBF81C")]
	public AkVertex(float in_X, float in_Y, float in_Z)
	{
	}

	[Token(Token = "0x60191FB")]
	[Address(RVA = "0x2EBF8D0", Offset = "0x2EBF8D0", VA = "0x2EBF8D0")]
	internal static IntPtr getCPtr(AkVertex obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60191FC")]
	[Address(RVA = "0x2EBF928", Offset = "0x2EBF928", VA = "0x2EBF928", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60191FD")]
	[Address(RVA = "0x2EBF954", Offset = "0x2EBF954", VA = "0x2EBF954", Slot = "1")]
	~AkVertex()
	{
	}

	[Token(Token = "0x60191FE")]
	[Address(RVA = "0x2EBF9C8", Offset = "0x2EBF9C8", VA = "0x2EBF9C8", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6019205")]
	[Address(RVA = "0x2EBFC8C", Offset = "0x2EBFC8C", VA = "0x2EBFC8C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6019206")]
	[Address(RVA = "0x2EBFD14", Offset = "0x2EBFD14", VA = "0x2EBFD14")]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[Token(Token = "0x6019207")]
	[Address(RVA = "0x2EBFD90", Offset = "0x2EBFD90", VA = "0x2EBFD90")]
	public void Clone(AkVertex other)
	{
	}
}
