using System;
using Il2CppDummyDll;

[Token(Token = "0x2003DE1")]
public class AkDiffractionPathInfoArray : AkBaseArray<AkDiffractionPathInfo>
{
	[Token(Token = "0x17001B39")]
	protected override int StructureSize
	{
		[Token(Token = "0x60192FE")]
		[Address(RVA = "0x35D3284", Offset = "0x35D3284", VA = "0x35D3284", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60192FD")]
	[Address(RVA = "0x35D3218", Offset = "0x35D3218", VA = "0x35D3218")]
	public AkDiffractionPathInfoArray(int count)
	{
	}

	[Token(Token = "0x60192FF")]
	[Address(RVA = "0x35D3300", Offset = "0x35D3300", VA = "0x35D3300", Slot = "9")]
	protected override AkDiffractionPathInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[Token(Token = "0x6019300")]
	[Address(RVA = "0x35D337C", Offset = "0x35D337C", VA = "0x35D337C", Slot = "10")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDiffractionPathInfo other)
	{
	}
}
