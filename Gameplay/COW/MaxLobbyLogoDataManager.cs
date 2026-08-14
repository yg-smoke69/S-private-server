using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001A6")]
public class MaxLobbyLogoDataManager : SingletonModule<MaxLobbyLogoDataManager>
{
	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, MaxLobbyLogoData> m_Data;

	[Token(Token = "0x600091F")]
	[Address(RVA = "0x1546E38", Offset = "0x1546E38", VA = "0x1546E38")]
	public MaxLobbyLogoDataManager()
	{
	}

	[Token(Token = "0x6000920")]
	[Address(RVA = "0x1546EFC", Offset = "0x1546EFC", VA = "0x1546EFC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000921")]
	[Address(RVA = "0x1546F50", Offset = "0x1546F50", VA = "0x1546F50")]
	public void LoadWithRegion()
	{
	}

	[Token(Token = "0x6000922")]
	[Address(RVA = "0x1547404", Offset = "0x1547404", VA = "0x1547404", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000923")]
	[Address(RVA = "0x15474C4", Offset = "0x15474C4", VA = "0x15474C4")]
	public MaxLobbyLogoData GetMaxLobbyLogoData(uint clothesID)
	{
		return null;
	}
}
