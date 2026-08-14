using System;
using Il2CppDummyDll;

[Token(Token = "0x2003DE8")]
public class AkSourceSettingsArray : AkBaseArray<AkSourceSettings>
{
	[Token(Token = "0x17001B40")]
	protected override int StructureSize
	{
		[Token(Token = "0x6019326")]
		[Address(RVA = "0x2EB6808", Offset = "0x2EB6808", VA = "0x2EB6808", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6019325")]
	[Address(RVA = "0x2EB679C", Offset = "0x2EB679C", VA = "0x2EB679C")]
	public AkSourceSettingsArray(int count)
	{
	}

	[Token(Token = "0x6019327")]
	[Address(RVA = "0x2EB6884", Offset = "0x2EB6884", VA = "0x2EB6884", Slot = "7")]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[Token(Token = "0x6019328")]
	[Address(RVA = "0x2EB6908", Offset = "0x2EB6908", VA = "0x2EB6908", Slot = "9")]
	protected override AkSourceSettings CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[Token(Token = "0x6019329")]
	[Address(RVA = "0x2EB6984", Offset = "0x2EB6984", VA = "0x2EB6984", Slot = "10")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkSourceSettings other)
	{
	}
}
