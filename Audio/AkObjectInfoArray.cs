using System;
using Il2CppDummyDll;

[Token(Token = "0x2003DE4")]
public class AkObjectInfoArray : AkBaseArray<AkObjectInfo>
{
	[Token(Token = "0x17001B3C")]
	protected override int StructureSize
	{
		[Token(Token = "0x6019311")]
		[Address(RVA = "0x36BBCFC", Offset = "0x36BBCFC", VA = "0x36BBCFC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6019310")]
	[Address(RVA = "0x36BBC90", Offset = "0x36BBC90", VA = "0x36BBC90")]
	public AkObjectInfoArray(int count)
	{
	}

	[Token(Token = "0x6019312")]
	[Address(RVA = "0x36BBD78", Offset = "0x36BBD78", VA = "0x36BBD78", Slot = "7")]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[Token(Token = "0x6019313")]
	[Address(RVA = "0x36BBDFC", Offset = "0x36BBDFC", VA = "0x36BBDFC", Slot = "9")]
	protected override AkObjectInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[Token(Token = "0x6019314")]
	[Address(RVA = "0x36BBE78", Offset = "0x36BBE78", VA = "0x36BBE78", Slot = "10")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObjectInfo other)
	{
	}
}
