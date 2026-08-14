using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A88")]
public class UIProfileClanWarMatchResultController : UIProfileCSMatchResultController
{
	[Token(Token = "0x601153D")]
	[Address(RVA = "0xF130C4", Offset = "0xF130C4", VA = "0xF130C4")]
	public UIProfileClanWarMatchResultController()
	{
	}

	[Token(Token = "0x601153E")]
	[Address(RVA = "0xF130D4", Offset = "0xF130D4", VA = "0xF130D4")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601153F")]
	[Address(RVA = "0xF13178", Offset = "0xF13178", VA = "0xF13178", Slot = "46")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x6011540")]
	[Address(RVA = "0xF13248", Offset = "0xF13248", VA = "0xF13248", Slot = "50")]
	protected override void UpdateMVPInfo(List<TeammateStats> players, bool win, bool show = false, bool showMVP = true)
	{
	}

	[Token(Token = "0x6011541")]
	[Address(RVA = "0xF1340C", Offset = "0xF1340C", VA = "0xF1340C")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x6011542")]
	[Address(RVA = "0xF13410", Offset = "0xF13410", VA = "0xF13410")]
	public void _003C_003EiFixBaseProxy_UpdateMVPInfo(List<TeammateStats> P0, bool P1, bool P2, bool P3)
	{
	}
}
