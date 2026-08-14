using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DF7")]
public class LoadingTipsDataManager : SingletonModule<LoadingTipsDataManager>
{
	[Token(Token = "0x40119F3")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, List<LoadingTipsData>> m_dictTypeToTipsData;

	[Token(Token = "0x40119F4")]
	[FieldOffset(Offset = "0x10")]
	private string m_currentTip;

	[Token(Token = "0x40119F5")]
	[FieldOffset(Offset = "0x14")]
	private uint m_currentGameModeId;

	[Token(Token = "0x6013435")]
	[Address(RVA = "0xEC9F5C", Offset = "0xEC9F5C", VA = "0xEC9F5C")]
	public LoadingTipsDataManager()
	{
	}

	[Token(Token = "0x6013436")]
	[Address(RVA = "0xECA020", Offset = "0xECA020", VA = "0xECA020", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013437")]
	[Address(RVA = "0xECA0E8", Offset = "0xECA0E8", VA = "0xECA0E8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013438")]
	[Address(RVA = "0xECA4A8", Offset = "0xECA4A8", VA = "0xECA4A8")]
	public List<LoadingTipsData> FindTipsDataById(uint modeId)
	{
		return null;
	}

	[Token(Token = "0x6013439")]
	[Address(RVA = "0xECA5D0", Offset = "0xECA5D0", VA = "0xECA5D0")]
	public string GetRandomLoadingTips(uint gameModeId)
	{
		return null;
	}

	[Token(Token = "0x601343A")]
	[Address(RVA = "0xECABF0", Offset = "0xECABF0", VA = "0xECABF0")]
	public string GetFakeLoadingTips(uint gameModeId)
	{
		return null;
	}

	[Token(Token = "0x601343B")]
	[Address(RVA = "0xECA87C", Offset = "0xECA87C", VA = "0xECA87C")]
	private List<LoadingTipsData> FindTipsDataByIdAndLevel(uint gameModeId, uint playerLevel, uint matchMode)
	{
		return null;
	}
}
