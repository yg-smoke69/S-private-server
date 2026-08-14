using System;
using Il2CppDummyDll;

[Token(Token = "0x2003DE2")]
public class AkExternalSourceInfoArray : AkBaseArray<AkExternalSourceInfo>
{
	[Token(Token = "0x17001B3A")]
	protected override int StructureSize
	{
		[Token(Token = "0x6019302")]
		[Address(RVA = "0x35D90AC", Offset = "0x35D90AC", VA = "0x35D90AC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6019301")]
	[Address(RVA = "0x35D9040", Offset = "0x35D9040", VA = "0x35D9040")]
	public AkExternalSourceInfoArray(int count)
	{
	}

	[Token(Token = "0x6019303")]
	[Address(RVA = "0x35D9128", Offset = "0x35D9128", VA = "0x35D9128", Slot = "7")]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[Token(Token = "0x6019304")]
	[Address(RVA = "0x35D91AC", Offset = "0x35D91AC", VA = "0x35D91AC", Slot = "8")]
	protected override void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address)
	{
	}

	[Token(Token = "0x6019305")]
	[Address(RVA = "0x35D9234", Offset = "0x35D9234", VA = "0x35D9234", Slot = "9")]
	protected override AkExternalSourceInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[Token(Token = "0x6019306")]
	[Address(RVA = "0x35D92B0", Offset = "0x35D92B0", VA = "0x35D92B0", Slot = "10")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkExternalSourceInfo other)
	{
	}
}
