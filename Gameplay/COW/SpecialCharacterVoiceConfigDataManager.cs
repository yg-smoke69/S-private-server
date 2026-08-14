using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E38")]
internal class SpecialCharacterVoiceConfigDataManager : SingletonModule<SpecialCharacterVoiceConfigDataManager>
{
	[Token(Token = "0x4011AC6")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, List<SpecialCharacterVoiceConfigData>> m_Dict;

	[Token(Token = "0x6013540")]
	[Address(RVA = "0x288CF88", Offset = "0x288CF88", VA = "0x288CF88")]
	public SpecialCharacterVoiceConfigDataManager()
	{
	}

	[Token(Token = "0x6013541")]
	[Address(RVA = "0x288D04C", Offset = "0x288D04C", VA = "0x288D04C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013542")]
	[Address(RVA = "0x288D4B0", Offset = "0x288D4B0", VA = "0x288D4B0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013543")]
	[Address(RVA = "0x288D504", Offset = "0x288D504", VA = "0x288D504")]
	public List<SpecialCharacterVoiceConfigData> GetConfigDataListByCharacterID(uint characterID)
	{
		return null;
	}
}
