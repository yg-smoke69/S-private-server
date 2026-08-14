using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000226")]
public class SceneEditSlotUnlockManager : SingletonModule<SceneEditSlotUnlockManager>
{
	[Token(Token = "0x4000CD8")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, SceneEditSlotUnlockConfigData> m_SlotUnlockDic;

	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0x10")]
	private uint m_MaxSlotID;

	[Token(Token = "0x6000AE8")]
	[Address(RVA = "0x20DC004", Offset = "0x20DC004", VA = "0x20DC004")]
	public SceneEditSlotUnlockManager()
	{
	}

	[Token(Token = "0x6000AE9")]
	[Address(RVA = "0x20DC0C8", Offset = "0x20DC0C8", VA = "0x20DC0C8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0x20DC340", Offset = "0x20DC340", VA = "0x20DC340")]
	public uint GetMaxSlotCnt()
	{
		return default(uint);
	}

	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0x20DC398", Offset = "0x20DC398", VA = "0x20DC398")]
	public SceneEditSlotUnlockConfigData GetSlotUnlcokDataBySlotID(uint slotID)
	{
		return null;
	}

	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0x20DC488", Offset = "0x20DC488", VA = "0x20DC488", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
