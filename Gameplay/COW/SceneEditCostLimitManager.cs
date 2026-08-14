using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000275")]
public class SceneEditCostLimitManager : SingletonModule<SceneEditCostLimitManager>
{
	[Token(Token = "0x4000EEB")]
	[FieldOffset(Offset = "0xC")]
	private List<WorkshopCostLimitData> m_CostLimitDataList;

	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x241EF28", Offset = "0x241EF28", VA = "0x241EF28")]
	public SceneEditCostLimitManager()
	{
	}

	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x241EFEC", Offset = "0x241EFEC", VA = "0x241EFEC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x241F224", Offset = "0x241F224", VA = "0x241F224")]
	public WorkshopCostLimitData GetCurrentCostLimitData(float costPercent)
	{
		return null;
	}

	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0x241F3AC", Offset = "0x241F3AC", VA = "0x241F3AC", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
