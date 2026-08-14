using System;
using Il2CppDummyDll;

[Token(Token = "0x2003DDD")]
public class AkAcousticSurfaceArray : AkBaseArray<AkAcousticSurface>
{
	[Token(Token = "0x17001B32")]
	protected override int StructureSize
	{
		[Token(Token = "0x60192D4")]
		[Address(RVA = "0x35BEE64", Offset = "0x35BEE64", VA = "0x35BEE64", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60192D3")]
	[Address(RVA = "0x35BEDF8", Offset = "0x35BEDF8", VA = "0x35BEDF8")]
	public AkAcousticSurfaceArray(int count)
	{
	}

	[Token(Token = "0x60192D5")]
	[Address(RVA = "0x35BEEE0", Offset = "0x35BEEE0", VA = "0x35BEEE0", Slot = "7")]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[Token(Token = "0x60192D6")]
	[Address(RVA = "0x35BEF64", Offset = "0x35BEF64", VA = "0x35BEF64", Slot = "9")]
	protected override AkAcousticSurface CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[Token(Token = "0x60192D7")]
	[Address(RVA = "0x35BEFE0", Offset = "0x35BEFE0", VA = "0x35BEFE0", Slot = "10")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkAcousticSurface other)
	{
	}
}
