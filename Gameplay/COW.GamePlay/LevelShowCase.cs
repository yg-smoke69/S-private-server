using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000697")]
public class LevelShowCase : BaseLevelObject
{
	[Token(Token = "0x40048B8")]
	[FieldOffset(Offset = "0x74")]
	public Transform m_ItemRoot;

	[Token(Token = "0x40048B9")]
	[FieldOffset(Offset = "0x78")]
	public Transform m_Bottom;

	[Token(Token = "0x40048BA")]
	[FieldOffset(Offset = "0x7C")]
	public Transform m_Effect;

	[Token(Token = "0x40048BB")]
	[FieldOffset(Offset = "0x80")]
	public Transform m_EffectLow;

	[Token(Token = "0x40048BC")]
	[FieldOffset(Offset = "0x84")]
	public uint m_DataID;

	[Token(Token = "0x40048BD")]
	[FieldOffset(Offset = "0x88")]
	private ArenaShowCaseData BOPLAOANKBI;

	[Token(Token = "0x6002A4D")]
	[Address(RVA = "0x20CE6CC", Offset = "0x20CE6CC", VA = "0x20CE6CC")]
	public LevelShowCase()
	{
	}

	[Token(Token = "0x6002A4E")]
	[Address(RVA = "0x20CE6D4", Offset = "0x20CE6D4", VA = "0x20CE6D4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A4F")]
	[Address(RVA = "0x20CE778", Offset = "0x20CE778", VA = "0x20CE778")]
	public void InitShowCase()
	{
	}

	[Token(Token = "0x6002A50")]
	[Address(RVA = "0x20CEC90", Offset = "0x20CEC90", VA = "0x20CEC90")]
	public void ShowIntroduction()
	{
	}

	[Token(Token = "0x6002A51")]
	[Address(RVA = "0x20CF000", Offset = "0x20CF000", VA = "0x20CF000")]
	public void HideIntroduction()
	{
	}

	[Token(Token = "0x6002A52")]
	[Address(RVA = "0x20CF1A8", Offset = "0x20CF1A8", VA = "0x20CF1A8", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002A53")]
	[Address(RVA = "0x20CF288", Offset = "0x20CF288", VA = "0x20CF288")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
