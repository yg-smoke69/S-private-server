using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200023B")]
public class SpecialCharacterVoiceConfigData : CSVBaseData
{
	[Token(Token = "0x200023C")]
	private enum EStackType
	{
		[Token(Token = "0x4000DAB")]
		Always,
		[Token(Token = "0x4000DAC")]
		Once
	}

	[Token(Token = "0x200023D")]
	private enum EAudibleRange
	{
		[Token(Token = "0x4000DAE")]
		OnlySelf,
		[Token(Token = "0x4000DAF")]
		Teammates
	}

	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000D9E")]
	[FieldOffset(Offset = "0xC")]
	public uint[] CharacterID;

	[Token(Token = "0x4000D9F")]
	[FieldOffset(Offset = "0x10")]
	public uint[] GameModeSetting;

	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0x14")]
	public uint EffectsTriggerEventID;

	[Token(Token = "0x4000DA1")]
	[FieldOffset(Offset = "0x18")]
	public uint EffectsConditionID;

	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0x1C")]
	public string EffectsConditionParam;

	[Token(Token = "0x4000DA3")]
	[FieldOffset(Offset = "0x20")]
	private string EffectSoundIDName;

	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0x24")]
	private ResourceID EffectSoundID;

	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0x28")]
	public int Priority;

	[Token(Token = "0x4000DA6")]
	[FieldOffset(Offset = "0x2C")]
	public string[] LangSuffix;

	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0x30")]
	public float AudioColdDownTime;

	[Token(Token = "0x4000DA8")]
	[FieldOffset(Offset = "0x34")]
	public int StackType;

	[Token(Token = "0x4000DA9")]
	[FieldOffset(Offset = "0x38")]
	public int AudibleRange;

	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x20FBF7C", Offset = "0x20FBF7C", VA = "0x20FBF7C")]
	public SpecialCharacterVoiceConfigData()
	{
	}

	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x20FC000", Offset = "0x20FC000", VA = "0x20FC000", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x20FC080", Offset = "0x20FC080", VA = "0x20FC080", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0x20FC444", Offset = "0x20FC444", VA = "0x20FC444")]
	public ResourceID GetEffectSoundID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x20FC800", Offset = "0x20FC800", VA = "0x20FC800")]
	public bool IsTriggerOnce()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0x20FC864", Offset = "0x20FC864", VA = "0x20FC864")]
	public bool IsOnlySelfCanTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x20FC8D0", Offset = "0x20FC8D0", VA = "0x20FC8D0")]
	public bool CheckModeSetting(uint mode)
	{
		return default(bool);
	}
}
