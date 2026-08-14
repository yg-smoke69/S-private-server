using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024D9")]
internal class SuitDisplayData
{
	[Token(Token = "0x400E479")]
	[FieldOffset(Offset = "0x8")]
	public AvatarSuit suit;

	[Token(Token = "0x400E47A")]
	[FieldOffset(Offset = "0xC")]
	public bool isSelected;

	[Token(Token = "0x400E47B")]
	[FieldOffset(Offset = "0xD")]
	public bool isEquiping;

	[Token(Token = "0x400E47C")]
	[FieldOffset(Offset = "0xE")]
	public bool isNeedDownloadAB;

	[Token(Token = "0x600D424")]
	[Address(RVA = "0x2891918", Offset = "0x2891918", VA = "0x2891918")]
	public SuitDisplayData()
	{
	}
}
