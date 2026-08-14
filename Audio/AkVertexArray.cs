using System;
using Il2CppDummyDll;

[Token(Token = "0x2003DEA")]
public class AkVertexArray : AkBaseArray<AkVertex>
{
	[Token(Token = "0x17001B42")]
	protected override int StructureSize
	{
		[Token(Token = "0x6019330")]
		[Address(RVA = "0x2EBFE68", Offset = "0x2EBFE68", VA = "0x2EBFE68", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x601932F")]
	[Address(RVA = "0x2EB9F78", Offset = "0x2EB9F78", VA = "0x2EB9F78")]
	public AkVertexArray(int count)
	{
	}

	[Token(Token = "0x6019331")]
	[Address(RVA = "0x2EBFEE4", Offset = "0x2EBFEE4", VA = "0x2EBFEE4", Slot = "7")]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[Token(Token = "0x6019332")]
	[Address(RVA = "0x2EBFF68", Offset = "0x2EBFF68", VA = "0x2EBFF68", Slot = "9")]
	protected override AkVertex CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[Token(Token = "0x6019333")]
	[Address(RVA = "0x2EBFFE4", Offset = "0x2EBFFE4", VA = "0x2EBFFE4", Slot = "10")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkVertex other)
	{
	}
}
