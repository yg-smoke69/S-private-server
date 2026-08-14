using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031A0")]
public class NewPlayerTargetTrainingCampInfo
{
	[Token(Token = "0x4012DD0")]
	[FieldOffset(Offset = "0x8")]
	public uint GotoGuideID;

	[Token(Token = "0x6014DA8")]
	[Address(RVA = "0x28B4620", Offset = "0x28B4620", VA = "0x28B4620")]
	public NewPlayerTargetTrainingCampInfo()
	{
	}

	[Token(Token = "0x6014DA9")]
	[Address(RVA = "0x28B4628", Offset = "0x28B4628", VA = "0x28B4628")]
	public static implicit operator NewPlayerTargetTrainingCampInfo(NewPlayerTargetData data)
	{
		return null;
	}
}
