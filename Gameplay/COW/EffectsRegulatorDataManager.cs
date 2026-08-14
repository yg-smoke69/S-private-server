using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000116")]
public class EffectsRegulatorDataManager : SingletonModule<EffectsRegulatorDataManager>
{
	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<ResourceID, EffectsRegulatorData> m_DicData;

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x2521BEC", Offset = "0x2521BEC", VA = "0x2521BEC")]
	public EffectsRegulatorDataManager()
	{
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x2521CB0", Offset = "0x2521CB0", VA = "0x2521CB0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x2521D70", Offset = "0x2521D70", VA = "0x2521D70", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x2522014", Offset = "0x2522014", VA = "0x2522014")]
	public EffectsRegulatorData GetEffectRegularData(ResourceID key)
	{
		return null;
	}
}
