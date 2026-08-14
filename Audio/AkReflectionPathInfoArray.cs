using System;
using Il2CppDummyDll;

[Token(Token = "0x2003DE7")]
public class AkReflectionPathInfoArray : AkBaseArray<AkReflectionPathInfo>
{
	[Token(Token = "0x17001B3F")]
	protected override int StructureSize
	{
		[Token(Token = "0x6019322")]
		[Address(RVA = "0x36C5BC0", Offset = "0x36C5BC0", VA = "0x36C5BC0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6019321")]
	[Address(RVA = "0x36C5B54", Offset = "0x36C5B54", VA = "0x36C5B54")]
	public AkReflectionPathInfoArray(int count)
	{
	}

	[Token(Token = "0x6019323")]
	[Address(RVA = "0x36C5C3C", Offset = "0x36C5C3C", VA = "0x36C5C3C", Slot = "9")]
	protected override AkReflectionPathInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[Token(Token = "0x6019324")]
	[Address(RVA = "0x36C5CB8", Offset = "0x36C5CB8", VA = "0x36C5CB8", Slot = "10")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkReflectionPathInfo other)
	{
	}
}
