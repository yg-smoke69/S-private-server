using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000284")]
public class ClimbingTriggerSettingManager : SingletonModule<ClimbingTriggerSettingManager>
{
	[Token(Token = "0x4000F55")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, Dictionary<uint, ClimbingTriggerSettingData>> m_ClimbingTriggerSettings;

	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x172D218", Offset = "0x172D218", VA = "0x172D218")]
	public ClimbingTriggerSettingManager()
	{
	}

	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x172D2DC", Offset = "0x172D2DC", VA = "0x172D2DC", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x172D330", Offset = "0x172D330", VA = "0x172D330", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x172D7D0", Offset = "0x172D7D0", VA = "0x172D7D0")]
	private Dictionary<uint, ClimbingTriggerSettingData> LoadClimbingTriggerSettings(ResourceID resID)
	{
		return null;
	}

	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x172DA5C", Offset = "0x172DA5C", VA = "0x172DA5C")]
	public ClimbingTriggerSettingData GetClimbingTriggerSetting(uint map_id, uint mode_id, uint climbing_trigger_id)
	{
		return null;
	}
}
