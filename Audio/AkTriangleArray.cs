using System;
using Il2CppDummyDll;

[Token(Token = "0x2003DE9")]
public class AkTriangleArray : AkBaseArray<AkTriangle>
{
	[Token(Token = "0x17001B41")]
	protected override int StructureSize
	{
		[Token(Token = "0x601932B")]
		[Address(RVA = "0x2EBC728", Offset = "0x2EBC728", VA = "0x2EBC728", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x601932A")]
	[Address(RVA = "0x2EBA194", Offset = "0x2EBA194", VA = "0x2EBA194")]
	public AkTriangleArray(int count)
	{
	}

	[Token(Token = "0x601932C")]
	[Address(RVA = "0x2EBC7A4", Offset = "0x2EBC7A4", VA = "0x2EBC7A4", Slot = "7")]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[Token(Token = "0x601932D")]
	[Address(RVA = "0x2EBC828", Offset = "0x2EBC828", VA = "0x2EBC828", Slot = "9")]
	protected override AkTriangle CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[Token(Token = "0x601932E")]
	[Address(RVA = "0x2EBC8A4", Offset = "0x2EBC8A4", VA = "0x2EBC8A4", Slot = "10")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkTriangle other)
	{
	}
}
