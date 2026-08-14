using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A9E")]
public class UIProfileFlagBattleMatchResultController : UIProfileCSMatchResultController
{
	[Token(Token = "0x601169B")]
	[Address(RVA = "0x16E8EF0", Offset = "0x16E8EF0", VA = "0x16E8EF0")]
	public UIProfileFlagBattleMatchResultController()
	{
	}

	[Token(Token = "0x601169C")]
	[Address(RVA = "0x16E8EF8", Offset = "0x16E8EF8", VA = "0x16E8EF8")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601169D")]
	[Address(RVA = "0x16E8F9C", Offset = "0x16E8F9C", VA = "0x16E8F9C", Slot = "46")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x601169E")]
	[Address(RVA = "0x16E906C", Offset = "0x16E906C", VA = "0x16E906C", Slot = "47")]
	protected override int[] GetInfoTypesData()
	{
		return null;
	}

	[Token(Token = "0x601169F")]
	[Address(RVA = "0x16E913C", Offset = "0x16E913C", VA = "0x16E913C", Slot = "50")]
	protected override void UpdateMVPInfo(List<TeammateStats> players, bool win, bool show = false, bool showMVP = true)
	{
	}

	[Token(Token = "0x60116A0")]
	[Address(RVA = "0x16E9318", Offset = "0x16E9318", VA = "0x16E9318")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x60116A1")]
	[Address(RVA = "0x16E9320", Offset = "0x16E9320", VA = "0x16E9320")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypesData()
	{
		return null;
	}

	[Token(Token = "0x60116A2")]
	[Address(RVA = "0x16E9328", Offset = "0x16E9328", VA = "0x16E9328")]
	public void _003C_003EiFixBaseProxy_UpdateMVPInfo(List<TeammateStats> P0, bool P1, bool P2, bool P3)
	{
	}
}
