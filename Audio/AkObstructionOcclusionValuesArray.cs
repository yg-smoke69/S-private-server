using System;
using Il2CppDummyDll;

[Token(Token = "0x2003DE5")]
public class AkObstructionOcclusionValuesArray : AkBaseArray<AkObstructionOcclusionValues>
{
	[Token(Token = "0x17001B3D")]
	protected override int StructureSize
	{
		[Token(Token = "0x6019316")]
		[Address(RVA = "0x36BD410", Offset = "0x36BD410", VA = "0x36BD410", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6019315")]
	[Address(RVA = "0x36BD3A4", Offset = "0x36BD3A4", VA = "0x36BD3A4")]
	public AkObstructionOcclusionValuesArray(int count)
	{
	}

	[Token(Token = "0x6019317")]
	[Address(RVA = "0x36BD48C", Offset = "0x36BD48C", VA = "0x36BD48C", Slot = "7")]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[Token(Token = "0x6019318")]
	[Address(RVA = "0x36BD510", Offset = "0x36BD510", VA = "0x36BD510", Slot = "9")]
	protected override AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[Token(Token = "0x6019319")]
	[Address(RVA = "0x36BD58C", Offset = "0x36BD58C", VA = "0x36BD58C", Slot = "10")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObstructionOcclusionValues other)
	{
	}
}
